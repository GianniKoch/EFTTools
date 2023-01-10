using System.Text.Json.Serialization;

namespace TarkovDevData.Models.Items;

public class ItemTask
{
    [JsonPropertyName("id")] 
    public string Id { get; set; }
    
    [JsonPropertyName("name")] 
    public string Name { get; set; }
}