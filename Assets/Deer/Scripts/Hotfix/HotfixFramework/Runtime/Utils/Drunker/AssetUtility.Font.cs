// ================================================
//�� ��:
//�� ��:
//����ʱ��:2023��6��9��
//�޸�����:Wyp
//�޸�ʱ��:2023��6��9��
//�� ��:0.1 
// ===============================================
using GameFramework;
namespace HotfixDrunker.Framework
{
    /// <summary>
    /// ����·�����
    /// </summary>
    public static class AssetUtility
    {
        /// <summary>
        /// UI���
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