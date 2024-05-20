using PMS_Api.Interfaces;

namespace PMS_Api.Model.Db.Scaffold;

public partial class Admin : IUser
{
    public string Uuid { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
