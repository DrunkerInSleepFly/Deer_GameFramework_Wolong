//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:28.740
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
    public class DRHeroTeam : DataRowBase
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
        /// 获取品质。
        /// </summary>
        public int HeroQuality
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取数量。
        /// </summary>
        public int Numbers
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取BUFFID。
        /// </summary>
        public Dictionary<int, int> BuffId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取组ID。
        /// </summary>
        public int Group
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取组权重。
        /// </summary>
        public int Pro
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取多语言。
        /// </summary>
        public string TeamDec
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
            HeroQuality = int.Parse(columnStrings[index++]);
            Numbers = int.Parse(columnStrings[index++]);
            BuffId = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            Group = int.Parse(columnStrings[index++]);
            Pro = int.Parse(columnStrings[index++]);
            TeamDec = columnStrings[index++];

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
                    HeroQuality = binaryReader.Read7BitEncodedInt32();
                    Numbers = binaryReader.Read7BitEncodedInt32();
                    BuffId = binaryReader.ReadDictionaryIntAndInt();
                    Group = binaryReader.Read7BitEncodedInt32();
                    Pro = binaryReader.Read7BitEncodedInt32();
                    TeamDec = binaryReader.ReadString();
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
