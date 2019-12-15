using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ApiToCloud.GetCapcium
{
    public partial class WooliesResult
    {
        [JsonProperty("Product")]
        public Product Product { get; set; }

        [JsonProperty("Nutrition")]
        public object Nutrition { get; set; }

        [JsonProperty("VideoUrl")]
        public object VideoUrl { get; set; }

        [JsonProperty("PrimaryCategory")]
        public PrimaryCategory PrimaryCategory { get; set; }

        [JsonProperty("AdditionalAttributes")]
        public Dictionary<string, string> AdditionalAttributes { get; set; }

        [JsonProperty("TgaAttributes")]
        public TgaAttributes TgaAttributes { get; set; }

        [JsonProperty("DetailsImagePaths")]
        public Uri[] DetailsImagePaths { get; set; }

        [JsonProperty("NutritionalInformation")]
        public object[] NutritionalInformation { get; set; }

        [JsonProperty("RichRelevancePlacements")]
        public RichRelevancePlacement[] RichRelevancePlacements { get; set; }

        [JsonProperty("IsTobacco")]
        public bool IsTobacco { get; set; }

        [JsonProperty("CountryOfOriginLabel")]
        public CountryOfOriginLabel CountryOfOriginLabel { get; set; }
    }

    public partial class CountryOfOriginLabel
    {
        [JsonProperty("PngImageFile")]
        public Uri PngImageFile { get; set; }

        [JsonProperty("SvgImageFile")]
        public Uri SvgImageFile { get; set; }

        [JsonProperty("AltText")]
        public string AltText { get; set; }

        [JsonProperty("CountryOfOrigin")]
        public string CountryOfOrigin { get; set; }

        [JsonProperty("IngredientPercentage")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long IngredientPercentage { get; set; }

        [JsonProperty("Disclaimer")]
        public object Disclaimer { get; set; }
    }

    public partial class PrimaryCategory
    {
        [JsonProperty("Department")]
        public string Department { get; set; }

        [JsonProperty("Aisle")]
        public string Aisle { get; set; }

        [JsonProperty("VisualShoppingAisleId")]
        public long VisualShoppingAisleId { get; set; }

        [JsonProperty("DisplayOrder")]
        public long DisplayOrder { get; set; }

        [JsonProperty("OverrideName")]
        public object OverrideName { get; set; }

        [JsonProperty("Instance")]
        public string Instance { get; set; }
    }

    public partial class Product
    {
        [JsonProperty("TileID")]
        public long TileId { get; set; }

        [JsonProperty("Stockcode")]
        public long Stockcode { get; set; }

        [JsonProperty("Barcode")]
        public string Barcode { get; set; }

        [JsonProperty("GtinFormat")]
        public long GtinFormat { get; set; }

        [JsonProperty("CupPrice")]
        public double CupPrice { get; set; }

        [JsonProperty("InstoreCupPrice")]
        public double InstoreCupPrice { get; set; }

        [JsonProperty("CupMeasure")]
        public string CupMeasure { get; set; }

        [JsonProperty("CupString")]
        public string CupString { get; set; }

        [JsonProperty("InstoreCupString")]
        public string InstoreCupString { get; set; }

        [JsonProperty("HasCupPrice")]
        public bool HasCupPrice { get; set; }

        [JsonProperty("InstoreHasCupPrice")]
        public bool InstoreHasCupPrice { get; set; }

        [JsonProperty("Price")]
        public double Price { get; set; }

        [JsonProperty("InstorePrice")]
        public double InstorePrice { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("UrlFriendlyName")]
        public string UrlFriendlyName { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("SmallImageFile")]
        public Uri SmallImageFile { get; set; }

        [JsonProperty("MediumImageFile")]
        public Uri MediumImageFile { get; set; }

        [JsonProperty("LargeImageFile")]
        public Uri LargeImageFile { get; set; }

        [JsonProperty("IsNew")]
        public bool IsNew { get; set; }

        [JsonProperty("IsOnSpecial")]
        public bool IsOnSpecial { get; set; }

        [JsonProperty("InstoreIsOnSpecial")]
        public bool InstoreIsOnSpecial { get; set; }

        [JsonProperty("IsEdrSpecial")]
        public bool IsEdrSpecial { get; set; }

        [JsonProperty("SavingsAmount")]
        public long SavingsAmount { get; set; }

        [JsonProperty("InstoreSavingsAmount")]
        public long InstoreSavingsAmount { get; set; }

        [JsonProperty("WasPrice")]
        public double WasPrice { get; set; }

        [JsonProperty("InstoreWasPrice")]
        public double InstoreWasPrice { get; set; }

        [JsonProperty("QuantityInTrolley")]
        public long QuantityInTrolley { get; set; }

        [JsonProperty("Unit")]
        public string Unit { get; set; }

        [JsonProperty("MinimumQuantity")]
        public long MinimumQuantity { get; set; }

        [JsonProperty("HasBeenBoughtBefore")]
        public bool HasBeenBoughtBefore { get; set; }

        [JsonProperty("IsInTrolley")]
        public bool IsInTrolley { get; set; }

        [JsonProperty("Source")]
        public string Source { get; set; }

        [JsonProperty("SupplyLimit")]
        public long SupplyLimit { get; set; }

        [JsonProperty("IsRanged")]
        public bool IsRanged { get; set; }

        [JsonProperty("IsInStock")]
        public bool IsInStock { get; set; }

        [JsonProperty("PackageSize")]
        public string PackageSize { get; set; }

        [JsonProperty("IsPmDelivery")]
        public bool IsPmDelivery { get; set; }

        [JsonProperty("IsForCollection")]
        public bool IsForCollection { get; set; }

        [JsonProperty("IsForDelivery")]
        public bool IsForDelivery { get; set; }

        [JsonProperty("IsForExpress")]
        public bool IsForExpress { get; set; }

        [JsonProperty("ProductRestrictionMessage")]
        public object ProductRestrictionMessage { get; set; }

        [JsonProperty("ProductWarningMessage")]
        public object ProductWarningMessage { get; set; }

        [JsonProperty("CentreTag")]
        public Tag CentreTag { get; set; }

        [JsonProperty("IsCentreTag")]
        public bool IsCentreTag { get; set; }

        [JsonProperty("ImageTag")]
        public Tag ImageTag { get; set; }

        [JsonProperty("HeaderTag")]
        public object HeaderTag { get; set; }

        [JsonProperty("HasHeaderTag")]
        public bool HasHeaderTag { get; set; }

        [JsonProperty("UnitWeightInGrams")]
        public long UnitWeightInGrams { get; set; }

        [JsonProperty("SupplyLimitMessage")]
        public string SupplyLimitMessage { get; set; }

        [JsonProperty("SmallFormatDescription")]
        public string SmallFormatDescription { get; set; }

        [JsonProperty("FullDescription")]
        public string FullDescription { get; set; }

        [JsonProperty("IsAvailable")]
        public bool IsAvailable { get; set; }

        [JsonProperty("InstoreIsAvailable")]
        public bool InstoreIsAvailable { get; set; }

        [JsonProperty("IsPurchasable")]
        public bool IsPurchasable { get; set; }

        [JsonProperty("InstoreIsPurchasable")]
        public bool InstoreIsPurchasable { get; set; }

        [JsonProperty("AgeRestricted")]
        public bool AgeRestricted { get; set; }

        [JsonProperty("DisplayQuantity")]
        public long DisplayQuantity { get; set; }

        [JsonProperty("RichDescription")]
        public string RichDescription { get; set; }

        [JsonProperty("IsDeliveryPass")]
        public bool IsDeliveryPass { get; set; }

        [JsonProperty("HideWasSavedPrice")]
        public bool HideWasSavedPrice { get; set; }

        [JsonProperty("SapCategories")]
        public SapCategories SapCategories { get; set; }

        [JsonProperty("Brand")]
        public string Brand { get; set; }

        [JsonProperty("FooterTag")]
        public Tag FooterTag { get; set; }

        [JsonProperty("IsFooterEnabled")]
        public bool IsFooterEnabled { get; set; }

        [JsonProperty("Diagnostics")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long Diagnostics { get; set; }

        [JsonProperty("IsBundle")]
        public bool IsBundle { get; set; }

        [JsonProperty("IsInFamily")]
        public bool IsInFamily { get; set; }

        [JsonProperty("ChildProducts")]
        public object[] ChildProducts { get; set; }

        [JsonProperty("UrlOverride")]
        public object UrlOverride { get; set; }

        [JsonProperty("AdditionalAttributes")]
        public Dictionary<string, string> AdditionalAttributes { get; set; }

        [JsonProperty("DetailsImagePaths")]
        public Uri[] DetailsImagePaths { get; set; }

        [JsonProperty("Variety")]
        public string Variety { get; set; }

        [JsonProperty("Rating")]
        public Dictionary<string, long> Rating { get; set; }

        [JsonProperty("IsSponsoredAd")]
        public bool IsSponsoredAd { get; set; }

        [JsonProperty("AdID")]
        public object AdId { get; set; }

        [JsonProperty("AdIndex")]
        public object AdIndex { get; set; }
    }

    public partial class Tag
    {
        [JsonProperty("TagContent")]
        public string TagContent { get; set; }

        [JsonProperty("TagLink")]
        public object TagLink { get; set; }

        [JsonProperty("FallbackText")]
        public string FallbackText { get; set; }

        [JsonProperty("TagType")]
        public string TagType { get; set; }
    }

    public partial class SapCategories
    {
        [JsonProperty("SapDepartmentName")]
        public string SapDepartmentName { get; set; }

        [JsonProperty("SapCategoryName")]
        public string SapCategoryName { get; set; }

        [JsonProperty("SapSubCategoryName")]
        public string SapSubCategoryName { get; set; }

        [JsonProperty("SapSegmentName")]
        public string SapSegmentName { get; set; }
    }

    public partial class RichRelevancePlacement
    {
        [JsonProperty("placement_name")]
        public object PlacementName { get; set; }

        [JsonProperty("message")]
        public object Message { get; set; }

        [JsonProperty("Products")]
        public object[] Products { get; set; }

        [JsonProperty("Items")]
        public object[] Items { get; set; }

        [JsonProperty("StockcodesForDiscover")]
        public object[] StockcodesForDiscover { get; set; }
    }

    public partial class TgaAttributes
    {
        [JsonProperty("Directions")]
        public object Directions { get; set; }

        [JsonProperty("ProductWarnings")]
        public object ProductWarnings { get; set; }
    }

}