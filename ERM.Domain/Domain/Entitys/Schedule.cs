public class Schedule
{
    public int Id { get; set; }
    public Employee employee { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Description { get; set; }
    public string notes { get; set; }
    public bool IsAccessed { get; set; }
    }