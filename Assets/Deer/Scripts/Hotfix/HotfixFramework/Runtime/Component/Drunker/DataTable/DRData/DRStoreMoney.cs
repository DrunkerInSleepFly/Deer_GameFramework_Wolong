//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:29.885
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
    public class DRStoreMoney : DataRowBase
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
        /// 获取商品数量（几个小时巡逻量）。
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
        /// 获取价格。
        /// </summary>
        public Dictionary<int, int> Price
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

        /// <summary>
        /// 获取广告次数。
        /// </summary>
        public int CommercialNum
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
            Commodity = columnStrings[index++];
            CommodityId = int.Parse(columnStrings[index++]);
            CommodityNum = int.Parse(columnStrings[index++]);
            CommodityIcon = columnStrings[index++];
            Price = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            PurchaseLimit = int.Parse(columnStrings[index++]);
            StartFree = int.Parse(columnStrings[index++]);
            CommercialNum = int.Parse(columnStrings[index++]);

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
                    Commodity = binaryReader.ReadString();
                    CommodityId = binaryReader.Read7BitEncodedInt32();
                    CommodityNum = binaryReader.Read7BitEncodedInt32();
                    CommodityIcon = binaryReader.ReadString();
                    Price = binaryReader.ReadDictionaryIntAndInt();
                    PurchaseLimit = binaryReader.Read7BitEncodedInt32();
                    StartFree = binaryReader.Read7BitEncodedInt32();
                    CommercialNum = binaryReader.Read7BitEncodedInt32();
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
