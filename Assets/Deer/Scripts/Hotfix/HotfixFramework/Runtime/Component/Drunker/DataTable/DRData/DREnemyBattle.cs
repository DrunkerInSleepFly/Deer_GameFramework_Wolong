//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:27.903
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
    public class DREnemyBattle : DataRowBase
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
        /// 获取怪物唯一标识符。
        /// </summary>
        public int EnemyOnlyKey
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取怪物名称。
        /// </summary>
        public string EnemyName
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
        /// 获取怪物类型。
        /// </summary>
        public int EnemyType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取等级。
        /// </summary>
        public int Level
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取攻击类型（1，近战；2，移动攻击；3，站立攻击）。
        /// </summary>
        public int AttackType
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
        /// 获取普攻ID。
        /// </summary>
        public int Skill
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取技能ID。
        /// </summary>
        public int Skill2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取携带状态。
        /// </summary>
        public int BuffId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取怪AI路径。
        /// </summary>
        public int MovePath
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取向目标发起攻击距离。
        /// </summary>
        public int RangePath
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取普攻伤害减免。
        /// </summary>
        public int ActAnnul
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取技能伤害减免。
        /// </summary>
        public int SkillAnnul
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
        /// 获取攻击力。
        /// </summary>
        public float Attack
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取碰撞距离。
        /// </summary>
        public float CrashRange
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取移动速度。
        /// </summary>
        public float MoveSpeed
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取移动类型。
        /// </summary>
        public int MoveType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取移动线路。
        /// </summary>
        public int Route
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取死亡掉落。
        /// </summary>
        public Dictionary<int, int> FallFromDeath
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
        /// 获取头像。
        /// </summary>
        public int HeadIconId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取死亡音效。
        /// </summary>
        public int DieSound
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取移动音效。
        /// </summary>
        public int MoveSound
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
        /// 获取攻击间隔。
        /// </summary>
        public float AttackInterval
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取攻击子弹。
        /// </summary>
        public int AttackBullet
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取技能。
        /// </summary>
        public List<int> Skills
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
        /// 获取被克制英雄类型及加成参数。
        /// </summary>
        public Dictionary<int, float> ResHeroType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取推荐英雄类型。
        /// </summary>
        public int RecomHeroType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取怪的血槽数。
        /// </summary>
        public int HpGrooveNum
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
            EnemyOnlyKey = int.Parse(columnStrings[index++]);
            EnemyName = columnStrings[index++];
            Des = columnStrings[index++];
            EnemyType = int.Parse(columnStrings[index++]);
            Level = int.Parse(columnStrings[index++]);
            AttackType = int.Parse(columnStrings[index++]);
            AttackRange = float.Parse(columnStrings[index++]);
            Skill = int.Parse(columnStrings[index++]);
            Skill2 = int.Parse(columnStrings[index++]);
            BuffId = int.Parse(columnStrings[index++]);
            MovePath = int.Parse(columnStrings[index++]);
            RangePath = int.Parse(columnStrings[index++]);
            ActAnnul = int.Parse(columnStrings[index++]);
            SkillAnnul = int.Parse(columnStrings[index++]);
            Hp = float.Parse(columnStrings[index++]);
            Attack = float.Parse(columnStrings[index++]);
            CrashRange = float.Parse(columnStrings[index++]);
            MoveSpeed = float.Parse(columnStrings[index++]);
            MoveType = int.Parse(columnStrings[index++]);
            Route = int.Parse(columnStrings[index++]);
            FallFromDeath = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            Model = columnStrings[index++];
            HeadIconId = int.Parse(columnStrings[index++]);
            DieSound = int.Parse(columnStrings[index++]);
            MoveSound = int.Parse(columnStrings[index++]);
            HpBarOffest = DataTableExtension.ParseVector2(columnStrings[index++]);
            HpScale = float.Parse(columnStrings[index++]);
            AttackInterval = float.Parse(columnStrings[index++]);
            AttackBullet = int.Parse(columnStrings[index++]);
            Skills = DataTableExtension.ParseListInt(columnStrings[index++]);
            ModelScale = float.Parse(columnStrings[index++]);
            ResHeroType = DataTableExtension.ParseDictionaryIntAndFloat(columnStrings[index++]);
            RecomHeroType = int.Parse(columnStrings[index++]);
            HpGrooveNum = int.Parse(columnStrings[index++]);

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
                    EnemyOnlyKey = binaryReader.Read7BitEncodedInt32();
                    EnemyName = binaryReader.ReadString();
                    Des = binaryReader.ReadString();
                    EnemyType = binaryReader.Read7BitEncodedInt32();
                    Level = binaryReader.Read7BitEncodedInt32();
                    AttackType = binaryReader.Read7BitEncodedInt32();
                    AttackRange = binaryReader.ReadSingle();
                    Skill = binaryReader.Read7BitEncodedInt32();
                    Skill2 = binaryReader.Read7BitEncodedInt32();
                    BuffId = binaryReader.Read7BitEncodedInt32();
                    MovePath = binaryReader.Read7BitEncodedInt32();
                    RangePath = binaryReader.Read7BitEncodedInt32();
                    ActAnnul = binaryReader.Read7BitEncodedInt32();
                    SkillAnnul = binaryReader.Read7BitEncodedInt32();
                    Hp = binaryReader.ReadSingle();
                    Attack = binaryReader.ReadSingle();
                    CrashRange = binaryReader.ReadSingle();
                    MoveSpeed = binaryReader.ReadSingle();
                    MoveType = binaryReader.Read7BitEncodedInt32();
                    Route = binaryReader.Read7BitEncodedInt32();
                    FallFromDeath = binaryReader.ReadDictionaryIntAndInt();
                    Model = binaryReader.ReadString();
                    HeadIconId = binaryReader.Read7BitEncodedInt32();
                    DieSound = binaryReader.Read7BitEncodedInt32();
                    MoveSound = binaryReader.Read7BitEncodedInt32();
                    HpBarOffest = binaryReader.ReadVector2();
                    HpScale = binaryReader.ReadSingle();
                    AttackInterval = binaryReader.ReadSingle();
                    AttackBullet = binaryReader.Read7BitEncodedInt32();
                    Skills = binaryReader.ReadListInt();
                    ModelScale = binaryReader.ReadSingle();
                    ResHeroType = binaryReader.ReadDictionaryIntAndFloat();
                    RecomHeroType = binaryReader.Read7BitEncodedInt32();
                    HpGrooveNum = binaryReader.Read7BitEncodedInt32();
                }
            }

            GeneratePropertyArray();
            return true;
        }

        private KeyValuePair<int, int>[] m_Skill = null;

        public int SkillCount
        {
            get
            {
                return m_Skill.Length;
            }
        }

        public int GetSkill(int id)
        {
            foreach (KeyValuePair<int, int> i in m_Skill)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetSkill with invalid id '{0}'.", id.ToString()));
        }

        public int GetSkillAt(int index)
        {
            if (index < 0 || index >= m_Skill.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetSkillAt with invalid index '{0}'.", index.ToString()));
            }

            return m_Skill[index].Value;
        }

        private void GeneratePropertyArray()
        {
            m_Skill = new KeyValuePair<int, int>[]
            {
                new KeyValuePair<int, int>(2, Skill2),
            };
        }
    }
}
