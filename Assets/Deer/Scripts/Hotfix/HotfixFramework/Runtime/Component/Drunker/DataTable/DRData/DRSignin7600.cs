//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:29.574
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
    public class DRSignin7600 : DataRowBase
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
        /// 获取ui上的位置。
        /// </summary>
        public int Pos
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取第几套。
        /// </summary>
        public int Which
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
        /// 获取需要几天。
        /// </summary>
        public int StartDay
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取需要几天。
        /// </summary>
        public int NeedDay
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取奖励。
        /// </summary>
        public Dictionary<int, int> Rewards
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
            Pos = int.Parse(columnStrings[index++]);
            Which = int.Parse(columnStrings[index++]);
            ItelName = columnStrings[index++];
            Des = columnStrings[index++];
            StartDay = int.Parse(columnStrings[index++]);
            NeedDay = int.Parse(columnStrings[index++]);
            Rewards = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);

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
                    Pos = binaryReader.Read7BitEncodedInt32();
                    Which = binaryReader.Read7BitEncodedInt32();
                    ItelName = binaryReader.ReadString();
                    Des = binaryReader.ReadString();
                    StartDay = binaryReader.Read7BitEncodedInt32();
                    NeedDay = binaryReader.Read7BitEncodedInt32();
                    Rewards = binaryReader.ReadDictionaryIntAndInt();
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
