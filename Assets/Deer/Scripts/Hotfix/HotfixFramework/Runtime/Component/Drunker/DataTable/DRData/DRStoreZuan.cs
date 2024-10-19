//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:29.907
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
    public class DRStoreZuan : DataRowBase
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
        /// 获取商品数量。
        /// </summary>
        public int CommodityNum
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取首次额外赠送数量。
        /// </summary>
        public int CommodityNum2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取赠送重置时间（天）。
        /// </summary>
        public int ResetTime
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
        /// 获取价格专属（计费点）。
        /// </summary>
        public int PriceBilling
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
            CommodityNum2 = int.Parse(columnStrings[index++]);
            ResetTime = int.Parse(columnStrings[index++]);
            CommodityIcon = columnStrings[index++];
            PriceBilling = int.Parse(columnStrings[index++]);

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
                    CommodityNum2 = binaryReader.Read7BitEncodedInt32();
                    ResetTime = binaryReader.Read7BitEncodedInt32();
                    CommodityIcon = binaryReader.ReadString();
                    PriceBilling = binaryReader.Read7BitEncodedInt32();
                }
            }

            GeneratePropertyArray();
            return true;
        }

        private KeyValuePair<int, int>[] m_CommodityNum = null;

        public int CommodityNumCount
        {
            get
            {
                return m_CommodityNum.Length;
            }
        }

        public int GetCommodityNum(int id)
        {
            foreach (KeyValuePair<int, int> i in m_CommodityNum)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetCommodityNum with invalid id '{0}'.", id.ToString()));
        }

        public int GetCommodityNumAt(int index)
        {
            if (index < 0 || index >= m_CommodityNum.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetCommodityNumAt with invalid index '{0}'.", index.ToString()));
            }

            return m_CommodityNum[index].Value;
        }

        private void GeneratePropertyArray()
        {
            m_CommodityNum = new KeyValuePair<int, int>[]
            {
                new KeyValuePair<int, int>(2, CommodityNum2),
            };
        }
    }
}
