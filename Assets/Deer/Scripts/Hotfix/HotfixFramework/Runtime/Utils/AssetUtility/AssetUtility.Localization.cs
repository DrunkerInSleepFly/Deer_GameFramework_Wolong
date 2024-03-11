using GameFramework.Localization;

/// <summary>
/// 资源路径相关
/// </summary>
public static partial class AssetUtility
{
    /// <summary>
    /// UI相关
    /// </summary>
    public static class Localization
    {
        public static string GetLocalizationAsset(Language language)
        {
            return $"Assets/GameModule/AssetsHotfix/Localization/{language}/Dictionaries/Default.txt";
        }
    }
}
