using Morten_Lunde_Eksamen_Emne_6.Models;

namespace Morten_Lunde_Eksamen_Emne_6.Services;

public class HarryPotterService : IHarryPotterService
{
    private readonly HttpClient _httpClient;

    public HarryPotterService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<List<Character>?> GetCharactersAsync()
    {
        List<Character>? characters = await _httpClient.GetFromJsonAsync<List<Character>>("characters");

        return characters ?? new List<Character>();
    }

    public async Task<Character?> GetCharacterDetailsAsync(Guid id)
    {
        List<Character>? characters = await _httpClient.GetFromJsonAsync<List<Character>>($"character/{id}");
        return characters?.FirstOrDefault();
    }

    public async Task<List<Spell>> GetSpellsAsync()
    {
        return (await _httpClient.GetFromJsonAsync<List<Spell>>("spells"))!;

    }
}