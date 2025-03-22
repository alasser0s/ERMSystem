public class MainenanceRecords
{
    public int Id { get; set; }
    public Asset Asset { get; set; }
    public int AssetID { get; set; }
    public DateTime MaintenanceDate { get; set; }
    public string Description { get; set; }
    public string Notes { get; set; }
    public Employee Employee { get; set; }
    public int EmployeeID { get; set; }
    public string FilePath { get; set; }
    public Dictionary<string, string> Parameters { get; set; }
}