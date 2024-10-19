//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:29.772
//------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityGameFramework.Runtime;

namespace HotfixFramework.DR
{
    /// <summary>
    /// 。
    /// </summary>
    public class DRStoreHero : DataRowBase
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
        public int Count
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取商品在所属标签里的分类。
        /// </summary>
        public int LabelNum
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取商品位置。
        /// </summary>
        public int Shelves
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取商品名。
        /// </summary>
        public string Commodity
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取商品组。
        /// </summary>
        public int ShelveGroup
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取商品是否打折显示。
        /// </summary>
        public int ShelveDiscount
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取价格折扣(百分比，权重)。
        /// </summary>
        public Dictionary<int, int> Price
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取角色等级限制。
        /// </summary>
        public int LevelLimit
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
            Count = int.Parse(columnStrings[index++]);
            LabelNum = int.Parse(columnStrings[index++]);
            Shelves = int.Parse(columnStrings[index++]);
            Commodity = columnStrings[index++];
            ShelveGroup = int.Parse(columnStrings[index++]);
            ShelveDiscount = int.Parse(columnStrings[index++]);
            Price = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            LevelLimit = int.Parse(columnStrings[index++]);

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
                    Count = binaryReader.Read7BitEncodedInt32();
                    LabelNum = binaryReader.Read7BitEncodedInt32();
                    Shelves = binaryReader.Read7BitEncodedInt32();
                    Commodity = binaryReader.ReadString();
                    ShelveGroup = binaryReader.Read7BitEncodedInt32();
                    ShelveDiscount = binaryReader.Read7BitEncodedInt32();
                    Price = binaryReader.ReadDictionaryIntAndInt();
                    LevelLimit = binaryReader.Read7BitEncodedInt32();
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
