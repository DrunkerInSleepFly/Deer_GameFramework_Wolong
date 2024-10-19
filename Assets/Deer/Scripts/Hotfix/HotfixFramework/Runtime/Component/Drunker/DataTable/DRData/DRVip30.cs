//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:29.993
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
    public class DRVip30 : DataRowBase
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
        /// 获取type。
        /// </summary>
        public int Type
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取购买给的;如果奖励显示不做滚动只能配置一个奖励。
        /// </summary>
        public Dictionary<int, int> BuyReward
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取每天领取;type0则使用此字段奖励;给如果奖励显示不做滚动只能配置一个奖励。
        /// </summary>
        public Dictionary<int, int> DayReward
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取月卡携带效果对应Effect表。
        /// </summary>
        public List<int> Effect
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取计费点。
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
            Des = columnStrings[index++];
            Type = int.Parse(columnStrings[index++]);
            BuyReward = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            DayReward = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            Effect = DataTableExtension.ParseListInt(columnStrings[index++]);
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
                    Des = binaryReader.ReadString();
                    Type = binaryReader.Read7BitEncodedInt32();
                    BuyReward = binaryReader.ReadDictionaryIntAndInt();
                    DayReward = binaryReader.ReadDictionaryIntAndInt();
                    Effect = binaryReader.ReadListInt();
                    PriceBilling = binaryReader.Read7BitEncodedInt32();
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
