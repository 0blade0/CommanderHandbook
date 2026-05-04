using System;
using System.Collections.Generic;
using System.Text;

namespace CommanderHandbook;

public class Conscript : Soldier
{
    public int TermOfService { get; set; }

    public override string GetInfo() => $"Строковик: {base.GetInfo()}, Термін: {TermOfService} міс.";
}