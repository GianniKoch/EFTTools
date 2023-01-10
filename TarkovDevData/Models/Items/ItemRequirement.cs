using System.Text.Json.Serialization;

namespace TarkovDevData.Models.Items;

public class ItemRequirement
{
    [JsonPropertyName("type")] 
    public string Type { get; set; }
    
    [JsonPropertyName("value")] 
    public string? Value { get; set; }
    
    [JsonPropertyName("stringValue")] 
    public string? StringValue { get; set; }
}