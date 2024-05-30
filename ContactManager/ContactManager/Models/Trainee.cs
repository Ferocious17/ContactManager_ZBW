namespace ContactManager.Models;

public class Trainee(bool gender, string title, string firstName, string lastName, DateTime dateOfBrith, string socialSecurityNumber, CommuncationInfo communcationInfo, Address address, bool status, string nationality, Guid employeeNumber, string department, DateTime startDate, DateTime endDate, int employment, string role, int cadreLevel, int traineeYears, int actualTraineeYear) : Employee(gender, title, firstName, lastName, dateOfBrith, socialSecurityNumber, communcationInfo, address, status, nationality, employeeNumber, department, startDate, endDate, employment, role, cadreLevel)
{
    public int TraineeYears { get; set; } = traineeYears;
    public int ActualTraineeYear { get; set; } = actualTraineeYear;
}
