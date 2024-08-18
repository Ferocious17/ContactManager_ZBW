using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models;

public class Department
{
    public Department(string name)
    {
        Name = name;
    }

    private Department() { }

    [Key]
    public int DepartmentId { get; set; }
    public string Name { get; set; }
}
