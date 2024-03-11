using GameFramework.Localization;

/// <summary>
/// ��Դ·�����
/// </summary>
public static partial class AssetUtility
{
    /// <summary>
    /// UI���
    /// </summary>
    public static class Localization
    {
        public static string GetLocalizationAsset(Language language)
        {
            return $"Assets/GameModule/AssetsHotfix/Localization/{language}/Dictionaries/Default.txt";
        }
    }
}
