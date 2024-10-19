//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:28.613
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
    public class DRHeroGene : DataRowBase
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
        public int UserLevel
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取增加属性ID1。
        /// </summary>
        public int Property1
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取增加属性值1。
        /// </summary>
        public int Number1
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取增加属性ID2。
        /// </summary>
        public int Property2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取增加属性值2。
        /// </summary>
        public int Number2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取增加属性ID3。
        /// </summary>
        public int Property3
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取增加属性值3。
        /// </summary>
        public int Number3
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取小基因消耗1。
        /// </summary>
        public Dictionary<int, int> Property1Consume
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取小基因消耗2。
        /// </summary>
        public Dictionary<int, int> Property2Consume
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取小基因消耗3。
        /// </summary>
        public Dictionary<int, int> Property3Consume
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取增加额外BUFF。
        /// </summary>
        public int BuffId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取解锁增加额外功能。
        /// </summary>
        public int EventId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取功能参数。
        /// </summary>
        public int EventNum
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取大基因消耗。
        /// </summary>
        public Dictionary<int, int> BuffIdConsume
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取上一个基因触发等级。
        /// </summary>
        public int FrontLevel
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取大基因ICON。
        /// </summary>
        public string GeneIcon
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取大基因描述(标题，描述)。
        /// </summary>
        public string GeneDec
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
            UserLevel = int.Parse(columnStrings[index++]);
            Property1 = int.Parse(columnStrings[index++]);
            Number1 = int.Parse(columnStrings[index++]);
            Property2 = int.Parse(columnStrings[index++]);
            Number2 = int.Parse(columnStrings[index++]);
            Property3 = int.Parse(columnStrings[index++]);
            Number3 = int.Parse(columnStrings[index++]);
            Property1Consume = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            Property2Consume = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            Property3Consume = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            BuffId = int.Parse(columnStrings[index++]);
            EventId = int.Parse(columnStrings[index++]);
            EventNum = int.Parse(columnStrings[index++]);
            BuffIdConsume = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            FrontLevel = int.Parse(columnStrings[index++]);
            GeneIcon = columnStrings[index++];
            GeneDec = columnStrings[index++];

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
                    UserLevel = binaryReader.Read7BitEncodedInt32();
                    Property1 = binaryReader.Read7BitEncodedInt32();
                    Number1 = binaryReader.Read7BitEncodedInt32();
                    Property2 = binaryReader.Read7BitEncodedInt32();
                    Number2 = binaryReader.Read7BitEncodedInt32();
                    Property3 = binaryReader.Read7BitEncodedInt32();
                    Number3 = binaryReader.Read7BitEncodedInt32();
                    Property1Consume = binaryReader.ReadDictionaryIntAndInt();
                    Property2Consume = binaryReader.ReadDictionaryIntAndInt();
                    Property3Consume = binaryReader.ReadDictionaryIntAndInt();
                    BuffId = binaryReader.Read7BitEncodedInt32();
                    EventId = binaryReader.Read7BitEncodedInt32();
                    EventNum = binaryReader.Read7BitEncodedInt32();
                    BuffIdConsume = binaryReader.ReadDictionaryIntAndInt();
                    FrontLevel = binaryReader.Read7BitEncodedInt32();
                    GeneIcon = binaryReader.ReadString();
                    GeneDec = binaryReader.ReadString();
                }
            }

            GeneratePropertyArray();
            return true;
        }

        private KeyValuePair<int, int>[] m_Property = null;

        public int PropertyCount
        {
            get
            {
                return m_Property.Length;
            }
        }

        public int GetProperty(int id)
        {
            foreach (KeyValuePair<int, int> i in m_Property)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetProperty with invalid id '{0}'.", id.ToString()));
        }

        public int GetPropertyAt(int index)
        {
            if (index < 0 || index >= m_Property.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetPropertyAt with invalid index '{0}'.", index.ToString()));
            }

            return m_Property[index].Value;
        }

        private KeyValuePair<int, int>[] m_Number = null;

        public int NumberCount
        {
            get
            {
                return m_Number.Length;
            }
        }

        public int GetNumber(int id)
        {
            foreach (KeyValuePair<int, int> i in m_Number)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetNumber with invalid id '{0}'.", id.ToString()));
        }

        public int GetNumberAt(int index)
        {
            if (index < 0 || index >= m_Number.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetNumberAt with invalid index '{0}'.", index.ToString()));
            }

            return m_Number[index].Value;
        }

        private void GeneratePropertyArray()
        {
            m_Property = new KeyValuePair<int, int>[]
            {
                new KeyValuePair<int, int>(1, Property1),
                new KeyValuePair<int, int>(2, Property2),
                new KeyValuePair<int, int>(3, Property3),
            };

            m_Number = new KeyValuePair<int, int>[]
            {
                new KeyValuePair<int, int>(1, Number1),
                new KeyValuePair<int, int>(2, Number2),
                new KeyValuePair<int, int>(3, Number3),
            };
        }
    }
}
