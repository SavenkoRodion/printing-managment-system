using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PMS_Api.Model.DbModel
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; init; }

        public required string Name { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; init; }
        public Client Client { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public string Format { get; set; }

        public int LiczbaStron { get; set; }

        public DateTime DateOfCreation { get; set; }

        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        public Admin Author { get; set; }
    }
}