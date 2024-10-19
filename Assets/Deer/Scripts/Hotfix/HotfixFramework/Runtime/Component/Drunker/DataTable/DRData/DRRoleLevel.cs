//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:29.057
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
    public class DRRoleLevel : DataRowBase
    {
        private int m_Id = 0;

        /// <summary>
        /// 获取唯一ID。
        /// </summary>
        public override int Id
        {
            get
            {
                return m_Id;
            }
        }

        /// <summary>
        /// 获取等级。
        /// </summary>
        public int RoleLevel
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取升级所需经验。
        /// </summary>
        public int Experience
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取升级奖励。
        /// </summary>
        public Dictionary<int, int> Reward
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
            RoleLevel = int.Parse(columnStrings[index++]);
            Experience = int.Parse(columnStrings[index++]);
            Reward = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);

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
                    RoleLevel = binaryReader.Read7BitEncodedInt32();
                    Experience = binaryReader.Read7BitEncodedInt32();
                    Reward = binaryReader.ReadDictionaryIntAndInt();
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
