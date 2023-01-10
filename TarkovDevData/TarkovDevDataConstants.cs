namespace TarkovDevData;

public class Constants
{
    public const string TarkovDevUrl = "https://api.tarkov.dev/";
    private const string GraphQlQuery = "graphql?query=";
    public const string GetItemsQuery = GraphQlQuery + @"
{
  items {
    id
    bsgCategoryId
    categories {
      id
      name
    }
    name
    shortName
    basePrice
    types
    width
    height
    weight
    avg24hPrice
    wikiLink
    changeLast48h
    changeLast48hPercent
    low24hPrice
    lastLowPrice
    gridImageLink
    iconLink
    image512pxLink
    updated
    sellFor {
      source
      vendor{
        name
        normalizedName
        ... on TraderOffer{
          trader{
            id
            name
            normalizedName
          }
          minTraderLevel
          taskUnlock{
            id
            tarkovDataId
            name
            normalizedName
          }
        } 
      }
      price
      currency
      priceRUB
      requirements {
        type
        value
        stringValue
      }
    }
    buyFor {
      source
      vendor {
        name
        normalizedName
        ... on TraderOffer{
          trader{
            id
            name
            normalizedName
          }
          minTraderLevel
          taskUnlock{
            id
            tarkovDataId
            name
            normalizedName
          }
        } 
      }
      price
      currency
      priceRUB
      requirements {
        type
        value
        stringValue
      }
    }
  }
}";

    public const string GetAmmoQuery = GraphQlQuery + @"{
  ammo {
    item {
    id
    bsgCategoryId
    categories {
      id
      name
    }
    name
    shortName
    basePrice
    types
    width
    height
    weight
    avg24hPrice
    wikiLink
    changeLast48h
    changeLast48hPercent
    low24hPrice
    lastLowPrice
    gridImageLink
    iconLink
    image512pxLink
    updated
    sellFor {
      source
      vendor{
        name
        normalizedName
        ... on TraderOffer{
          trader{
            id
            name
            normalizedName
          }
          minTraderLevel
          taskUnlock{
            id
            tarkovDataId
            name
            normalizedName
          }
        } 
      }
      price
      currency
      priceRUB
      requirements {
        type
        value
        stringValue
      }
    }
    buyFor {
      source
      vendor {
        name
        normalizedName
        ... on TraderOffer{
          trader{
            id
            name
            normalizedName
          }
          minTraderLevel
          taskUnlock{
            id
            tarkovDataId
            name
            normalizedName
          }
        } 
      }
      price
      currency
      priceRUB
      requirements {
        type
        value
        stringValue
      }
    }
  }
    weight
    caliber
    tracer
    tracerColor
    ammoType
    projectileCount
		damage
    armorDamage
    fragmentationChance
    ricochetChance
    penetrationChance
		penetrationPower
    accuracyModifier
    recoilModifier
    initialSpeed
    lightBleedModifier
    heavyBleedModifier
  }
}";
}