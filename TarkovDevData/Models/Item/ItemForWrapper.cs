using System.Text.Json.Serialization;

namespace TarkovDevData.Models.Item;

public class ItemForWrapper {
  [JsonPropertyName("source")]
  public string Source { get; set; }

  [JsonPropertyName("vendor")]
  public ItemVendor Vendor { get; set; }

  [JsonPropertyName("price")]
  public long Price { get; set; }

  [JsonPropertyName("currency")]
  public string Currency { get; set; }

  [JsonPropertyName("priceRUB")]
  public long PriceRub { get; set; }

  [JsonPropertyName("requirements")]
  public List<ItemRequirement> Requirements { get; set; }
}
