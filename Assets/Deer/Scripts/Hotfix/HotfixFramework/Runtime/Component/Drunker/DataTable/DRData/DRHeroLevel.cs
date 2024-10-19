//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:28.680
//------------------------------------------------------------

using GameFramework;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityGameFramework.Runtime;

namespace HotfixFramework.DR
{
    /// <summary>
    /// 。
    /// </summary>
    public class DRHeroLevel : DataRowBase
    {
        private int m_Id = 0;

        /// <summary>
        /// 获取序列ID。
        /// </summary>
        public override int Id
        {
            get
            {
                return m_Id;
            }
        }

        /// <summary>
        /// 获取等级。
        /// </summary>
        public int Level
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取英雄类型。
        /// </summary>
        public int HeroAttributeType1
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取升级所需道具数量。
        /// </summary>
        public Dictionary<int, int> ItemId1
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取英雄类型。
        /// </summary>
        public int HeroAttributeType2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取升级所需道具数量。
        /// </summary>
        public Dictionary<int, int> ItemId2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取英雄类型。
        /// </summary>
        public int HeroAttributeType3
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取升级所需道具数量。
        /// </summary>
        public Dictionary<int, int> ItemId3
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取英雄类型。
        /// </summary>
        public int HeroAttributeType4
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取升级所需道具数量。
        /// </summary>
        public Dictionary<int, int> ItemId4
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取英雄类型。
        /// </summary>
        public int HeroAttributeType5
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取升级所需道具数量。
        /// </summary>
        public Dictionary<int, int> ItemId5
        {
            get;
            private set;
        }

        public override bool ParseDataRow(string dataRowString, object userData)
        {
            string[] columnStrings = dataRowString.Split(DataTableExtension.DataSplitSeparators);
            for (int i = 0; i < columnStrings.Length; i++)
            {
                columnStrings[i] = columnStrings[i].Trim(DataTableExtension.DataTrimSeparators);
            }

            int index = 0;
            index++;
            m_Id = int.Parse(columnStrings[index++]);
            Level = int.Parse(columnStrings[index++]);
            HeroAttributeType1 = int.Parse(columnStrings[index++]);
            ItemId1 = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            HeroAttributeType2 = int.Parse(columnStrings[index++]);
            ItemId2 = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            HeroAttributeType3 = int.Parse(columnStrings[index++]);
            ItemId3 = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            HeroAttributeType4 = int.Parse(columnStrings[index++]);
            ItemId4 = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            HeroAttributeType5 = int.Parse(columnStrings[index++]);
            ItemId5 = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);

            GeneratePropertyArray();
            return true;
        }

        public override bool ParseDataRow(byte[] dataRowBytes, int startIndex, int length, object userData)
        {
            using (MemoryStream memoryStream = new MemoryStream(dataRowBytes, startIndex, length, false))
            {
                using (BinaryReader binaryReader = new BinaryReader(memoryStream, Encoding.UTF8))
                {
                    m_Id = binaryReader.Read7BitEncodedInt32();
                    Level = binaryReader.Read7BitEncodedInt32();
                    HeroAttributeType1 = binaryReader.Read7BitEncodedInt32();
                    ItemId1 = binaryReader.ReadDictionaryIntAndInt();
                    HeroAttributeType2 = binaryReader.Read7BitEncodedInt32();
                    ItemId2 = binaryReader.ReadDictionaryIntAndInt();
                    HeroAttributeType3 = binaryReader.Read7BitEncodedInt32();
                    ItemId3 = binaryReader.ReadDictionaryIntAndInt();
                    HeroAttributeType4 = binaryReader.Read7BitEncodedInt32();
                    ItemId4 = binaryReader.ReadDictionaryIntAndInt();
                    HeroAttributeType5 = binaryReader.Read7BitEncodedInt32();
                    ItemId5 = binaryReader.ReadDictionaryIntAndInt();
                }
            }

            GeneratePropertyArray();
            return true;
        }

        private KeyValuePair<int, int>[] m_HeroAttributeType = null;

        public int HeroAttributeTypeCount
        {
            get
            {
                return m_HeroAttributeType.Length;
            }
        }

        public int GetHeroAttributeType(int id)
        {
            foreach (KeyValuePair<int, int> i in m_HeroAttributeType)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetHeroAttributeType with invalid id '{0}'.", id.ToString()));
        }

        public int GetHeroAttributeTypeAt(int index)
        {
            if (index < 0 || index >= m_HeroAttributeType.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetHeroAttributeTypeAt with invalid index '{0}'.", index.ToString()));
            }

            return m_HeroAttributeType[index].Value;
        }

        private KeyValuePair<int, Dictionary<int, int>>[] m_ItemId = null;

        public int ItemIdCount
        {
            get
            {
                return m_ItemId.Length;
            }
        }

        public Dictionary<int, int> GetItemId(int id)
        {
            foreach (KeyValuePair<int, Dictionary<int, int>> i in m_ItemId)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetItemId with invalid id '{0}'.", id.ToString()));
        }

        public Dictionary<int, int> GetItemIdAt(int index)
        {
            if (index < 0 || index >= m_ItemId.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetItemIdAt with invalid index '{0}'.", index.ToString()));
            }

            return m_ItemId[index].Value;
        }

        private void GeneratePropertyArray()
        {
            m_HeroAttributeType = new KeyValuePair<int, int>[]
            {
                new KeyValuePair<int, int>(1, HeroAttributeType1),
                new KeyValuePair<int, int>(2, HeroAttributeType2),
                new KeyValuePair<int, int>(3, HeroAttributeType3),
                new KeyValuePair<int, int>(4, HeroAttributeType4),
                new KeyValuePair<int, int>(5, HeroAttributeType5),
            };

            m_ItemId = new KeyValuePair<int, Dictionary<int, int>>[]
            {
                new KeyValuePair<int, Dictionary<int, int>>(1, ItemId1),
                new KeyValuePair<int, Dictionary<int, int>>(2, ItemId2),
                new KeyValuePair<int, Dictionary<int, int>>(3, ItemId3),
                new KeyValuePair<int, Dictionary<int, int>>(4, ItemId4),
                new KeyValuePair<int, Dictionary<int, int>>(5, ItemId5),
            };
        }
    }
}
