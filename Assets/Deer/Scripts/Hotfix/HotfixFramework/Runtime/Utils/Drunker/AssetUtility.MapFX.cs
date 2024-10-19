// ================================================
//�� ��:
//�� ��:
//����ʱ��:2023��6��9��
//�޸�����:Drunker
//�޸�ʱ��:2023��6��9��
//�� ��:0.1 
// ===============================================
using GameFramework;

/// <summary>
/// ����·�����
/// </summary>
public static partial class AssetUtility
{
    /// <summary>
    /// �����ͼ���
    /// </summary>
    public static class MapFX
    {
        public static string GetMapJsonAsset(int mapId)
        {
            return Utility.Text.Format("Assets/Deer/AssetsHotfix/ICallTheShots/EntityPrefabs/Map/MapNode/MapInfo_{0}.json", mapId);
        }
        public static string GetBuildNodeJsonAsset(int objId) {
            
            return Utility.Text.Format("Assets/Deer/AssetsHotfix/ICallTheShots/EntityPrefabs/Map/Builds/config/Build_Node_{0}.json", objId);
        }
        public static string GetObjNode(int objNodeRnum) {
            return Utility.Text.Format("Assets/Deer/AssetsHotfix/ICallTheShots/EntityPrefabs/Map/Builds/prefab/Build_{0}.prefab", objNodeRnum);           
        }
        public static string GetObjNodePrefabName(int objNodeRnum)
        {
            return Utility.Text.Format("Map/Builds/prefab/Build_{0}", objNodeRnum);
        }
        public static string GetMapBytesAsset(int mapId)
        {
            return Utility.Text.Format("Assets/Deer/AssetsHotfix/ICallTheShots/EntityPrefabs/Map/Maps/{0}.bytes", mapId);
        }
    }
}
