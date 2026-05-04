namespace CommanderHandbook;

public class Officer : Soldier
{
    public string? Education { get; set; }
    public int ServiceYears { get; set; }
    public override string GetInfo() => $"[Officer] {base.GetInfo()}, Education: {Education}";
}