//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:28.263
//------------------------------------------------------------

using System.IO;
using System.Text;
using UnityGameFramework.Runtime;

namespace HotfixFramework.DR
{
    /// <summary>
    /// 。
    /// </summary>
    public class DRGameHead : DataRowBase
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
        /// 获取名称。
        /// </summary>
        public string HeadName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取头像icon。
        /// </summary>
        public string HeadIcon
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取触发条件0默认获得1获得英雄2击杀怪。
        /// </summary>
        public int TriggerType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取参数id(1:HeroEnhance.xml,HeroId)(2:EnemyBattle.xml,EnemyOnlyKey)。
        /// </summary>
        public int HeadParam
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
            HeadName = columnStrings[index++];
            HeadIcon = columnStrings[index++];
            TriggerType = int.Parse(columnStrings[index++]);
            HeadParam = int.Parse(columnStrings[index++]);

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
                    HeadName = binaryReader.ReadString();
                    HeadIcon = binaryReader.ReadString();
                    TriggerType = binaryReader.Read7BitEncodedInt32();
                    HeadParam = binaryReader.Read7BitEncodedInt32();
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
