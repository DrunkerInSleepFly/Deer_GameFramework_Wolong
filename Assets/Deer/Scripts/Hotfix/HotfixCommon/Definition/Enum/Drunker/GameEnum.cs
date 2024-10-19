public enum ChapterType
    {
        None,
        /// <summary>
        /// 主线章节
        /// </summary>
        Main=24,
        /// <summary>
        /// 金币章节
        /// </summary>
        Gold=26,
        /// <summary>
        /// 高级章节
        /// </summary>
        Elite=27,
    }


    public enum BoxType
    {
        None=-1,
        /// <summary>
        /// 章节
        /// </summary>
        Chapter,
        /// <summary>
        /// 商城
        /// </summary>
        Shop,
    }

    public enum BuyEnum
    {
        None=-1,
        Free,
        AD,
        Gold,
        Diamond,
        Money,
    }


    public enum ResType
    {
        none,//没有
        energy = 1,
        diamond = 2,
        gold = 3,
        magicPoint = 26,
        ad = 27,
        step = 28,
        dailyScore = 29,
        exp=30,//暂定 玩家经验
        talentPoint=31,//暂定 天赋点数
        reviveCoin = 35,//复活币
        weekScore = 54,//
        rmb = 9999
    }

    public enum VipEffectType
    {
        None,
        Patrol= 50462760,
    }

    public enum TaskType
    {
        None,
        /// <summary>
        /// 通过章节
        /// </summary>
        PassChapter=1,
        /// <summary>
        /// 击杀目标敌人
        /// </summary>
        KillTargetEnemy,
        /// <summary>
        /// 任意英雄升级
        /// </summary>
        AnyHeroUpgrade,
        /// <summary>
        /// 上阵英雄达到指定等级、数量
        /// </summary>
        LineupHero,
        /// <summary>
        /// 招募英雄
        /// </summary>
        SummonHero,
        /// <summary>
        /// 补充体力
        /// </summary>
        FillEnergy,
        /// <summary>
        /// 登录天数
        /// </summary>
        LoginDay,
        /// <summary>
        /// 消耗金币
        /// </summary>
        ConsumeGold,
        /// <summary>
        /// 消耗钻石
        /// </summary>
        ConsumeDiamond,
        /// <summary>
        /// 播放广告
        /// </summary>
        PlayAd,
        /// <summary>
        /// 挑战金币章节
        /// </summary>
        ChangeGoldChapter,
        /// <summary>
        /// 挑战章节
        /// </summary>
        ChangeChapter,
        /// <summary>
        /// 通关精英章节
        /// </summary>
        PassEliteChapter,
        /// <summary>
        /// 击杀boss
        /// </summary>
        KillBoss,
        /// <summary>
        /// 购买道具
        /// </summary>
        BuyProp,
        /// <summary>
        /// 巡逻
        /// </summary>
        Patrol,
        /// <summary>
        /// 快速巡逻
        /// </summary>
        FastPatrol,
        /// <summary>
        /// 英雄突破
        /// </summary>
        HeroEnhance,
        /// <summary>
        /// 充值
        /// </summary>
        Recharge,
        /// <summary>
        /// 角色等级
        /// </summary>
        RoleLevel,
        /// <summary>
        /// 获得天赋数量（大小基因都算）
        /// </summary>
        Talent,
        /// <summary>
        /// 累计获得指定英雄品质、数量
        /// </summary>
        AllHeroQuality,
        /// <summary>
        /// 累计获得英雄多少个
        /// </summary>
        AllHero,
        /// <summary>
        /// 击杀任意敌人
        /// </summary>
        KillAnyEnemy,

    }
