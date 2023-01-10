using System.Text.Json.Serialization;

namespace TarkovDevData.Models;

public class Data {
  [JsonPropertyName("items")]
  public List<Item.Item> Items { get; set; }

  [JsonPropertyName("ammo")]
  public List<Ammo.Ammo> Ammo { get; set; }
}
