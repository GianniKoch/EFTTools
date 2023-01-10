using System.Text.Json.Serialization;

namespace TarkovDevData.Models;

public class DataWrapper
{
    [JsonPropertyName("data")]
    public Data Data { get; set; }
    
}