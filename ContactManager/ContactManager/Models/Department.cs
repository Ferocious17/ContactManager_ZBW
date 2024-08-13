namespace ContactManager.Models;

public class Department
{
    public Department(int departmentId, string name)
    {
        DepartmentId = departmentId;
        Name = name;
    }

    private Department() { }

    public int DepartmentId { get; set; }
    public string Name { get; set; }
}
