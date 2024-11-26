using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS_Api.Model.DbModel
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required Guid Uuid { get; init; }

        public required string Name { get; set; }

        public required string Address { get; set; }
        public required DateTime DateOfCreation { get; init; }
        public required string Email { get; set; }
    }
}