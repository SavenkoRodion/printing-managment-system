﻿using PMS_Api.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS_Api.Model.DbModel;

public class Admin : IUser
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public required Guid Uuid { get; init; }
    public required string Name { get; set; }
    public required string Email { get; init; }
    public required string Password { get; set; }
    public DateOnly? CreatedAt { get; init; }

}
