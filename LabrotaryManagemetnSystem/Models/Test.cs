namespace LaboratoryManagementSystem.Models;

public class Test: BaseEntity
{
    public string Name { get; set; } = "";
    public Guid PatientId { get; set; }
    public Patient Patient { get; set; }
}