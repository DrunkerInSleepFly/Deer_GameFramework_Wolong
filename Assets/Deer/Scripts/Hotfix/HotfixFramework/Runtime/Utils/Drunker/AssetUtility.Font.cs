// ================================================
//描 述:
//作 者:
//创建时间:2023年6月9日
//修改作者:Wyp
//修改时间:2023年6月9日
//版 本:0.1 
// ===============================================
using GameFramework;
namespace HotfixDrunker.Framework
{
    /// <summary>
    /// 字体路径相关
    /// </summary>
    public static class AssetUtility
    {
        /// <summary>
        /// UI相关
        /// </summary>
        public static class Font
        {
            public static string GetFontAsset(string assetName)
            {
                return Utility.Text.Format("Assets/GameModule/AssetsHotfix/Font/{0}.prefab", assetName);
            }
        }
    }
}