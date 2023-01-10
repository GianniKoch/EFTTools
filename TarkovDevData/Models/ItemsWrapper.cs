using System.Text.Json.Serialization;

namespace TarkovDevData.Models;

public class ItemsWrapper
{
    [JsonPropertyName("items")]
    public List<Item.Item> Items { get; set; }
}