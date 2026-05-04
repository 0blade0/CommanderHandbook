using System;
using System.Collections.Generic;
using System.Text;

namespace CommanderHandbook;

// Базовий клас військовослужбовця
public class Soldier
{
    // Властивості з твого ескізу
    public required string LastName { get; set; }
    public required string FirstName { get; set; }
    public string? Patronymic { get; set; }
    public string? Rank { get; set; }
    public string? Unit { get; set; }
    public DateTime EnrollmentDate { get; set; } = DateTime.Now;

    // Метод для виводу інформації
    public virtual string GetInfo() => $"{Rank} {LastName} {FirstName[0]}. ({Unit})";
}