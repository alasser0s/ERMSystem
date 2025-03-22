public class InventoryTransaction {
    public int Id { get; set; }
    public InventoryItem InventoryItem { get; set; }
    public int InventoryItemID { get; set; }
    public TransactionType Type { get; set; }
    public DateTime TransactionDate { get; set; }
    public int Quantity { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public string Notes { get; set; }
}