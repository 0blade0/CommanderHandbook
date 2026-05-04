namespace CommanderHandbook;

public class HandbookManager
{
    private List<Soldier> allSoldiers = new();

    public void AddSoldier(Soldier s) => allSoldiers.Add(s);
    public void DeleteSoldier(Soldier s) => allSoldiers.Remove(s);
    public List<Soldier> SortByAlphabet() => [.. allSoldiers.OrderBy(s => s.LastName)];
    public List<Officer> GetOfficers() => [.. allSoldiers.OfType<Officer>()];
    public List<Conscript> GetConscripts() => [.. allSoldiers.OfType<Conscript>()];
}