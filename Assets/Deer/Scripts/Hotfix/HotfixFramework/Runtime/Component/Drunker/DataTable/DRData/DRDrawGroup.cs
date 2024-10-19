//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:27.474
//------------------------------------------------------------

using System.IO;
using System.Text;
using UnityGameFramework.Runtime;

namespace HotfixFramework.DR
{
    /// <summary>
    /// 。
    /// </summary>
    public class DRDrawGroup : DataRowBase
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
        /// 获取策划备注。
        /// </summary>
        public string Des
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取招募类型：170001：白银招募170002：黄金招募 170003：钻石招募。
        /// </summary>
        public int Type
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取如果是英雄需要填英雄等级 暂不支持,但道具要配置为-1。
        /// </summary>
        public int HeroLevel
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取道具和英雄id。
        /// </summary>
        public int ItemId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取数量。
        /// </summary>
        public int Count
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取掉落组。
        /// </summary>
        public int Group
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取掉落权重。
        /// </summary>
        public int Weight
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取品质颜色。
        /// </summary>
        public int Quality
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取是否S级英雄。
        /// </summary>
        public int IsSuper
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
            Des = columnStrings[index++];
            Type = int.Parse(columnStrings[index++]);
            HeroLevel = int.Parse(columnStrings[index++]);
            ItemId = int.Parse(columnStrings[index++]);
            Count = int.Parse(columnStrings[index++]);
            Group = int.Parse(columnStrings[index++]);
            Weight = int.Parse(columnStrings[index++]);
            Quality = int.Parse(columnStrings[index++]);
            IsSuper = int.Parse(columnStrings[index++]);

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
                    Des = binaryReader.ReadString();
                    Type = binaryReader.Read7BitEncodedInt32();
                    HeroLevel = binaryReader.Read7BitEncodedInt32();
                    ItemId = binaryReader.Read7BitEncodedInt32();
                    Count = binaryReader.Read7BitEncodedInt32();
                    Group = binaryReader.Read7BitEncodedInt32();
                    Weight = binaryReader.Read7BitEncodedInt32();
                    Quality = binaryReader.Read7BitEncodedInt32();
                    IsSuper = binaryReader.Read7BitEncodedInt32();
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
