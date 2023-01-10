using System.Text.Json.Serialization;

namespace TarkovDevData.Models;

public class DataWrapper
{
    
    [JsonPropertyName("data")]
    public ItemsWrapper data { get; set; }
}