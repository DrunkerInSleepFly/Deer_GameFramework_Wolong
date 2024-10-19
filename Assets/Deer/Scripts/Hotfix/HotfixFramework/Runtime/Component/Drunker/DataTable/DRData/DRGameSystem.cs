//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:28.336
//------------------------------------------------------------

using System.IO;
using System.Text;
using UnityGameFramework.Runtime;

namespace HotfixFramework.DR
{
    /// <summary>
    /// 。
    /// </summary>
    public class DRGameSystem : DataRowBase
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
        /// 获取icon。
        /// </summary>
        public string Icon
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取解锁条件类型（1角色等级2主线副本）。
        /// </summary>
        public int UnlockType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取解锁参数。
        /// </summary>
        public int UnlockNumber
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
            Icon = columnStrings[index++];
            UnlockType = int.Parse(columnStrings[index++]);
            UnlockNumber = int.Parse(columnStrings[index++]);

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
                    Icon = binaryReader.ReadString();
                    UnlockType = binaryReader.Read7BitEncodedInt32();
                    UnlockNumber = binaryReader.Read7BitEncodedInt32();
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
