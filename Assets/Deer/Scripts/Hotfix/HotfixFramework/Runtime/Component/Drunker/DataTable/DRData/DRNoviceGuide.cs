//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:29.007
//------------------------------------------------------------

using System.IO;
using System.Text;
using UnityGameFramework.Runtime;

namespace HotfixFramework.DR
{
    /// <summary>
    /// 。
    /// </summary>
    public class DRNoviceGuide : DataRowBase
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
        /// 获取编号。
        /// </summary>
        public int Number
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取引导类型（0、强制引导，1、非强制引导）。
        /// </summary>
        public int GuideType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取下一步。
        /// </summary>
        public int Next
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取立即开启。
        /// </summary>
        public int ImmediatelyStart
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取前置引导步骤(finishType，1引导关闭，2空白关闭;guideType,1UI引导，2合成引导)。
        /// </summary>
        public string PreposeGuideInfo
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取引导步骤(finishType，1引导关闭，2空白关闭;guideType,1UI引导，2合成引导)。
        /// </summary>
        public string GuideInfo
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
            Number = int.Parse(columnStrings[index++]);
            GuideType = int.Parse(columnStrings[index++]);
            Next = int.Parse(columnStrings[index++]);
            ImmediatelyStart = int.Parse(columnStrings[index++]);
            PreposeGuideInfo = columnStrings[index++];
            GuideInfo = columnStrings[index++];

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
                    Number = binaryReader.Read7BitEncodedInt32();
                    GuideType = binaryReader.Read7BitEncodedInt32();
                    Next = binaryReader.Read7BitEncodedInt32();
                    ImmediatelyStart = binaryReader.Read7BitEncodedInt32();
                    PreposeGuideInfo = binaryReader.ReadString();
                    GuideInfo = binaryReader.ReadString();
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
