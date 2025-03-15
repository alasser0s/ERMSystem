using ERM.Domain.Domain;
using System.Reflection.Metadata;

public class Employee
{
    public int id { get; set; }
    public string FIrstname { get; set; }
    public string Lastname { get; set; }
    public int Phonenumber { get; set; }
    public string email { get; set; }
    public int Departmentid { get; set; }
    public Department Department { get; set; }
    public DateTime HireDate { get; set; }
    public Position Position { get; set; }
    public bool isActive { get; set; }
    public int Positionid { get; set; }
    public string Documentation { get; set; }
    public string Employeenumber { get; set; }
    public ICollection<Schedule> Schedules { get; set; }
    public ICollection<Document> Documents { get; set; }

}