//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:28.540
//------------------------------------------------------------

using GameFramework;
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
    public class DRHero : DataRowBase
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
        /// 获取11。
        /// </summary>
        public int HeroId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取名称。
        /// </summary>
        public string Des
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取稀有度。
        /// </summary>
        public int Star
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取英雄说明。
        /// </summary>
        public string HeroDes
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取是否S级英雄。
        /// </summary>
        public int IsSuper
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取物品稀有度（展示用）。
        /// </summary>
        public int Quality
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取等级上限。
        /// </summary>
        public int LevelLimit
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取英雄类型。
        /// </summary>
        public int HeroAttributeType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取攻击距离。
        /// </summary>
        public float AttackRange
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取攻击力。
        /// </summary>
        public float Attack
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取血量。
        /// </summary>
        public float Hp
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取攻击力成长。
        /// </summary>
        public float AttackGrow
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取血量成长。
        /// </summary>
        public float HpGrow
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取暴击率万分比。
        /// </summary>
        public int Cri
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取暴击伤害万分比。
        /// </summary>
        public int CriHurt
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取防爆率万分比。
        /// </summary>
        public int DesCri
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取英雄头像。
        /// </summary>
        public string HeroHead
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取模型。
        /// </summary>
        public string Model
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取英雄头像ID。
        /// </summary>
        public int HeroHeadId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取模型缩放。
        /// </summary>
        public float ModelScale
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取普攻ID(角色战斗强化后普攻变化)。
        /// </summary>
        public List<int> SkillId1
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取技能ID1(角色战斗强化后技能变化)。
        /// </summary>
        public List<int> SkillId2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取技能ID2(角色战斗强化后技能变化)。
        /// </summary>
        public List<int> SkillId3
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取战斗强化说明1。
        /// </summary>
        public string LevelUp1
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取战斗强化说明2。
        /// </summary>
        public string LevelUp2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取战斗强化说明3。
        /// </summary>
        public string LevelUp3
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取战斗强化说明4。
        /// </summary>
        public string LevelUp4
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取战斗强化说明5。
        /// </summary>
        public string LevelUp5
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取英雄所有buff。
        /// </summary>
        public List<int> Specifics
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取累计英雄BUFF。
        /// </summary>
        public List<int> CumulativeSpecific
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取是否可升星。
        /// </summary>
        public int IsCanUpStar
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取是否所需本体卡。
        /// </summary>
        public int IsMustNeedSelf
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取升星可用道具id。
        /// </summary>
        public int UpStarNeedItem
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取升星所需品质。
        /// </summary>
        public int UpStarNeedStar
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取所需数量。
        /// </summary>
        public int UpStarNeedNum
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取进阶后ID。
        /// </summary>
        public int NextStarId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取是否可以突破重生。
        /// </summary>
        public int IsBreakRes
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取星级重生后id。
        /// </summary>
        public int RebirthedId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取突破重生获得。
        /// </summary>
        public Dictionary<int, int> ResGain
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取装填时间秒。
        /// </summary>
        public float LoadTime
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取普攻次数（进入装填时间）。
        /// </summary>
        public int ActNumbers
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取血条偏移。
        /// </summary>
        public Vector2 HpBarOffest
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取血条缩放。
        /// </summary>
        public float HpScale
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取突破多语言文本。
        /// </summary>
        public string HeroDesBreak
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
            HeroId = int.Parse(columnStrings[index++]);
            Des = columnStrings[index++];
            Star = int.Parse(columnStrings[index++]);
            HeroDes = columnStrings[index++];
            IsSuper = int.Parse(columnStrings[index++]);
            Quality = int.Parse(columnStrings[index++]);
            LevelLimit = int.Parse(columnStrings[index++]);
            HeroAttributeType = int.Parse(columnStrings[index++]);
            AttackRange = float.Parse(columnStrings[index++]);
            Attack = float.Parse(columnStrings[index++]);
            Hp = float.Parse(columnStrings[index++]);
            AttackGrow = float.Parse(columnStrings[index++]);
            HpGrow = float.Parse(columnStrings[index++]);
            Cri = int.Parse(columnStrings[index++]);
            CriHurt = int.Parse(columnStrings[index++]);
            DesCri = int.Parse(columnStrings[index++]);
            HeroHead = columnStrings[index++];
            Model = columnStrings[index++];
            HeroHeadId = int.Parse(columnStrings[index++]);
            ModelScale = float.Parse(columnStrings[index++]);
            SkillId1 = DataTableExtension.ParseListInt(columnStrings[index++]);
            SkillId2 = DataTableExtension.ParseListInt(columnStrings[index++]);
            SkillId3 = DataTableExtension.ParseListInt(columnStrings[index++]);
            LevelUp1 = columnStrings[index++];
            LevelUp2 = columnStrings[index++];
            LevelUp3 = columnStrings[index++];
            LevelUp4 = columnStrings[index++];
            LevelUp5 = columnStrings[index++];
            Specifics = DataTableExtension.ParseListInt(columnStrings[index++]);
            CumulativeSpecific = DataTableExtension.ParseListInt(columnStrings[index++]);
            IsCanUpStar = int.Parse(columnStrings[index++]);
            IsMustNeedSelf = int.Parse(columnStrings[index++]);
            UpStarNeedItem = int.Parse(columnStrings[index++]);
            UpStarNeedStar = int.Parse(columnStrings[index++]);
            UpStarNeedNum = int.Parse(columnStrings[index++]);
            NextStarId = int.Parse(columnStrings[index++]);
            IsBreakRes = int.Parse(columnStrings[index++]);
            RebirthedId = int.Parse(columnStrings[index++]);
            ResGain = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            LoadTime = float.Parse(columnStrings[index++]);
            ActNumbers = int.Parse(columnStrings[index++]);
            HpBarOffest = DataTableExtension.ParseVector2(columnStrings[index++]);
            HpScale = float.Parse(columnStrings[index++]);
            HeroDesBreak = columnStrings[index++];

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
                    HeroId = binaryReader.Read7BitEncodedInt32();
                    Des = binaryReader.ReadString();
                    Star = binaryReader.Read7BitEncodedInt32();
                    HeroDes = binaryReader.ReadString();
                    IsSuper = binaryReader.Read7BitEncodedInt32();
                    Quality = binaryReader.Read7BitEncodedInt32();
                    LevelLimit = binaryReader.Read7BitEncodedInt32();
                    HeroAttributeType = binaryReader.Read7BitEncodedInt32();
                    AttackRange = binaryReader.ReadSingle();
                    Attack = binaryReader.ReadSingle();
                    Hp = binaryReader.ReadSingle();
                    AttackGrow = binaryReader.ReadSingle();
                    HpGrow = binaryReader.ReadSingle();
                    Cri = binaryReader.Read7BitEncodedInt32();
                    CriHurt = binaryReader.Read7BitEncodedInt32();
                    DesCri = binaryReader.Read7BitEncodedInt32();
                    HeroHead = binaryReader.ReadString();
                    Model = binaryReader.ReadString();
                    HeroHeadId = binaryReader.Read7BitEncodedInt32();
                    ModelScale = binaryReader.ReadSingle();
                    SkillId1 = binaryReader.ReadListInt();
                    SkillId2 = binaryReader.ReadListInt();
                    SkillId3 = binaryReader.ReadListInt();
                    LevelUp1 = binaryReader.ReadString();
                    LevelUp2 = binaryReader.ReadString();
                    LevelUp3 = binaryReader.ReadString();
                    LevelUp4 = binaryReader.ReadString();
                    LevelUp5 = binaryReader.ReadString();
                    Specifics = binaryReader.ReadListInt();
                    CumulativeSpecific = binaryReader.ReadListInt();
                    IsCanUpStar = binaryReader.Read7BitEncodedInt32();
                    IsMustNeedSelf = binaryReader.Read7BitEncodedInt32();
                    UpStarNeedItem = binaryReader.Read7BitEncodedInt32();
                    UpStarNeedStar = binaryReader.Read7BitEncodedInt32();
                    UpStarNeedNum = binaryReader.Read7BitEncodedInt32();
                    NextStarId = binaryReader.Read7BitEncodedInt32();
                    IsBreakRes = binaryReader.Read7BitEncodedInt32();
                    RebirthedId = binaryReader.Read7BitEncodedInt32();
                    ResGain = binaryReader.ReadDictionaryIntAndInt();
                    LoadTime = binaryReader.ReadSingle();
                    ActNumbers = binaryReader.Read7BitEncodedInt32();
                    HpBarOffest = binaryReader.ReadVector2();
                    HpScale = binaryReader.ReadSingle();
                    HeroDesBreak = binaryReader.ReadString();
                }
            }

            GeneratePropertyArray();
            return true;
        }

        private KeyValuePair<int, List<int>>[] m_SkillId = null;

        public int SkillIdCount
        {
            get
            {
                return m_SkillId.Length;
            }
        }

        public List<int> GetSkillId(int id)
        {
            foreach (KeyValuePair<int, List<int>> i in m_SkillId)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetSkillId with invalid id '{0}'.", id.ToString()));
        }

        public List<int> GetSkillIdAt(int index)
        {
            if (index < 0 || index >= m_SkillId.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetSkillIdAt with invalid index '{0}'.", index.ToString()));
            }

            return m_SkillId[index].Value;
        }

        private KeyValuePair<int, string>[] m_LevelUp = null;

        public int LevelUpCount
        {
            get
            {
                return m_LevelUp.Length;
            }
        }

        public string GetLevelUp(int id)
        {
            foreach (KeyValuePair<int, string> i in m_LevelUp)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetLevelUp with invalid id '{0}'.", id.ToString()));
        }

        public string GetLevelUpAt(int index)
        {
            if (index < 0 || index >= m_LevelUp.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetLevelUpAt with invalid index '{0}'.", index.ToString()));
            }

            return m_LevelUp[index].Value;
        }

        private void GeneratePropertyArray()
        {
            m_SkillId = new KeyValuePair<int, List<int>>[]
            {
                new KeyValuePair<int, List<int>>(1, SkillId1),
                new KeyValuePair<int, List<int>>(2, SkillId2),
                new KeyValuePair<int, List<int>>(3, SkillId3),
            };

            m_LevelUp = new KeyValuePair<int, string>[]
            {
                new KeyValuePair<int, string>(1, LevelUp1),
                new KeyValuePair<int, string>(2, LevelUp2),
                new KeyValuePair<int, string>(3, LevelUp3),
                new KeyValuePair<int, string>(4, LevelUp4),
                new KeyValuePair<int, string>(5, LevelUp5),
            };
        }
    }
}
