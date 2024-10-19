//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:26.501
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
    public class DRBuff : DataRowBase
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
        /// 获取触发条件（-1为立即触发）。
        /// </summary>
        public int BuffTriggerType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取触发条件参数。
        /// </summary>
        public List<int> TriggerTypeNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取立即生效(0攻击生效，1立即生效)。
        /// </summary>
        public int IsInstantly
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取作用目标。
        /// </summary>
        public int ActionTarget
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取目标数量。
        /// </summary>
        public int ActionTargetNum
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取概率/10000。
        /// </summary>
        public int Rate
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取buff类型1增益2减益。
        /// </summary>
        public int BuffKind
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取类型1永久2时效性。
        /// </summary>
        public int BuffAgeingType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取有效时间。
        /// </summary>
        public int Ageing
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取BUFF类型。
        /// </summary>
        public int BuffType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取buff类型对应参数看页签2。
        /// </summary>
        public string BuffTypeParameter
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取buff特效。
        /// </summary>
        public string Effect
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
            BuffTriggerType = int.Parse(columnStrings[index++]);
            TriggerTypeNumber = DataTableExtension.ParseListInt(columnStrings[index++]);
            IsInstantly = int.Parse(columnStrings[index++]);
            ActionTarget = int.Parse(columnStrings[index++]);
            ActionTargetNum = int.Parse(columnStrings[index++]);
            Rate = int.Parse(columnStrings[index++]);
            BuffKind = int.Parse(columnStrings[index++]);
            BuffAgeingType = int.Parse(columnStrings[index++]);
            Ageing = int.Parse(columnStrings[index++]);
            BuffType = int.Parse(columnStrings[index++]);
            BuffTypeParameter = columnStrings[index++];
            Effect = columnStrings[index++];

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
                    BuffTriggerType = binaryReader.Read7BitEncodedInt32();
                    TriggerTypeNumber = binaryReader.ReadListInt();
                    IsInstantly = binaryReader.Read7BitEncodedInt32();
                    ActionTarget = binaryReader.Read7BitEncodedInt32();
                    ActionTargetNum = binaryReader.Read7BitEncodedInt32();
                    Rate = binaryReader.Read7BitEncodedInt32();
                    BuffKind = binaryReader.Read7BitEncodedInt32();
                    BuffAgeingType = binaryReader.Read7BitEncodedInt32();
                    Ageing = binaryReader.Read7BitEncodedInt32();
                    BuffType = binaryReader.Read7BitEncodedInt32();
                    BuffTypeParameter = binaryReader.ReadString();
                    Effect = binaryReader.ReadString();
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
