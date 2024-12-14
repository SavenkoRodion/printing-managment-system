using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS_Api.Model.DbModel
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; init; }

        public required string Name { get; set; }

        [ForeignKey("Client")]
        public required Guid ClientId { get; set; }
        public Client Client { get; set; }

        [ForeignKey("Product")]
        public required int ProductId { get; set; }
        public Product Product { get; set; }

        public required string Format { get; set; }

        public required int LiczbaStron { get; set; }

        public DateTime DateModified { get; set; }

        [ForeignKey("Admin")]
        public required Guid AdminId { get; set; }
        public Admin Author { get; set; }

    }
}