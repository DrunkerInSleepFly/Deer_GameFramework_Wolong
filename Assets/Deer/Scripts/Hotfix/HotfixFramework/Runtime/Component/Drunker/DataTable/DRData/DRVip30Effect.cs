//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:30.000
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
    public class DRVip30Effect : DataRowBase
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
        /// 获取Effect。
        /// </summary>
        public int Effect
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取gameSystem对应系统功能表无法归到某系统则填-1。
        /// </summary>
        public int GameSystem
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Value1如果是比例千分比。
        /// </summary>
        public int Value1
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取Value2。
        /// </summary>
        public int Value2
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
            Effect = int.Parse(columnStrings[index++]);
            GameSystem = int.Parse(columnStrings[index++]);
            Value1 = int.Parse(columnStrings[index++]);
            Value2 = int.Parse(columnStrings[index++]);

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
                    Effect = binaryReader.Read7BitEncodedInt32();
                    GameSystem = binaryReader.Read7BitEncodedInt32();
                    Value1 = binaryReader.Read7BitEncodedInt32();
                    Value2 = binaryReader.Read7BitEncodedInt32();
                }
            }

            GeneratePropertyArray();
            return true;
        }

        private KeyValuePair<int, int>[] m_Value = null;

        public int ValueCount
        {
            get
            {
                return m_Value.Length;
            }
        }

        public int GetValue(int id)
        {
            foreach (KeyValuePair<int, int> i in m_Value)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetValue with invalid id '{0}'.", id.ToString()));
        }

        public int GetValueAt(int index)
        {
            if (index < 0 || index >= m_Value.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetValueAt with invalid index '{0}'.", index.ToString()));
            }

            return m_Value[index].Value;
        }

        private void GeneratePropertyArray()
        {
            m_Value = new KeyValuePair<int, int>[]
            {
                new KeyValuePair<int, int>(1, Value1),
                new KeyValuePair<int, int>(2, Value2),
            };
        }
    }
}
