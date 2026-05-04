using System;
using System.Collections.Generic;
using System.Text;

namespace CommanderHandbook;

public class Officer : Soldier
{
    public string? Education { get; set; }
    public int ServiceYears { get; set; }

    public override string GetInfo() => $"Офіцер: {base.GetInfo()}, Освіта: {Education}";
}