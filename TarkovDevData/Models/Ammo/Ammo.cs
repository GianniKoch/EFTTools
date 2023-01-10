using System.Text.Json.Serialization;
using NodaTime;

namespace TarkovDevData.Models.Ammo;

public class Ammo {
  [JsonPropertyName("item")]
  public Item Item { get; set; }

  [JsonPropertyName("weight")]
  public float Weight { get; set; }

  [JsonPropertyName("caliber")]
  public string Caliber { get; set; }

  [JsonPropertyName("tracer")]
  public bool Tracer { get; set; }

  [JsonPropertyName("tracerColor")]
  public string TracerColor { get; set; }

  [JsonPropertyName("ammoType")]
  public string AmmoType { get; set; }

  [JsonPropertyName("projectileCount")]
  public int ProjectileCount { get; set; }

  [JsonPropertyName("damage")]
  public int Damage { get; set; }

  [JsonPropertyName("armorDamage")]
  public int ArmorDamage { get; set; }

  [JsonPropertyName("fragmentationChance")]
  public float FragmentationChance { get; set; }

  [JsonPropertyName("ricochetChance")]
  public float RicochetChance { get; set; }

  [JsonPropertyName("penetrationChance")]
  public float PenetrationChance { get; set; }

  [JsonPropertyName("penetrationPower")]
  public int PenetrationPower { get; set; }

  [JsonPropertyName("accuracyModifier")]
  public float AccuracyModifier { get; set; }

  [JsonPropertyName("recoilModifier")]
  public float RecoilModifier { get; set; }

  [JsonPropertyName("initialSpeed")]
  public float InitialSpeed { get; set; }

  [JsonPropertyName("lightBleedModifier")]
  public float LightBleedModifier { get; set; }

  [JsonPropertyName("heavyBleedModifier")]
  public float HeavyBleedModifier { get; set; }
}
