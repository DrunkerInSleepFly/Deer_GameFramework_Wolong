//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:28.850
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
    public class DRMapChapter : DataRowBase
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
        /// 获取地图图标。
        /// </summary>
        public string MapIcon
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取地图敌人。
        /// </summary>
        public string MapRole
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
        /// 获取奖励关卡(必须配置三个)(奖励道具、数量、关卡进度时间)。
        /// </summary>
        public string RewardLevel
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取下一章节。
        /// </summary>
        public int NextChapter
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取上一章节。
        /// </summary>
        public int UpChapter
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取巡逻经验奖励/小时。
        /// </summary>
        public int PatrolExp
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取巡逻金币奖励/小时。
        /// </summary>
        public int PatrolMoney
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

        /// <summary>
        /// 获取章节礼包。
        /// </summary>
        public int MapBoxId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取通关经验奖励。
        /// </summary>
        public Dictionary<int, int> MapExp
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取对应金币副本。
        /// </summary>
        public int MapChapterMoneyId
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
            MapIcon = columnStrings[index++];
            MapRole = columnStrings[index++];
            Des = columnStrings[index++];
            ThemeType = int.Parse(columnStrings[index++]);
            HeroPointList = DataTableExtension.ParseListVector3(columnStrings[index++]);
            IncludeLevel = DataTableExtension.ParseListInt(columnStrings[index++]);
            MapSeting = int.Parse(columnStrings[index++]);
            RewardLevel = columnStrings[index++];
            NextChapter = int.Parse(columnStrings[index++]);
            UpChapter = int.Parse(columnStrings[index++]);
            PatrolExp = int.Parse(columnStrings[index++]);
            PatrolMoney = int.Parse(columnStrings[index++]);
            FeatherTime = int.Parse(columnStrings[index++]);
            FeatherNumbers = int.Parse(columnStrings[index++]);
            BattleTimes = int.Parse(columnStrings[index++]);
            MapBoxId = int.Parse(columnStrings[index++]);
            MapExp = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            MapChapterMoneyId = int.Parse(columnStrings[index++]);

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
                    MapIcon = binaryReader.ReadString();
                    MapRole = binaryReader.ReadString();
                    Des = binaryReader.ReadString();
                    ThemeType = binaryReader.Read7BitEncodedInt32();
                    HeroPointList = binaryReader.ReadListVector3();
                    IncludeLevel = binaryReader.ReadListInt();
                    MapSeting = binaryReader.Read7BitEncodedInt32();
                    RewardLevel = binaryReader.ReadString();
                    NextChapter = binaryReader.Read7BitEncodedInt32();
                    UpChapter = binaryReader.Read7BitEncodedInt32();
                    PatrolExp = binaryReader.Read7BitEncodedInt32();
                    PatrolMoney = binaryReader.Read7BitEncodedInt32();
                    FeatherTime = binaryReader.Read7BitEncodedInt32();
                    FeatherNumbers = binaryReader.Read7BitEncodedInt32();
                    BattleTimes = binaryReader.Read7BitEncodedInt32();
                    MapBoxId = binaryReader.Read7BitEncodedInt32();
                    MapExp = binaryReader.ReadDictionaryIntAndInt();
                    MapChapterMoneyId = binaryReader.Read7BitEncodedInt32();
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
