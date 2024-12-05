// ReSharper disable InconsistentNaming
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable CollectionNeverUpdated.Global
namespace Morten_Lunde_Eksamen_Emne_6.Models;

public class Character
{
    public Guid id { get; set; }
    public string name { get; set; } = string.Empty;
    public List<string>? alternate_names { get; set; }
    public string species { get; set; } = string.Empty;
    public string gender { get; set; } = string.Empty;
    public string house { get; set; } = string.Empty;
    public string dateOfBirth { get; set; } = string.Empty;
    public bool wizard { get; set; }
    public string ancestry { get; set; } = string.Empty;
    public string eyeColour { get; set; } = string.Empty;
    public string hairColour { get; set; } = string.Empty;
    public Wand? Wand { get; set; }
    public string patronus { get; set; } = string.Empty;
    public bool hogwartsStudent { get; set; }
    public bool hogwartsStaff { get; set; }
    public string actor { get; set; } = string.Empty;
    public List<string>? alternate_actors { get; set; }
    public bool alive { get; set; }
    public string image { get; set; } = string.Empty;
}

public class Wand
{
    public string wood { get; set; } = string.Empty;
    public string core { get; set; } = string.Empty;
    public float? length { get; set; }
}