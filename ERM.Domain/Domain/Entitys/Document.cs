public class Document
{
    public int id { get; set; }
    public string FileName { get; set; }
    public string FilePath { get; set; }
    public string FileType {  get; set; }
    public long FileSize { get; set; }
    public Employee UploadedByEmployee { get; set; }
    public DateTime UploadTIme { get; set; }
    public int UploadedbyEmployeeID { get; set; }
    public string description { get; set; }
    public int? Version { get; set; }
    public int? ParentDocumentId { get; set; }
    public Document ParentDocument { get; set; }
    public ICollection<Document> Versions { get; set; }


}
