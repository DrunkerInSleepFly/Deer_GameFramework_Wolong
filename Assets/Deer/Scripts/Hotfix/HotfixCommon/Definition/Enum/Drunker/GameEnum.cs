public enum ChapterType
    {
        None,
        /// <summary>
        /// �����½�
        /// </summary>
        Main=24,
        /// <summary>
        /// ����½�
        /// </summary>
        Gold=26,
        /// <summary>
        /// �߼��½�
        /// </summary>
        Elite=27,
    }


    public enum BoxType
    {
        None=-1,
        /// <summary>
        /// �½�
        /// </summary>
        Chapter,
        /// <summary>
        /// �̳�
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
        none,//û��
        energy = 1,
        diamond = 2,
        gold = 3,
        magicPoint = 26,
        ad = 27,
        step = 28,
        dailyScore = 29,
        exp=30,//�ݶ� ��Ҿ���
        talentPoint=31,//�ݶ� �츳����
        reviveCoin = 35,//�����
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
        /// ͨ���½�
        /// </summary>
        PassChapter=1,
        /// <summary>
        /// ��ɱĿ�����
        /// </summary>
        KillTargetEnemy,
        /// <summary>
        /// ����Ӣ������
        /// </summary>
        AnyHeroUpgrade,
        /// <summary>
        /// ����Ӣ�۴ﵽָ���ȼ�������
        /// </summary>
        LineupHero,
        /// <summary>
        /// ��ļӢ��
        /// </summary>
        SummonHero,
        /// <summary>
        /// ��������
        /// </summary>
        FillEnergy,
        /// <summary>
        /// ��¼����
        /// </summary>
        LoginDay,
        /// <summary>
        /// ���Ľ��
        /// </summary>
        ConsumeGold,
        /// <summary>
        /// ������ʯ
        /// </summary>
        ConsumeDiamond,
        /// <summary>
        /// ���Ź��
        /// </summary>
        PlayAd,
        /// <summary>
        /// ��ս����½�
        /// </summary>
        ChangeGoldChapter,
        /// <summary>
        /// ��ս�½�
        /// </summary>
        ChangeChapter,
        /// <summary>
        /// ͨ�ؾ�Ӣ�½�
        /// </summary>
        PassEliteChapter,
        /// <summary>
        /// ��ɱboss
        /// </summary>
        KillBoss,
        /// <summary>
        /// �������
        /// </summary>
        BuyProp,
        /// <summary>
        /// Ѳ��
        /// </summary>
        Patrol,
        /// <summary>
        /// ����Ѳ��
        /// </summary>
        FastPatrol,
        /// <summary>
        /// Ӣ��ͻ��
        /// </summary>
        HeroEnhance,
        /// <summary>
        /// ��ֵ
        /// </summary>
        Recharge,
        /// <summary>
        /// ��ɫ�ȼ�
        /// </summary>
        RoleLevel,
        /// <summary>
        /// ����츳��������С�����㣩
        /// </summary>
        Talent,
        /// <summary>
        /// �ۼƻ��ָ��Ӣ��Ʒ�ʡ�����
        /// </summary>
        AllHeroQuality,
        /// <summary>
        /// �ۼƻ��Ӣ�۶��ٸ�
        /// </summary>
        AllHero,
        /// <summary>
        /// ��ɱ�������
        /// </summary>
        KillAnyEnemy,

    }
