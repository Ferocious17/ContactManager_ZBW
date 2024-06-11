namespace ContactManager.Models;

public class Department(int departmentId, string name)
{
    public int DepartmentId { get; set; } = departmentId;
    public string Name { get; set; } = name;
}
