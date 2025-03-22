public class Report
{
    public int Id { get; set; }
    public string title { get; set; }
    public string Description { get; set; }
    public ReportType Type { get; set; }
    public DateTime ReportDate { get; set; }
    public Employee GeneratedbyEmployee
    { get; set; }
    public int GeneratedbyEmployeeID { get; set; }
    public string FilePath { get; set; }
    public Dictionary<string, string> Parameters { get; set; }


}