//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:23.331
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
    public class DRBattleLevel : DataRowBase
    {
        private int m_Id = 0;

        /// <summary>
        /// 获取关卡编号。
        /// </summary>
        public override int Id
        {
            get
            {
                return m_Id;
            }
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
        /// 获取波次。
        /// </summary>
        public List<int> Waves
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取关卡奖励。
        /// </summary>
        public Dictionary<int, int> LevelReward
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取战斗时长（秒）。
        /// </summary>
        public int BattleTime
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取BOSS配置BOSSId。
        /// </summary>
        public int BossLevel
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取boss1掉落ID(道具ID，数量，掉落概率万分比)。
        /// </summary>
        public string BossDrop1
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取对应刷新点。
        /// </summary>
        public int PortalRate
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取是否掉落罐子。
        /// </summary>
        public int IsDropJar
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
            Waves = DataTableExtension.ParseListInt(columnStrings[index++]);
            LevelReward = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            BattleTime = int.Parse(columnStrings[index++]);
            BossLevel = int.Parse(columnStrings[index++]);
            BossDrop1 = columnStrings[index++];
            PortalRate = int.Parse(columnStrings[index++]);
            IsDropJar = int.Parse(columnStrings[index++]);
            FeatherTime = int.Parse(columnStrings[index++]);
            FeatherNumbers = int.Parse(columnStrings[index++]);

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
                    Waves = binaryReader.ReadListInt();
                    LevelReward = binaryReader.ReadDictionaryIntAndInt();
                    BattleTime = binaryReader.Read7BitEncodedInt32();
                    BossLevel = binaryReader.Read7BitEncodedInt32();
                    BossDrop1 = binaryReader.ReadString();
                    PortalRate = binaryReader.Read7BitEncodedInt32();
                    IsDropJar = binaryReader.Read7BitEncodedInt32();
                    FeatherTime = binaryReader.Read7BitEncodedInt32();
                    FeatherNumbers = binaryReader.Read7BitEncodedInt32();
                }
            }

            GeneratePropertyArray();
            return true;
        }

        private KeyValuePair<int, string>[] m_BossDrop = null;

        public int BossDropCount
        {
            get
            {
                return m_BossDrop.Length;
            }
        }

        public string GetBossDrop(int id)
        {
            foreach (KeyValuePair<int, string> i in m_BossDrop)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetBossDrop with invalid id '{0}'.", id.ToString()));
        }

        public string GetBossDropAt(int index)
        {
            if (index < 0 || index >= m_BossDrop.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetBossDropAt with invalid index '{0}'.", index.ToString()));
            }

            return m_BossDrop[index].Value;
        }

        private void GeneratePropertyArray()
        {
            m_BossDrop = new KeyValuePair<int, string>[]
            {
                new KeyValuePair<int, string>(1, BossDrop1),
            };
        }
    }
}
