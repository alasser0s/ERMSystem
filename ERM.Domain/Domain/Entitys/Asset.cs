public class Asset
{
    public int id { get; set; }
    public string  Assetnumber { get; set; }
    public string Assetname { get; set; }
    public string Assetdescription { get; set; }
    public decimal Purchaseprice { get; set; }
    public DateTime PurchaseDate { get; set; }

    public DateTime? LastMaintenanceDate { get; set; }
    public DateTime? NextMaintenanceDate { get; set; }
    public AssetStatus status { get; set; }
    public int Assignedtoemployeeid { get; set; }
    public Employee Assignedtoemployee { get; set; }
    public ICollection<maintenancerecords> maintenancerecords { get; set; }

}