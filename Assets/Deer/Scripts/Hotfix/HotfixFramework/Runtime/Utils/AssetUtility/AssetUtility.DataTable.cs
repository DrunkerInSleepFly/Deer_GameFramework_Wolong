using GameFramework;

/// <summary>
/// ��Դ·�����
/// </summary>
public static partial class AssetUtility
{
    /// <summary>
    /// UI���
    /// </summary>
    public static class DataTable
    {
        public static string GetDataTableAsset(string assetName, bool fromBytes)
        {
            return Utility.Text.Format("Assets/GameModule/AssetsHotfix/DataTables/{0}.{1}", assetName, fromBytes ? "bytes" : "txt");
        }
    }
}
