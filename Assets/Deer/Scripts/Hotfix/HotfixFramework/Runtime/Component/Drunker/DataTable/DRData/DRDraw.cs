//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:26.933
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
    public class DRDraw : DataRowBase
    {
        private int m_Id = 0;

        /// <summary>
        /// 获取唯一标识对应招募类型。
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
        /// 获取单抽消耗。
        /// </summary>
        public List<int> DrawOneCost
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取十抽消耗。
        /// </summary>
        public List<int> DrawTenCost
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取单抽固定奖励。
        /// </summary>
        public List<int> RewardOne
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取十抽固定奖励。
        /// </summary>
        public List<int> RewardTen
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取每天广告免费次数。
        /// </summary>
        public int AdDrawCountPerDay
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取广告免费抽取冷却(秒)。
        /// </summary>
        public int AdDrawCd
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取多少次没出此组则必出此组,组和次数都不能重复出现(次在前组在后)。
        /// </summary>
        public Dictionary<int, int> HowMustGiveGroup
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取第几次必得组，组和次数都不能重复出现暂不支持。
        /// </summary>
        public Dictionary<int, int> TheMustGiveGroup
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取每日抽卡上限。
        /// </summary>
        public int MaxLimit
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
            DrawOneCost = DataTableExtension.ParseListInt(columnStrings[index++]);
            DrawTenCost = DataTableExtension.ParseListInt(columnStrings[index++]);
            RewardOne = DataTableExtension.ParseListInt(columnStrings[index++]);
            RewardTen = DataTableExtension.ParseListInt(columnStrings[index++]);
            AdDrawCountPerDay = int.Parse(columnStrings[index++]);
            AdDrawCd = int.Parse(columnStrings[index++]);
            HowMustGiveGroup = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            TheMustGiveGroup = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            MaxLimit = int.Parse(columnStrings[index++]);

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
                    DrawOneCost = binaryReader.ReadListInt();
                    DrawTenCost = binaryReader.ReadListInt();
                    RewardOne = binaryReader.ReadListInt();
                    RewardTen = binaryReader.ReadListInt();
                    AdDrawCountPerDay = binaryReader.Read7BitEncodedInt32();
                    AdDrawCd = binaryReader.Read7BitEncodedInt32();
                    HowMustGiveGroup = binaryReader.ReadDictionaryIntAndInt();
                    TheMustGiveGroup = binaryReader.ReadDictionaryIntAndInt();
                    MaxLimit = binaryReader.Read7BitEncodedInt32();
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
