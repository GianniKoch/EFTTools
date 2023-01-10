using System.Text.Json.Serialization;

namespace TarkovDevData.Models.Item;

public class ItemRequirement {
  [JsonPropertyName("type")]
  public string Type { get; set; }

  [JsonPropertyName("value")]
  public double Value { get; set; }

  [JsonPropertyName("stringValue")]
  public string? StringValue { get; set; }
}