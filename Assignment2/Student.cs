namespace Assignment2;

public class Student
{
    public int Id { get; init; }
    public string? GivenName { get; set; }
    public string? Surname { get; set; }
    public Status Status => SetStatus();
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? GraduationDate { get; set; }

    private Status SetStatus() {
        if (DateTime.Now >= StartDate && DateTime.Now < EndDate) return Status.Active;
        if (DateTime.Now > EndDate && GraduationDate == null) return Status.Dropout;
        if (DateTime.Now >= GraduationDate) return Status.Graduated;
        return Status.New;
    }

    public override string ToString() {
        return $@"
        Student {{
            Id: {Id}
            GivenName: {GivenName}
            Surname: {Surname}
            Status: {Status}
            StartDate: {StartDate}
            EndDate: {EndDate}
            GraduationDate: {GraduationDate}
        }}";
    }
}
