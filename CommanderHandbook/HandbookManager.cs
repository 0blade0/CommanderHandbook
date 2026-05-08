using System;
using System.Collections.Generic;
using System.Linq;

namespace CommanderHandbook;

public class HandbookManager
{
    private List<Soldier> allSoldiers = new();

    public void AddSoldier(Soldier s) => allSoldiers.Add(s);
    public void DeleteSoldier(Soldier s) => allSoldiers.Remove(s);
    public List<Soldier> SortByAlphabet() => [.. allSoldiers.OrderBy(s => s.LastName)];
    public List<Officer> GetOfficers() => [.. allSoldiers.OfType<Officer>()];
    public List<Conscript> GetConscripts() => [.. allSoldiers.OfType<Conscript>()];
    public List<Soldier> SearchByLastName(string query)
    {
        if (string.IsNullOrWhiteSpace(query))
            return SortByAlphabet(); // якщо поле порожнє,показуємо всіх

        return [.. allSoldiers.Where(s => s.LastName.StartsWith(query, StringComparison.OrdinalIgnoreCase))];
    }
}