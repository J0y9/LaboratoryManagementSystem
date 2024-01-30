namespace LaboratoryManagementSystem.Models;

public class Patient : BaseEntity
{
    public string Address { get; set; } = "";
    public string Phone { get; set; } = "";
    public ICollection<Test> Tests { get; set; }
    
}