//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:28.794
//------------------------------------------------------------

using System.IO;
using System.Text;
using UnityGameFramework.Runtime;

namespace HotfixFramework.DR
{
    /// <summary>
    /// 。
    /// </summary>
    public class DRItemRes : DataRowBase
    {
        private int m_Id = 0;

        /// <summary>
        /// 获取唯一标识。
        /// </summary>
        public override int Id
        {
            get
            {
                return m_Id;
            }
        }

        /// <summary>
        /// 获取编号。
        /// </summary>
        public int Number
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取道具名称。
        /// </summary>
        public string ItelName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取策划备注。
        /// </summary>
        public string Des
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取实体的名称。
        /// </summary>
        public string EntityName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取道具类型0不在背包 大于0在背包：1背包页 2英雄突破页。
        /// </summary>
        public int Type
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取物品稀有度（展示用）。
        /// </summary>
        public int Quality
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取获得后立即开启。
        /// </summary>
        public int OpenNow
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取是否可使用(暂都填0)。
        /// </summary>
        public int CanUse
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取获得类型(1全部获取权重无用，2按权重获取，3从中选。目前只支持2)。
        /// </summary>
        public int RewardType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取使用后获得池子道具ID，数量，权重。
        /// </summary>
        public string RewardPool
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取从池子抽几种(暂只支持填1)。
        /// </summary>
        public int RewardCount
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
            Number = int.Parse(columnStrings[index++]);
            ItelName = columnStrings[index++];
            Des = columnStrings[index++];
            EntityName = columnStrings[index++];
            Type = int.Parse(columnStrings[index++]);
            Quality = int.Parse(columnStrings[index++]);
            OpenNow = int.Parse(columnStrings[index++]);
            CanUse = int.Parse(columnStrings[index++]);
            RewardType = int.Parse(columnStrings[index++]);
            RewardPool = columnStrings[index++];
            RewardCount = int.Parse(columnStrings[index++]);

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
                    Number = binaryReader.Read7BitEncodedInt32();
                    ItelName = binaryReader.ReadString();
                    Des = binaryReader.ReadString();
                    EntityName = binaryReader.ReadString();
                    Type = binaryReader.Read7BitEncodedInt32();
                    Quality = binaryReader.Read7BitEncodedInt32();
                    OpenNow = binaryReader.Read7BitEncodedInt32();
                    CanUse = binaryReader.Read7BitEncodedInt32();
                    RewardType = binaryReader.Read7BitEncodedInt32();
                    RewardPool = binaryReader.ReadString();
                    RewardCount = binaryReader.Read7BitEncodedInt32();
                }
            }

            GeneratePropertyArray();
            return true;
        }

        private void GeneratePropertyArray()
        {

        }
    }
}
