//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:29.741
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
    public class DRStore : DataRowBase
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
        /// 获取商品类型（服务器对商品分类用）。
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
        /// 获取商品ID。
        /// </summary>
        public int CommodityId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取商品数量。
        /// </summary>
        public int CommodityNum
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取图标。
        /// </summary>
        public string CommodityIcon
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取角标。
        /// </summary>
        public string Marker
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取价格。
        /// </summary>
        public Dictionary<int, int> Price
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取价格专属（计费点）。
        /// </summary>
        public int PriceBilling
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取单日购买上限。
        /// </summary>
        public int PurchaseLimit
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取免费次数。
        /// </summary>
        public int StartFree
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
            CommodityId = int.Parse(columnStrings[index++]);
            CommodityNum = int.Parse(columnStrings[index++]);
            CommodityIcon = columnStrings[index++];
            Marker = columnStrings[index++];
            Price = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            PriceBilling = int.Parse(columnStrings[index++]);
            PurchaseLimit = int.Parse(columnStrings[index++]);
            StartFree = int.Parse(columnStrings[index++]);

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
                    CommodityId = binaryReader.Read7BitEncodedInt32();
                    CommodityNum = binaryReader.Read7BitEncodedInt32();
                    CommodityIcon = binaryReader.ReadString();
                    Marker = binaryReader.ReadString();
                    Price = binaryReader.ReadDictionaryIntAndInt();
                    PriceBilling = binaryReader.Read7BitEncodedInt32();
                    PurchaseLimit = binaryReader.Read7BitEncodedInt32();
                    StartFree = binaryReader.Read7BitEncodedInt32();
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
