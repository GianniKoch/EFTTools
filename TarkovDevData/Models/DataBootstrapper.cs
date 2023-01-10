using System.Text.Json.Serialization;
using TarkovDevData.Models.Items;

namespace TarkovDevData.Models;

public class DataBootstrapper
{
    [JsonPropertyName("items")]
    public List<Item> Items { get; set; }
    
    
}