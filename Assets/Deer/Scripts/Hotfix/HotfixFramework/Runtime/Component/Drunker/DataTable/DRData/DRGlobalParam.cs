//------------------------------------------------------------
// Game DataTable
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2024-10-18 15:03:28.429
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
    public class DRGlobalParam : DataRowBase
    {
        private int m_Id = 0;

        /// <summary>
        /// 获取唯一标识关卡id。
        /// </summary>
        public override int Id
        {
            get
            {
                return m_Id;
            }
        }

        /// <summary>
        /// 获取配置初始道具或资源，根据ItemRes表。
        /// </summary>
        public string InitRes
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取初始英雄。
        /// </summary>
        public string InitHero
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取主线初始章节。
        /// </summary>
        public int InitChapterOfDestory
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取困难初始章节。
        /// </summary>
        public int InitChapterHard
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取金钱初始章节。
        /// </summary>
        public int InitChapterMoney
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取合成消除玩法初始关卡。
        /// </summary>
        public int InitLevelDestory
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取城墙效果池。
        /// </summary>
        public string CityEffectPool
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取钥匙效果池。
        /// </summary>
        public string KeyEffectPool
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取城墙1级血量。
        /// </summary>
        public int BaseHp
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取体力上限。
        /// </summary>
        public int MaxTili
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取复活钻石。
        /// </summary>
        public int EasterPrice
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取复活倒计时（秒）。
        /// </summary>
        public int EasterTime
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取英雄在城墙占位。
        /// </summary>
        public Dictionary<int, int> HeroIsInTheWall
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取每次进入关卡消耗体力。
        /// </summary>
        public int EnterALevel
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取每天消耗体力快速巡逻次数上限。
        /// </summary>
        public int PatrolNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取每天看广告快速巡逻次数上限。
        /// </summary>
        public int PatrolAdvertisingNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取快速巡逻限消耗体力。
        /// </summary>
        public int PatrolConsumePhy
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取每日金币副本消耗体力。
        /// </summary>
        public int EnterALevelMoney
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取每日金币副本挑战次数。
        /// </summary>
        public int EnterALevelNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取巡逻掉落库1，权重。
        /// </summary>
        public Dictionary<int, int> PatrolItemDrop1
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取巡逻掉落库1时间，掉落数量。
        /// </summary>
        public Dictionary<int, int> PatrolItemDropTime1
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取巡逻掉落库2，权重。
        /// </summary>
        public Dictionary<int, int> PatrolItemDrop2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取巡逻掉落库2时间，掉落数量。
        /// </summary>
        public Dictionary<int, int> PatrolItemDropTime2
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取巡逻刷新奖励时间秒。
        /// </summary>
        public int PatrolItemDropTime
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取快速巡逻时间奖励。
        /// </summary>
        public int PatrolDropTime
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取巡逻最长时间秒。
        /// </summary>
        public int PatrolMaxTime
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取背包中初始物品。
        /// </summary>
        public Dictionary<int, int> InitialItem
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取金币ID。
        /// </summary>
        public int Coin
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取钻石ID。
        /// </summary>
        public int Diamond
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取商城刷新倒计时。
        /// </summary>
        public string StroeRefresh
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取商城每日刷新池（金币购买）。
        /// </summary>
        public Dictionary<int, int> CoinPool
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取商城每日刷新池（钻石购买）。
        /// </summary>
        public Dictionary<int, int> DimondPool
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取已配置英雄的编号（id）。
        /// </summary>
        public List<int> AllHeroId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取每日看广告补精力次数上限。
        /// </summary>
        public int MaxNumOfAd
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取钻石和精力汇率。
        /// </summary>
        public int DiamondStaminaRate
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取单次看广告补充精力值。
        /// </summary>
        public int AdReplenishStamina
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取对应钻石，购买体力值。
        /// </summary>
        public Dictionary<int, int> ReEnergyDiamonds
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取每日钻石购买体力次数。
        /// </summary>
        public int ReEnergyDiamondsNum
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取恢复体力时间间隔(秒)。
        /// </summary>
        public int ReEnergyCd
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取每次恢复多少点体力。
        /// </summary>
        public int ReEnergyHow
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取每日任务随机个数。
        /// </summary>
        public int RandNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取任务积分的上限。
        /// </summary>
        public int IntegralLimit
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取周长任务积分上限。
        /// </summary>
        public int IntegralLimitDay7
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取羽毛刷新位置坐标ID。
        /// </summary>
        public List<int> FeatherPortal
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取刷新间隔，每日特殊事件上限。
        /// </summary>
        public List<int> SpecialEvent
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取道具ID,暂支持默认数量1。
        /// </summary>
        public int SpecialEventDropItem
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取最终最小攻击伤害值。
        /// </summary>
        public int MinAttackHurt
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取1阶装备ID。
        /// </summary>
        public List<int> EquipmentLevel1
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取队长BUFFID。
        /// </summary>
        public List<int> CaptainBuff
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取困难副本可复活次数。
        /// </summary>
        public int ChapterHardRevive
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取金币副本可复活次数。
        /// </summary>
        public int ChapterMoneyRevive
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取主线副本可复活次数。
        /// </summary>
        public int ChapterMineRevive
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取复活消耗道具ID、消耗数量。
        /// </summary>
        public List<int> ReviveItem
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取攻击参数,HP参数，减免参数,暴击伤害倍率参数。
        /// </summary>
        public string GamePower
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取天赋点ID。
        /// </summary>
        public int TianFuDdian
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取月卡ID、至尊月卡、月卡加码。
        /// </summary>
        public List<int> VipId
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取英雄复活击退小怪BUFFID,击退距离。
        /// </summary>
        public List<int> RepulseBuffId
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
            InitRes = columnStrings[index++];
            InitHero = columnStrings[index++];
            InitChapterOfDestory = int.Parse(columnStrings[index++]);
            InitChapterHard = int.Parse(columnStrings[index++]);
            InitChapterMoney = int.Parse(columnStrings[index++]);
            InitLevelDestory = int.Parse(columnStrings[index++]);
            CityEffectPool = columnStrings[index++];
            KeyEffectPool = columnStrings[index++];
            BaseHp = int.Parse(columnStrings[index++]);
            MaxTili = int.Parse(columnStrings[index++]);
            EasterPrice = int.Parse(columnStrings[index++]);
            EasterTime = int.Parse(columnStrings[index++]);
            HeroIsInTheWall = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            EnterALevel = int.Parse(columnStrings[index++]);
            PatrolNumber = int.Parse(columnStrings[index++]);
            PatrolAdvertisingNumber = int.Parse(columnStrings[index++]);
            PatrolConsumePhy = int.Parse(columnStrings[index++]);
            EnterALevelMoney = int.Parse(columnStrings[index++]);
            EnterALevelNumber = int.Parse(columnStrings[index++]);
            PatrolItemDrop1 = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            PatrolItemDropTime1 = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            PatrolItemDrop2 = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            PatrolItemDropTime2 = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            PatrolItemDropTime = int.Parse(columnStrings[index++]);
            PatrolDropTime = int.Parse(columnStrings[index++]);
            PatrolMaxTime = int.Parse(columnStrings[index++]);
            InitialItem = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            Coin = int.Parse(columnStrings[index++]);
            Diamond = int.Parse(columnStrings[index++]);
            StroeRefresh = columnStrings[index++];
            CoinPool = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            DimondPool = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            AllHeroId = DataTableExtension.ParseListInt(columnStrings[index++]);
            MaxNumOfAd = int.Parse(columnStrings[index++]);
            DiamondStaminaRate = int.Parse(columnStrings[index++]);
            AdReplenishStamina = int.Parse(columnStrings[index++]);
            ReEnergyDiamonds = DataTableExtension.ParseDictionaryIntAndInt(columnStrings[index++]);
            ReEnergyDiamondsNum = int.Parse(columnStrings[index++]);
            ReEnergyCd = int.Parse(columnStrings[index++]);
            ReEnergyHow = int.Parse(columnStrings[index++]);
            RandNumber = int.Parse(columnStrings[index++]);
            IntegralLimit = int.Parse(columnStrings[index++]);
            IntegralLimitDay7 = int.Parse(columnStrings[index++]);
            FeatherPortal = DataTableExtension.ParseListInt(columnStrings[index++]);
            SpecialEvent = DataTableExtension.ParseListInt(columnStrings[index++]);
            SpecialEventDropItem = int.Parse(columnStrings[index++]);
            MinAttackHurt = int.Parse(columnStrings[index++]);
            EquipmentLevel1 = DataTableExtension.ParseListInt(columnStrings[index++]);
            CaptainBuff = DataTableExtension.ParseListInt(columnStrings[index++]);
            ChapterHardRevive = int.Parse(columnStrings[index++]);
            ChapterMoneyRevive = int.Parse(columnStrings[index++]);
            ChapterMineRevive = int.Parse(columnStrings[index++]);
            ReviveItem = DataTableExtension.ParseListInt(columnStrings[index++]);
            GamePower = columnStrings[index++];
            TianFuDdian = int.Parse(columnStrings[index++]);
            VipId = DataTableExtension.ParseListInt(columnStrings[index++]);
            RepulseBuffId = DataTableExtension.ParseListInt(columnStrings[index++]);

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
                    InitRes = binaryReader.ReadString();
                    InitHero = binaryReader.ReadString();
                    InitChapterOfDestory = binaryReader.Read7BitEncodedInt32();
                    InitChapterHard = binaryReader.Read7BitEncodedInt32();
                    InitChapterMoney = binaryReader.Read7BitEncodedInt32();
                    InitLevelDestory = binaryReader.Read7BitEncodedInt32();
                    CityEffectPool = binaryReader.ReadString();
                    KeyEffectPool = binaryReader.ReadString();
                    BaseHp = binaryReader.Read7BitEncodedInt32();
                    MaxTili = binaryReader.Read7BitEncodedInt32();
                    EasterPrice = binaryReader.Read7BitEncodedInt32();
                    EasterTime = binaryReader.Read7BitEncodedInt32();
                    HeroIsInTheWall = binaryReader.ReadDictionaryIntAndInt();
                    EnterALevel = binaryReader.Read7BitEncodedInt32();
                    PatrolNumber = binaryReader.Read7BitEncodedInt32();
                    PatrolAdvertisingNumber = binaryReader.Read7BitEncodedInt32();
                    PatrolConsumePhy = binaryReader.Read7BitEncodedInt32();
                    EnterALevelMoney = binaryReader.Read7BitEncodedInt32();
                    EnterALevelNumber = binaryReader.Read7BitEncodedInt32();
                    PatrolItemDrop1 = binaryReader.ReadDictionaryIntAndInt();
                    PatrolItemDropTime1 = binaryReader.ReadDictionaryIntAndInt();
                    PatrolItemDrop2 = binaryReader.ReadDictionaryIntAndInt();
                    PatrolItemDropTime2 = binaryReader.ReadDictionaryIntAndInt();
                    PatrolItemDropTime = binaryReader.Read7BitEncodedInt32();
                    PatrolDropTime = binaryReader.Read7BitEncodedInt32();
                    PatrolMaxTime = binaryReader.Read7BitEncodedInt32();
                    InitialItem = binaryReader.ReadDictionaryIntAndInt();
                    Coin = binaryReader.Read7BitEncodedInt32();
                    Diamond = binaryReader.Read7BitEncodedInt32();
                    StroeRefresh = binaryReader.ReadString();
                    CoinPool = binaryReader.ReadDictionaryIntAndInt();
                    DimondPool = binaryReader.ReadDictionaryIntAndInt();
                    AllHeroId = binaryReader.ReadListInt();
                    MaxNumOfAd = binaryReader.Read7BitEncodedInt32();
                    DiamondStaminaRate = binaryReader.Read7BitEncodedInt32();
                    AdReplenishStamina = binaryReader.Read7BitEncodedInt32();
                    ReEnergyDiamonds = binaryReader.ReadDictionaryIntAndInt();
                    ReEnergyDiamondsNum = binaryReader.Read7BitEncodedInt32();
                    ReEnergyCd = binaryReader.Read7BitEncodedInt32();
                    ReEnergyHow = binaryReader.Read7BitEncodedInt32();
                    RandNumber = binaryReader.Read7BitEncodedInt32();
                    IntegralLimit = binaryReader.Read7BitEncodedInt32();
                    IntegralLimitDay7 = binaryReader.Read7BitEncodedInt32();
                    FeatherPortal = binaryReader.ReadListInt();
                    SpecialEvent = binaryReader.ReadListInt();
                    SpecialEventDropItem = binaryReader.Read7BitEncodedInt32();
                    MinAttackHurt = binaryReader.Read7BitEncodedInt32();
                    EquipmentLevel1 = binaryReader.ReadListInt();
                    CaptainBuff = binaryReader.ReadListInt();
                    ChapterHardRevive = binaryReader.Read7BitEncodedInt32();
                    ChapterMoneyRevive = binaryReader.Read7BitEncodedInt32();
                    ChapterMineRevive = binaryReader.Read7BitEncodedInt32();
                    ReviveItem = binaryReader.ReadListInt();
                    GamePower = binaryReader.ReadString();
                    TianFuDdian = binaryReader.Read7BitEncodedInt32();
                    VipId = binaryReader.ReadListInt();
                    RepulseBuffId = binaryReader.ReadListInt();
                }
            }

            GeneratePropertyArray();
            return true;
        }

        private KeyValuePair<int, Dictionary<int, int>>[] m_PatrolItemDrop = null;

        public int PatrolItemDropCount
        {
            get
            {
                return m_PatrolItemDrop.Length;
            }
        }

        public Dictionary<int, int> GetPatrolItemDrop(int id)
        {
            foreach (KeyValuePair<int, Dictionary<int, int>> i in m_PatrolItemDrop)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetPatrolItemDrop with invalid id '{0}'.", id.ToString()));
        }

        public Dictionary<int, int> GetPatrolItemDropAt(int index)
        {
            if (index < 0 || index >= m_PatrolItemDrop.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetPatrolItemDropAt with invalid index '{0}'.", index.ToString()));
            }

            return m_PatrolItemDrop[index].Value;
        }

        private KeyValuePair<int, Dictionary<int, int>>[] m_PatrolItemDropTime = null;

        public int PatrolItemDropTimeCount
        {
            get
            {
                return m_PatrolItemDropTime.Length;
            }
        }

        public Dictionary<int, int> GetPatrolItemDropTime(int id)
        {
            foreach (KeyValuePair<int, Dictionary<int, int>> i in m_PatrolItemDropTime)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetPatrolItemDropTime with invalid id '{0}'.", id.ToString()));
        }

        public Dictionary<int, int> GetPatrolItemDropTimeAt(int index)
        {
            if (index < 0 || index >= m_PatrolItemDropTime.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetPatrolItemDropTimeAt with invalid index '{0}'.", index.ToString()));
            }

            return m_PatrolItemDropTime[index].Value;
        }

        private KeyValuePair<int, int>[] m_IntegralLimitDay = null;

        public int IntegralLimitDayCount
        {
            get
            {
                return m_IntegralLimitDay.Length;
            }
        }

        public int GetIntegralLimitDay(int id)
        {
            foreach (KeyValuePair<int, int> i in m_IntegralLimitDay)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetIntegralLimitDay with invalid id '{0}'.", id.ToString()));
        }

        public int GetIntegralLimitDayAt(int index)
        {
            if (index < 0 || index >= m_IntegralLimitDay.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetIntegralLimitDayAt with invalid index '{0}'.", index.ToString()));
            }

            return m_IntegralLimitDay[index].Value;
        }

        private KeyValuePair<int, List<int>>[] m_EquipmentLevel = null;

        public int EquipmentLevelCount
        {
            get
            {
                return m_EquipmentLevel.Length;
            }
        }

        public List<int> GetEquipmentLevel(int id)
        {
            foreach (KeyValuePair<int, List<int>> i in m_EquipmentLevel)
            {
                if (i.Key == id)
                {
                    return i.Value;
                }
            }

            throw new GameFrameworkException(Utility.Text.Format("GetEquipmentLevel with invalid id '{0}'.", id.ToString()));
        }

        public List<int> GetEquipmentLevelAt(int index)
        {
            if (index < 0 || index >= m_EquipmentLevel.Length)
            {
                throw new GameFrameworkException(Utility.Text.Format("GetEquipmentLevelAt with invalid index '{0}'.", index.ToString()));
            }

            return m_EquipmentLevel[index].Value;
        }

        private void GeneratePropertyArray()
        {
            m_PatrolItemDrop = new KeyValuePair<int, Dictionary<int, int>>[]
            {
                new KeyValuePair<int, Dictionary<int, int>>(1, PatrolItemDrop1),
                new KeyValuePair<int, Dictionary<int, int>>(2, PatrolItemDrop2),
            };

            m_PatrolItemDropTime = new KeyValuePair<int, Dictionary<int, int>>[]
            {
                new KeyValuePair<int, Dictionary<int, int>>(1, PatrolItemDropTime1),
                new KeyValuePair<int, Dictionary<int, int>>(2, PatrolItemDropTime2),
            };

            m_IntegralLimitDay = new KeyValuePair<int, int>[]
            {
                new KeyValuePair<int, int>(7, IntegralLimitDay7),
            };

            m_EquipmentLevel = new KeyValuePair<int, List<int>>[]
            {
                new KeyValuePair<int, List<int>>(1, EquipmentLevel1),
            };
        }
    }
}
