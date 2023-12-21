
using System.Net.Http.Json;

namespace MusicCast.Shared;

public class PodcastService
{
    private readonly HttpClient _httpClient;

    public PodcastService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<Category[]?> GetCategories()
    {
        var text = _httpClient.GetAsync("categories").Result;
        var item = _httpClient.GetFromJsonAsync<Category[]>("categories");

        return item;
    }
    //1
    public Task<Show[]?> GetShows(int limit, string? term = null)
    {
        var text = _httpClient.GetStringAsync($"shows?limit={limit}&term={term}").Result;
        var item = _httpClient.GetFromJsonAsync<Show[]>($"shows?limit={limit}&term={term}");

        return item;
    }

    //2
    public Task<Show[]?> GetShows(int limit, string? term = null, string? categoryId = null)
    {
        var text = _httpClient.GetStringAsync($"shows?limit={limit}&term={term}&categoryId={categoryId}").Result;
        var item = _httpClient.GetFromJsonAsync<Show[]>($"shows?limit={limit}&term={term}&categoryId={categoryId}");

        return item;
    }

    //3
    public Task<Show?> GetShow(string id)
    {
        var text = _httpClient.GetStringAsync($"shows/{id}").Result;
        var item = _httpClient.GetFromJsonAsync<Show>($"shows/{id}");

        return item;
    }

}
