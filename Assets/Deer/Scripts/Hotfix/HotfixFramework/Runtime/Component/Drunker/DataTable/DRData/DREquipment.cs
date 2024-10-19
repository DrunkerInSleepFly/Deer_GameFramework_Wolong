//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:28.188
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
    public class DREquipment : DataRowBase
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
        /// 获取标识职业类型。
        /// </summary>
        public int JopType
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
        /// 获取阶级。
        /// </summary>
        public int Level
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取前置武器ID。
        /// </summary>
        public int EquipmentFront
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取携带BUFF1。
        /// </summary>
        public List<int> CarryBuff
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取携带技能。
        /// </summary>
        public List<int> CarrySkill
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取出现权重。
        /// </summary>
        public int Pro
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取装备说明。
        /// </summary>
        public string EquipmentDes
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取可进阶装备ID。
        /// </summary>
        public List<int> EquipmentEvolve
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取装备标签显示。
        /// </summary>
        public string EquipmentLogo
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
            JopType = int.Parse(columnStrings[index++]);
            Icon = columnStrings[index++];
            Level = int.Parse(columnStrings[index++]);
            EquipmentFront = int.Parse(columnStrings[index++]);
            CarryBuff = DataTableExtension.ParseListInt(columnStrings[index++]);
            CarrySkill = DataTableExtension.ParseListInt(columnStrings[index++]);
            Pro = int.Parse(columnStrings[index++]);
            EquipmentDes = columnStrings[index++];
            EquipmentEvolve = DataTableExtension.ParseListInt(columnStrings[index++]);
            EquipmentLogo = columnStrings[index++];

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
                    JopType = binaryReader.Read7BitEncodedInt32();
                    Icon = binaryReader.ReadString();
                    Level = binaryReader.Read7BitEncodedInt32();
                    EquipmentFront = binaryReader.Read7BitEncodedInt32();
                    CarryBuff = binaryReader.ReadListInt();
                    CarrySkill = binaryReader.ReadListInt();
                    Pro = binaryReader.Read7BitEncodedInt32();
                    EquipmentDes = binaryReader.ReadString();
                    EquipmentEvolve = binaryReader.ReadListInt();
                    EquipmentLogo = binaryReader.ReadString();
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
