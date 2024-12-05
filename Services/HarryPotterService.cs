using Morten_Lunde_Eksamen_Emne_6.Models;

namespace Morten_Lunde_Eksamen_Emne_6.Services;

public class HarryPotterService(HttpClient httpClient) : IHarryPotterService
{
    public async Task<List<Character>?> GetCharactersAsync()
    {
        List<Character>? characters = await httpClient.GetFromJsonAsync<List<Character>>("characters");

        return characters ?? new List<Character>();
    }

    public async Task<Character?> GetCharacterDetailsAsync(Guid id)
    {
        List<Character>? characters = await httpClient.GetFromJsonAsync<List<Character>>($"character/{id}");
        return characters?.FirstOrDefault();
    }

    public async Task<List<Spell>> GetSpellsAsync()
    {
        return (await httpClient.GetFromJsonAsync<List<Spell>>("spells"))!;

    }
}