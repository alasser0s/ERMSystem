public class Position
{
    public int id { get; set; }
    public string Description { get; set; } 
    public string title { get; set; }
    public ICollection<Employee> employees { get; set; }
}