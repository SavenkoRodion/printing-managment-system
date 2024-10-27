using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PMS_Api.Model.DbModel;

public class Product 
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? Id { get; init; }
    public required string Name { get; init; }
    public required DateTime DateOfCreation  { get; init; } 
}