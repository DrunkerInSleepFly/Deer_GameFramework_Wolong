//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:28.103
//------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace HotfixFramework.DR
{
    /// <summary>
    /// 。
    /// </summary>
    public class DREnemyRoute : DataRowBase
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
        /// 获取编号。
        /// </summary>
        public int Num
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取路线描述。
        /// </summary>
        public string Des
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取路线类型。
        /// </summary>
        public int RouteType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取矢量类型（x,y,z）。
        /// </summary>
        public List<Vector3> PointList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取路点数量。
        /// </summary>
        public int LineNodeCount
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
            Num = int.Parse(columnStrings[index++]);
            Des = columnStrings[index++];
            RouteType = int.Parse(columnStrings[index++]);
            PointList = DataTableExtension.ParseListVector3(columnStrings[index++]);
            LineNodeCount = int.Parse(columnStrings[index++]);

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
                    Num = binaryReader.Read7BitEncodedInt32();
                    Des = binaryReader.ReadString();
                    RouteType = binaryReader.Read7BitEncodedInt32();
                    PointList = binaryReader.ReadListVector3();
                    LineNodeCount = binaryReader.Read7BitEncodedInt32();
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
