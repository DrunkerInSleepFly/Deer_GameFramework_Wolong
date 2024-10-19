//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:29.947
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
    public class DRTaskBox : DataRowBase
    {
        private int m_Id = 0;

        /// <summary>
        /// 获取id。
        /// </summary>
        public override int Id
        {
            get
            {
                return m_Id;
            }
        }

        /// <summary>
        /// 获取任务积分。
        /// </summary>
        public int TaskIntegral
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取宝箱奖励。
        /// </summary>
        public Dictionary<int, int> BoxReward
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取类型1每日2每周。
        /// </summary>
        public int Type
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
            TaskIntegral = int.Parse(columnStrings[index++]);
            BoxReward = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            Type = int.Parse(columnStrings[index++]);

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
                    TaskIntegral = binaryReader.Read7BitEncodedInt32();
                    BoxReward = binaryReader.ReadDictionaryIntAndInt();
                    Type = binaryReader.Read7BitEncodedInt32();
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
