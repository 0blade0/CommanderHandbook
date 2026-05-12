namespace CommanderHandbook;

public class Soldier
{
    // Загальні властивості для всіх військовослужбовців
    public string LastName { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string? Patronymic { get; set; }

    // Військові властивості
    public string? Rank { get; set; }
    public DateTime RankDate { get; set; } = DateTime.Now;
    public string? Unit { get; set; }
    public string? Position { get; set; }
    public string? ServiceForm { get; set; }
    public string? ServicePeriod { get; set; }
    public DateTime EnrollmentDate { get; set; } = DateTime.Now;


    // Додаткова інформація про бійця
    public string? CivilianProfession { get; set; }
    public string? ParentsAddress { get; set; }
    public string? CharacterTraits { get; set; }
    public string? AttitudeToService { get; set; }

    public virtual string GetInfo() => $"{Rank} {LastName} {FirstName[0]}. ({Unit})";
}