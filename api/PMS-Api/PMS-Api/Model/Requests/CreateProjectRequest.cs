namespace PMS_Api.Model.Requests;


public class CreateProjectRequest
{
    public string Name { get; set; }
    public Guid ClientId { get; set; }
    public int ProductId { get; set; }
    public string Format { get; set; }
}