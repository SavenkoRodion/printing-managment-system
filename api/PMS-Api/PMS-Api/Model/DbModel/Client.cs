using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PMS_Api.Model.DbModel
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; init; }

        public required string Name { get; set; }

        public ICollection<Project> Projects { get; set; } = new List<Project>();
        public ICollection<Template> Templates { get; set; } = new List<Template>();
    }
}