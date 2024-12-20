﻿using Microsoft.EntityFrameworkCore;
using PMS_Api.Interfaces;
using PMS_Api.Model.DbModel;
using PMS_Api.Enums;
using BCrypt.Net;

namespace PMS_Api.Repository;

public class AdminRepository(PmsContext context) : IUserRepository<Admin>
{
    public async Task<IReadOnlyList<Admin>> GetAllAsync(CancellationToken cancellationToken)
        => await context.Admins.AsNoTracking().ToListAsync(cancellationToken);

    public async Task<Admin?> GetByCredentialsAsync(string email, string password, CancellationToken cancellationToken)
    {
        var admin = await context.Admins.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);

        if (admin is null || !BCrypt.Net.BCrypt.Verify(password, admin.Password))
        {
            return null;
        }

        return admin;
    }

    public async Task<Admin?> GetByUuidAsync(string uuid, CancellationToken cancellationToken)
        => await context.Admins.FirstOrDefaultAsync(x => x.Uuid == Guid.Parse(uuid), cancellationToken);

    public async Task<bool> ChangePasswordAsync(Guid adminId, string password, CancellationToken cancellationToken)
    {
        var admin = await context.Admins.FirstOrDefaultAsync(x => x.Uuid == adminId, cancellationToken);
        if (admin is null)
            return false;

        admin.Password = BCrypt.Net.BCrypt.HashPassword(password);
        try
        {
            await context.SaveChangesAsync(cancellationToken);
        }
        catch
        {
            return false;
        }

        return true;
    }
    public async Task<bool> UpdateNameAsync(Guid adminId, string newName, CancellationToken cancellationToken)
    {
        var admin = await context.Admins.FirstOrDefaultAsync(x => x.Uuid == adminId, cancellationToken);
        if (admin is null)
            return false;

        admin.Name = newName;
        try
        {
            await context.SaveChangesAsync(cancellationToken);
        }
        catch
        {
            return false;
        }

        return true;
    }
    public async Task<CreateAdminResult> CreateAdminAsync(string adminName, string adminEmail, string password, CancellationToken cancellationToken)
    {
        bool userExists = await context.Admins.AnyAsync(x => x.Email == adminEmail, cancellationToken);

        if (userExists)
        {
            return CreateAdminResult.Duplicate;
        }
        password = BCrypt.Net.BCrypt.HashPassword(password);
        await context.Admins.AddAsync(new Admin()
        {
            Name = adminName,
            Email = adminEmail,
            Password = password,
            Uuid = Guid.NewGuid(),
            CreatedAt = DateOnly.FromDateTime(DateTime.Now)
        }, cancellationToken);

        try
        {
            await context.SaveChangesAsync(cancellationToken);
            return CreateAdminResult.Success;
        }
        catch
        {
            return CreateAdminResult.Failure;
        }
    }

    public async Task<bool> DeleteAdminAsync(Guid adminId, Guid currentAdminUuid, CancellationToken cancellationToken)
    {
        if (adminId == currentAdminUuid)
        {
            return false;
        }

        try
        {
            await context.Admins
                .Where(x => x.Uuid == adminId)
                .ExecuteDeleteAsync(cancellationToken);
            return true;
        }
        catch
        {
            return false;
        }
    }
}