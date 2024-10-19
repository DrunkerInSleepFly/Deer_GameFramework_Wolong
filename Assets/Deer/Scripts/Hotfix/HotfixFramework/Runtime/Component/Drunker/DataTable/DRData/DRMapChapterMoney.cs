//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:28.957
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
    public class DRMapChapterMoney : DataRowBase
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
        public int Count
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取地图。
        /// </summary>
        public string MapDes
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取描述。
        /// </summary>
        public string Des
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取主题类型。
        /// </summary>
        public int ThemeType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取关卡英雄位。
        /// </summary>
        public List<Vector3> HeroPointList
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取战斗关卡串。
        /// </summary>
        public List<int> IncludeLevel
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取地图配置文件。
        /// </summary>
        public int MapSeting
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取对应主线章节。
        /// </summary>
        public int ChapterId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取羽毛掉落间隔秒。
        /// </summary>
        public int FeatherTime
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取掉落羽毛数量数量。
        /// </summary>
        public int FeatherNumbers
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取进度时间总时长秒。
        /// </summary>
        public int BattleTimes
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
            Count = int.Parse(columnStrings[index++]);
            MapDes = columnStrings[index++];
            Des = columnStrings[index++];
            ThemeType = int.Parse(columnStrings[index++]);
            HeroPointList = DataTableExtension.ParseListVector3(columnStrings[index++]);
            IncludeLevel = DataTableExtension.ParseListInt(columnStrings[index++]);
            MapSeting = int.Parse(columnStrings[index++]);
            ChapterId = int.Parse(columnStrings[index++]);
            FeatherTime = int.Parse(columnStrings[index++]);
            FeatherNumbers = int.Parse(columnStrings[index++]);
            BattleTimes = int.Parse(columnStrings[index++]);

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
                    Count = binaryReader.Read7BitEncodedInt32();
                    MapDes = binaryReader.ReadString();
                    Des = binaryReader.ReadString();
                    ThemeType = binaryReader.Read7BitEncodedInt32();
                    HeroPointList = binaryReader.ReadListVector3();
                    IncludeLevel = binaryReader.ReadListInt();
                    MapSeting = binaryReader.Read7BitEncodedInt32();
                    ChapterId = binaryReader.Read7BitEncodedInt32();
                    FeatherTime = binaryReader.Read7BitEncodedInt32();
                    FeatherNumbers = binaryReader.Read7BitEncodedInt32();
                    BattleTimes = binaryReader.Read7BitEncodedInt32();
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
