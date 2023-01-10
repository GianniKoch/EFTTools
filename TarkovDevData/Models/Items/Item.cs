using System.Text.Json.Serialization;
using NodaTime;

namespace TarkovDevData.Models.Items;

public class Item
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("bsgCategoryId")]
    public string BsgCategoryId { get; set; }
    
    [JsonPropertyName("categories")]
    public List<ItemCategory> Categories { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("shortName")]
    public string ShortName { get; set; }
    
    [JsonPropertyName("basePrice")]
    public long BasePrice { get; set; }
    
    [JsonPropertyName("types")]
    public List<string> Types { get; set; }  
    
    [JsonPropertyName("width")]
    public int Width { get; set; }   
    
    [JsonPropertyName("height")]
    public int Height { get; set; }  
    
    [JsonPropertyName("avg24hPrice")]
    public long Avg24HPrice { get; set; }   
    
    [JsonPropertyName("wikiLink")]
    public string WikiLink { get; set; }  
    
    [JsonPropertyName("changeLast48h")]
    public long ChangeLast48H { get; set; }   
    
    [JsonPropertyName("changeLast48hPercent")]
    public int ChangeLast48HPercent { get; set; }   
    
    [JsonPropertyName("low24hPrice")]
    public long Low24hPrice { get; set; }
    
    [JsonPropertyName("lastLowPrice")]
    public long LastLowPrice { get; set; }
    
    [JsonPropertyName("gridImageLink")]
    public string GridImageLink { get; set; }
    
    [JsonPropertyName("iconLink")]
    public string IconLink { get; set; }
    
    [JsonPropertyName("image512pxLink")]
    public string Image512PxLink { get; set; }
    
    [JsonPropertyName("updated")]
    public Instant Updated { get; set; }

    [JsonPropertyName("sellFor")]
    public List<ItemForWrapper> SellFor { get; set; }

    [JsonPropertyName("buyFor")]
    public List<ItemForWrapper> BuyFor { get; set; }
}