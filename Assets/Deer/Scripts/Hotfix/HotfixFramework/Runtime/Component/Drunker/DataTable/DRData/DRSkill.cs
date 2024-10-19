//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:29.628
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
    public class DRSkill : DataRowBase
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
        /// 获取技能名称多语言。
        /// </summary>
        public string NameId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取技能描述多语言。
        /// </summary>
        public string DesId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取技能攻击类型（0远程，1近战）。
        /// </summary>
        public int SkillDisType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取攻击释放类型（是否需要攻击动作）。
        /// </summary>
        public int IsAction
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取技能类型（0普攻，1技能）。
        /// </summary>
        public int SkillType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取触发类型。
        /// </summary>
        public int TriggerType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取技能icon。
        /// </summary>
        public string Icon
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取触发类型参数。
        /// </summary>
        public float TriggerConditions
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取子弹的资源名称。
        /// </summary>
        public string EntityName
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取消失的效果(触发的效果)。
        /// </summary>
        public string DisappearEffect
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取攻击数量。
        /// </summary>
        public int AttackNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取攻击修正。
        /// </summary>
        public float AttackAdjust
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取子弹移动速度。
        /// </summary>
        public float BulletSpeed
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取攻击类型。
        /// </summary>
        public int AttackType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取攻击半径。
        /// </summary>
        public float AttackRadius
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取方向类型。
        /// </summary>
        public int DirectionType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取携带buff。
        /// </summary>
        public List<int> CarryBuffs
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取释放位置。
        /// </summary>
        public int ReleasePositionType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取发射飞行物的音效。
        /// </summary>
        public int LaunchFlyingObject
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取飞行物死亡音效。
        /// </summary>
        public int FlyingObjectDie
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取是否有填充。
        /// </summary>
        public int IsLoad
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
        /// 获取后续攻击模式。
        /// </summary>
        public int AttackLaterType
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取参数。
        /// </summary>
        public List<int> Parameter
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取后续子弹的资源名称。
        /// </summary>
        public string EntityName2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取后续攻击修正。
        /// </summary>
        public float AttackAdjust2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取子弹移动速度。
        /// </summary>
        public float BulletSpeed2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取方向类型。
        /// </summary>
        public int DirectionType2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取携带buff。
        /// </summary>
        public List<int> CarryBuffs2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取后续攻击模式2。
        /// </summary>
        public int AttackLaterType2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取子弹缩放比例。
        /// </summary>
        public float EntityNum
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
            NameId = columnStrings[index++];
            DesId = columnStrings[index++];
            SkillDisType = int.Parse(columnStrings[index++]);
            IsAction = int.Parse(columnStrings[index++]);
            SkillType = int.Parse(columnStrings[index++]);
            TriggerType = int.Parse(columnStrings[index++]);
            Icon = columnStrings[index++];
            TriggerConditions = float.Parse(columnStrings[index++]);
            EntityName = columnStrings[index++];
            DisappearEffect = columnStrings[index++];
            AttackNumber = int.Parse(columnStrings[index++]);
            AttackAdjust = float.Parse(columnStrings[index++]);
            BulletSpeed = float.Parse(columnStrings[index++]);
            AttackType = int.Parse(columnStrings[index++]);
            AttackRadius = float.Parse(columnStrings[index++]);
            DirectionType = int.Parse(columnStrings[index++]);
            CarryBuffs = DataTableExtension.ParseListInt(columnStrings[index++]);
            ReleasePositionType = int.Parse(columnStrings[index++]);
            LaunchFlyingObject = int.Parse(columnStrings[index++]);
            FlyingObjectDie = int.Parse(columnStrings[index++]);
            IsLoad = int.Parse(columnStrings[index++]);
            LoadTime = float.Parse(columnStrings[index++]);
            ActNumbers = int.Parse(columnStrings[index++]);
            AttackLaterType = int.Parse(columnStrings[index++]);
            Parameter = DataTableExtension.ParseListInt(columnStrings[index++]);
            EntityName2 = columnStrings[index++];
            AttackAdjust2 = float.Parse(columnStrings[index++]);
            BulletSpeed2 = float.Parse(columnStrings[index++]);
            DirectionType2 = int.Parse(columnStrings[index++]);
            CarryBuffs2 = DataTableExtension.ParseListInt(columnStrings[index++]);
            AttackLaterType2 = int.Parse(columnStrings[index++]);
            EntityNum = float.Parse(columnStrings[index++]);

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
                    NameId = binaryReader.ReadString();
                    DesId = binaryReader.ReadString();
                    SkillDisType = binaryReader.Read7BitEncodedInt32();
                    IsAction = binaryReader.Read7BitEncodedInt32();
                    SkillType = binaryReader.Read7BitEncodedInt32();
                    TriggerType = binaryReader.Read7BitEncodedInt32();
                    Icon = binaryReader.ReadString();
                    TriggerConditions = binaryReader.ReadSingle();
                    EntityName = binaryReader.ReadString();
                    DisappearEffect = binaryReader.ReadString();
                    AttackNumber = binaryReader.Read7BitEncodedInt32();
                    AttackAdjust = binaryReader.ReadSingle();
                    BulletSpeed = binaryReader.ReadSingle();
                    AttackType = binaryReader.Read7BitEncodedInt32();
                    AttackRadius = binaryReader.ReadSingle();
                    DirectionType = binaryReader.Read7BitEncodedInt32();
                    CarryBuffs = binaryReader.ReadListInt();
                    ReleasePositionType = binaryReader.Read7BitEncodedInt32();
                    LaunchFlyingObject = binaryReader.Read7BitEncodedInt32();
                    FlyingObjectDie = binaryReader.Read7BitEncodedInt32();
                    IsLoad = binaryReader.Read7BitEncodedInt32();
                    LoadTime = binaryReader.ReadSingle();
                    ActNumbers = binaryReader.Read7BitEncodedInt32();
                    AttackLaterType = binaryReader.Read7BitEncodedInt32();
                    Parameter = binaryReader.ReadListInt();
                    EntityName2 = binaryReader.ReadString();
                    AttackAdjust2 = binaryReader.ReadSingle();
                    BulletSpeed2 = binaryReader.ReadSingle();
                    DirectionType2 = binaryReader.Read7BitEncodedInt32();
                    CarryBuffs2 = binaryReader.ReadListInt();
                    AttackLaterType2 = binaryReader.Read7BitEncodedInt32();
                    EntityNum = binaryReader.ReadSingle();
                }
            }

            GeneratePropertyArray();
            return true;
        }

        private KeyValuePair<int, string>[] m_EntityName = null;

        public int EntityNameCount
        {
            get
            {
                return m_EntityName.Length;
            }
        }

        public string GetEntityName(int id)
        {
            foreach (KeyValuePair<int, string> i in m_EntityName)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetEntityName with invalid id '{0}'.", id.ToString()));
        }

        public string GetEntityNameAt(int index)
        {
            if (index < 0 || index >= m_EntityName.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetEntityNameAt with invalid index '{0}'.", index.ToString()));
            }

            return m_EntityName[index].Value;
        }

        private KeyValuePair<int, float>[] m_AttackAdjust = null;

        public int AttackAdjustCount
        {
            get
            {
                return m_AttackAdjust.Length;
            }
        }

        public float GetAttackAdjust(int id)
        {
            foreach (KeyValuePair<int, float> i in m_AttackAdjust)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetAttackAdjust with invalid id '{0}'.", id.ToString()));
        }

        public float GetAttackAdjustAt(int index)
        {
            if (index < 0 || index >= m_AttackAdjust.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetAttackAdjustAt with invalid index '{0}'.", index.ToString()));
            }

            return m_AttackAdjust[index].Value;
        }

        private KeyValuePair<int, float>[] m_BulletSpeed = null;

        public int BulletSpeedCount
        {
            get
            {
                return m_BulletSpeed.Length;
            }
        }

        public float GetBulletSpeed(int id)
        {
            foreach (KeyValuePair<int, float> i in m_BulletSpeed)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetBulletSpeed with invalid id '{0}'.", id.ToString()));
        }

        public float GetBulletSpeedAt(int index)
        {
            if (index < 0 || index >= m_BulletSpeed.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetBulletSpeedAt with invalid index '{0}'.", index.ToString()));
            }

            return m_BulletSpeed[index].Value;
        }

        private KeyValuePair<int, int>[] m_DirectionType = null;

        public int DirectionTypeCount
        {
            get
            {
                return m_DirectionType.Length;
            }
        }

        public int GetDirectionType(int id)
        {
            foreach (KeyValuePair<int, int> i in m_DirectionType)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetDirectionType with invalid id '{0}'.", id.ToString()));
        }

        public int GetDirectionTypeAt(int index)
        {
            if (index < 0 || index >= m_DirectionType.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetDirectionTypeAt with invalid index '{0}'.", index.ToString()));
            }

            return m_DirectionType[index].Value;
        }

        private KeyValuePair<int, List<int>>[] m_CarryBuffs = null;

        public int CarryBuffsCount
        {
            get
            {
                return m_CarryBuffs.Length;
            }
        }

        public List<int> GetCarryBuffs(int id)
        {
            foreach (KeyValuePair<int, List<int>> i in m_CarryBuffs)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetCarryBuffs with invalid id '{0}'.", id.ToString()));
        }

        public List<int> GetCarryBuffsAt(int index)
        {
            if (index < 0 || index >= m_CarryBuffs.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetCarryBuffsAt with invalid index '{0}'.", index.ToString()));
            }

            return m_CarryBuffs[index].Value;
        }

        private KeyValuePair<int, int>[] m_AttackLaterType = null;

        public int AttackLaterTypeCount
        {
            get
            {
                return m_AttackLaterType.Length;
            }
        }

        public int GetAttackLaterType(int id)
        {
            foreach (KeyValuePair<int, int> i in m_AttackLaterType)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetAttackLaterType with invalid id '{0}'.", id.ToString()));
        }

        public int GetAttackLaterTypeAt(int index)
        {
            if (index < 0 || index >= m_AttackLaterType.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetAttackLaterTypeAt with invalid index '{0}'.", index.ToString()));
            }

            return m_AttackLaterType[index].Value;
        }

        private void GeneratePropertyArray()
        {
            m_EntityName = new KeyValuePair<int, string>[]
            {
                new KeyValuePair<int, string>(2, EntityName2),
            };

            m_AttackAdjust = new KeyValuePair<int, float>[]
            {
                new KeyValuePair<int, float>(2, AttackAdjust2),
            };

            m_BulletSpeed = new KeyValuePair<int, float>[]
            {
                new KeyValuePair<int, float>(2, BulletSpeed2),
            };

            m_DirectionType = new KeyValuePair<int, int>[]
            {
                new KeyValuePair<int, int>(2, DirectionType2),
            };

            m_CarryBuffs = new KeyValuePair<int, List<int>>[]
            {
                new KeyValuePair<int, List<int>>(2, CarryBuffs2),
            };

            m_AttackLaterType = new KeyValuePair<int, int>[]
            {
                new KeyValuePair<int, int>(2, AttackLaterType2),
            };
        }
    }
}
