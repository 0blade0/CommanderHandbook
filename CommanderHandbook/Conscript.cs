namespace CommanderHandbook;

public class Conscript : Soldier
{
    public int TermOfService { get; set; }
    public override string GetInfo() => $"[Conscript] {base.GetInfo()}, Term: {TermOfService} months";
}