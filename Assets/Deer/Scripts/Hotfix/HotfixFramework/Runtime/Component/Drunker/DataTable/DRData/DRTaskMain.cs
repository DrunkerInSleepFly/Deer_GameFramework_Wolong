//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:29.984
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
    public class DRTaskMain : DataRowBase
    {
        private int m_Id = 0;

        /// <summary>
        /// 获取任务id。
        /// </summary>
        public override int Id
        {
            get
            {
                return m_Id;
            }
        }

        /// <summary>
        /// 获取下一任务ID。
        /// </summary>
        public int NextId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取任务名称。
        /// </summary>
        public string TaskName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取任务描述。
        /// </summary>
        public string TaskDes
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取任务类型。
        /// </summary>
        public int TaskType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取完成条件参数。
        /// </summary>
        public int TaskParam
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取完成条件数值。
        /// </summary>
        public int Value
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取奖励。
        /// </summary>
        public Dictionary<int, int> LevelReward
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
            NextId = int.Parse(columnStrings[index++]);
            TaskName = columnStrings[index++];
            TaskDes = columnStrings[index++];
            TaskType = int.Parse(columnStrings[index++]);
            TaskParam = int.Parse(columnStrings[index++]);
            Value = int.Parse(columnStrings[index++]);
            LevelReward = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);

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
                    NextId = binaryReader.Read7BitEncodedInt32();
                    TaskName = binaryReader.ReadString();
                    TaskDes = binaryReader.ReadString();
                    TaskType = binaryReader.Read7BitEncodedInt32();
                    TaskParam = binaryReader.Read7BitEncodedInt32();
                    Value = binaryReader.Read7BitEncodedInt32();
                    LevelReward = binaryReader.ReadDictionaryIntAndInt();
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
