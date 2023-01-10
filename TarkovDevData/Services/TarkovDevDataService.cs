using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using TarkovDevData.Models;
using TarkovDevData.Models.Item;
using TarkovDevData.Services.Interfaces;

namespace TarkovDevData.Services;

public class TarkovDevDataService : ITarkovDevDataService
{
    private readonly HttpClient _httpClient;
    private ILogger<TarkovDevDataService> _logger;

    public TarkovDevDataService(HttpClient httpClient, ILogger<TarkovDevDataService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    private async Task<T?> GetAsync<T>(string url, CancellationToken ct)
    {
        using var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, ct);

        if (!response.IsSuccessStatusCode) return default;

        try
        {
            return await response.Content.ReadFromJsonAsync<T>(cancellationToken: ct).ConfigureAwait(false);
        }
        catch (NotSupportedException)
        {
            _logger.LogError("The content type is not supported!");
        }
        catch (JsonException ex)
        {
            _logger.LogError(ex, "Invalid JSON for call: {Url}", url);
        }

        return default;
    }

    public async Task<List<Item>?> GetAllItems(CancellationToken ct)
    {
        var result = await GetAsync<DataWrapper>(Constants.GetItemsQuery, ct);
        return result == null ? Enumerable.Empty<Item>().ToList() : result.data.Items;
    }
}