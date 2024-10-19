using GameFramework;

/// <summary>
/// 资源路径相关
/// </summary>
public static partial class AssetUtility
{
    /// <summary>
    /// UI相关
    /// </summary>
    public static class DataTable
    {
        public static string GetDataTableAsset(string assetName, bool fromBytes)
        {
            return Utility.Text.Format("Assets/Deer/AssetsHotfix/ICallTheShots/DataTables/{0}.{1}", assetName, fromBytes ? "bytes" : "txt");
        }
    }
}
