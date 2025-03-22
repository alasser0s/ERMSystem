public class InventoryItem { 
    public int Id { get; set; }
    public string Name { get; set; }
    public string ItemNumber { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public string Location { get; set; }
    public int MinimumStock { get; set; }
    public int RecordQuantity { get; set; }
    public bool IsActive { get; set; }
    public ICollection<InventoryTransaction> InventoryItemTransactions { get; set; }

}