using ContactManager.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
namespace ContactManager.Models;

public class Trainee : Employee
{
    public Trainee(bool gender, string title, string firstName, string lastName, DateTime dateOfBirth, string socialSecurityNumber, CommuncationInfo communcationInfo, Address address, bool status, string nationality, Guid employeeNumber, Department department, DateTime startDate, DateTime endDate, int employment, string role, CadreLevel cadreLevel, int traineeYears, int actualTraineeYear) : base(gender, title, firstName, lastName, dateOfBirth, socialSecurityNumber, communcationInfo, address, status, nationality, employeeNumber, department, startDate, endDate, employment, role, cadreLevel)
    {
        TraineeYears = traineeYears;
        ActualTraineeYear = actualTraineeYear;
    }

    private Trainee() : base() { }

    public int TraineeYears { get; set; }
    public int ActualTraineeYear { get; set; }
}
