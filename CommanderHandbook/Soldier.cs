namespace CommanderHandbook;

public class Soldier
{
    public string LastName { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string? Patronymic { get; set; }
    public string? Rank { get; set; }
    public string? Unit { get; set; }
    public DateTime EnrollmentDate { get; set; } = DateTime.Now;

    public virtual string GetInfo() => $"{Rank} {LastName} {FirstName[0]}. ({Unit})";
}