using TarkovDevData.Models.Item;

namespace TarkovDevData.Services.Interfaces;

public interface ITarkovDevDataService
{
    Task<List<Item>?> GetAllItems(CancellationToken ct);
}