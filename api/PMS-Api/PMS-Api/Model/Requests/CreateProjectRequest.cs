namespace PMS_Api.Model.Requests;


public class CreateProjectRequest
{
    public string Name { get; set; }
    public Guid ClientId { get; set; }
    public int ProductId { get; set; }
    public string Format { get; set; }
    public int LiczbaStron { get; set; }

    public Guid AdminId { get; set; }
}