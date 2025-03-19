public class Document
{
    public int id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public ICollection<Employee> employees { get; set; }
}
