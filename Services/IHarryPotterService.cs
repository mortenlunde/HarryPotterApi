using Morten_Lunde_Eksamen_Emne_6.Models;

namespace Morten_Lunde_Eksamen_Emne_6.Services;

public interface IHarryPotterService
{
    Task<List<Character>?> GetCharactersAsync();
    Task<Character?> GetCharacterDetailsAsync(Guid id);
    Task<List<Spell>> GetSpellsAsync();
}