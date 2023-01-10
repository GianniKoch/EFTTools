using System.Text.Json.Serialization;

namespace TarkovDevData.Models.Item;

public class ItemVendor
{
    [JsonPropertyName("name")] 
    public string Name { get; set; }

    [JsonPropertyName("trader")]
    public ItemTrader Trader { get; set; }

    [JsonPropertyName("minTraderLevel")]
    public int MinTraderLevel { get; set; }

    [JsonPropertyName("taskUnlock")]
    public ItemTask? Task { get; set; }
}