
    public class ServerEnum
    {

    }

    public enum AddItemAllType
    {
        ShopBuy1 = 16,
        ShopBuy2 = 17,
        ShopBuy3 = 18,
    }

    public enum RPCErrorType
    {
        // 内部错误 < 0
        ErrorHttpConnectionError = -15, //
        ErrorHttpDataParseError = -16, //
        ErrorHttpReturnError = -17, //
        ErrorNoSuchMethod = -18, //

        Success = 0,
        ErrorLoginFailed = 4, // 登陆出错
        ErrorNoMoreSource = 1001,
        ServerError = 1002,
        ErrorCheckVerisonNoTheChannel = 213,//客户端传来的渠道号在upgrade_config中找不到
        ErrorCloseServer = 214, // tcp能连上，但服务器正在重启或者维护

        ErrorInvokeError = 202, // 服务器内部错误
        ErrorBanUser = 204, // 屏蔽用户
        ErrorTokenInvalid = 210, // token 无效,账号在别处登录
                                 // ErrorMustUpgrade=203, // 強製更新
        ErrorMailDoesNotExists = 1100, // 邮件不存在
        ErrorMailNoReward = 1101, // 邮件没有奖励
        ErrorMailHasBeenReward = 1102, // 邮件奖励已被领取

        ErrorNoInDb = 3999,//数据库里没有
        ErrorNoConf = 4000,//表里不存在
        ErrorEnergyNoEnough = 4001,
        ErrorChapterSelectedOverUserMax = 4002,//选择的章节大于玩家最大章节
        ErrorDelAccountCodeError = 4003,//删除码已更新或输入错误，请重新输入
        ErrorBuyEnergyByAdButAdTimesZero = 4004,//购买次数不足
        ErrorChapterBoxRewardNoThisChapterId = 4005,//没有此章节id
        ErrorChapterBoxRewardNoThisLevelId = 4006,//没有此关卡
        ErrorChapterBoxRewardGetStateError = 4007,//状态 0 1 2 只有1可领取
        ErrorShopBuyNoConf = 4008,//没有此商品

        ErrorTaskNull = 40010,//数据库没有此任务
        ErrorTaskMainNoConf = 4011,//没有此主线任务
        ErrorTaskDailyNoConf = 4012,//没有此任务
        ErrorTaskAchieveNoConf = 4013,//没有此任务
        ErrorTaskDailyBoxNoConf = 4014,//没有此任务
        ErrorTaskStateNotCanReward = 4015,//状态是1才能领取
        ErrorNotUnLockHead = 4016,//未解锁的头像
        ErrorUserExpNotSubtract = 4017,//主角经验不能扣除
        ErrorUserLevelNotChangeByConf = 4018,//主角等级不能配置到奖励	
        ErrorBuyEnergyByDiamondButTimesZero = 4019,
        ErrorBuyEnergyNeedWhat = 4020,//当前只能用ad 和 钻石购买 其他资源扣除是错误的
                                      //SigninError
        ErrorModifyNameOnlyOnece = 4021,//改名只能一次
        ErrorSignin7NoConf = 4050,//没有这个表
        ErrorSignin7AlreadSigned = 4051,//已经签过了

        ErrorDailyShopBuyCountZero = 4070,//每日推荐商店售罄

        ErrorGameSystemNotUnlock = 4100,//功能未解锁
        ErrorGetPatrolRewardNotHas = 4150,//获取巡逻奖励 但当前没有奖励产出
        ErrorGetPatrolRewardAdTimesNotEnouth = 4151,//广告领取快速巡逻时 广告次数上限了
        ErrorGetPatrolRewardEngreyTimesNotEnouth = 4152,//体力领取快速巡逻时 广告次数上限了
        ErrorGetSpecialEventRewardTimesNotEnouth = 4153,//巡逻中特殊事件领取但是今天次数已经为0了 为什么还能领
                                                        //TalentError
        ErrorGetTalentNotUnLock = 4101,//未解锁 等级限制
        ErrorGetTalentAheadNotUnlock = 4102,//前一个未解锁
        ErrorGetTalentAlreadyUnlock = 4103,//已解锁
        ErrorGetTalentNoThisType = 4104,//目前只有TalentType   大天赋小天赋 非这2个类型提示

        ErrorVip30NotSameTimeOn = 4200,//需要同时开启的vip没有同时开启
        ErrorVip30SameTimeRewarded = 4201,//已经领过了
        ErrorVip30NomalOff = 4202,//普通月卡已失效
        ErrorVip30NomalRewarded = 4203,//普通月卡已领取
        ErrorVip30HightOff = 4204,//高级月卡已失效
        ErrorVip30HightRewarded = 4205,//高级月卡已领取


        ErrorHeroReplaceError = 4241,//要替换的英雄不在阵上
        ErrorHeroLineup = 4242,//此英雄已上阵
        //ErrorHeroUpLevelMaxLevel = 4243,//无消耗
        ErrorHeroUpLevelNotBelongYou = 4244,//升级别人的英雄是不行
        ErrorHeroReplaceNotBelongYou = 4245,//替换别人的英雄是不行
        ErrorHeroRebirthNotBreak = 4246,//重生时这个英雄指定不能重生
        ErrorHeroRebirthLevelOrStarMustOverOne = 4247,//重生时英雄必须只是等级或者星级大于1
        ErrorHeroRebirthNotBelongYou = 4248,//有英雄不属于你
        ErrorHeroUpStarButSelected = 4249,//升星但是使用了上阵的

        ErrorDrawAdTimesNotEnouth = 4250,
        ErrorDrawTimesNotEnouth = 4251,//抽奖次数不准
        ErrorHeroLevelLimit = 4260,//升级英雄 但当前英雄等级上限了  
        ErrorHeroCanNotUpStar = 4261,//升星突破英雄 但英雄表中配置了不能突破 IsUplevel
        ErrorHeroUpStarButNeedNotEnouth = 4262,//升星但是需求不足
        ErrorHeroUpStarNeedSelf = 4263,//升星突破英雄 需要消耗自己heroid一致
        ErrorHeroUpStarCostItemNeedSame = 4264,//客户端传来了消耗道具 但消耗道具和需要道具不一致
        ErrorHeroUpStarNeedTypeSame = 4265,//需要相同职业的英雄

        ErrorGoldFightTimesNotEnouth = 4266,//金币副本进入次数不足
        ErrorHardFightNeedMainChapterNotEnouth = 4267,//挑战副本需要的主线章节不满足
        ErrorHardFightNotUnlock = 4268,//此挑战副本 未解锁 正常情况不会发生
        ErrorHardFightUpChapterNotPass = 4269,//上一个没有通过 正常情况不会发生
        ErrorHardChapterState = 4270,//挑战副本结束的时候 状态不为1
        ErrorHardChapterGetStateError = 4271,//HardChapterStateType 只有canGet可以领取

    }


    public enum javaGameLanguage
    {
        zh_CN = 1,
        zh_TW = 2,
        en_US = 3
        //zh_CN(1, Locale.CHINA, com.google.api.translate.Language.CHINESE_SIMPLIFIED, com.memetix.mst.language.Language.CHINESE_SIMPLIFIED), //
        //zh_TW(2, Locale.TAIWAN, com.google.api.translate.Language.CHINESE_TRADITIONAL, com.memetix.mst.language.Language.CHINESE_TRADITIONAL), //
        //en_US(3, Locale.US, com.google.api.translate.Language.ENGLISH, com.memetix.mst.language.Language.ENGLISH), //
        //zh_HK(4, Locale.TRADITIONAL_CHINESE, com.google.api.translate.Language.CHINESE_TRADITIONAL, com.memetix.mst.language.Language.CHINESE_TRADITIONAL), //
        //jp_JP(5, Locale.JAPAN, com.google.api.translate.Language.JAPANESE, com.memetix.mst.language.Language.JAPANESE), //
        //ko_KR(6, Locale.KOREA, com.google.api.translate.Language.KOREAN, com.memetix.mst.language.Language.KOREAN), //
        //ar(7, new Locale("ar"), com.google.api.translate.Language.ARABIC, com.memetix.mst.language.Language.ARABIC), //
        //    de(8, Locale.GERMAN, com.google.api.translate.Language.GERMAN, com.memetix.mst.language.Language.GERMAN), //
        //    nl(9, new Locale("nl"), com.google.api.translate.Language.DUTCH, com.memetix.mst.language.Language.DUTCH), //
        //    fr(10, Locale.FRENCH, com.google.api.translate.Language.FRENCH, com.memetix.mst.language.Language.FRENCH), //
        //    es(11, new Locale("es"), com.google.api.translate.Language.SPANISH, com.memetix.mst.language.Language.SPANISH), //
        //    pt(12, new Locale("pt"), com.google.api.translate.Language.PORTUGUESE, com.memetix.mst.language.Language.PORTUGUESE), //
        //    ru(13, new Locale("ru"), com.google.api.translate.Language.RUSSIAN, com.memetix.mst.language.Language.RUSSIAN), //
        //    indo(14, new Locale("indo"), com.google.api.translate.Language.INDONESIAN, com.memetix.mst.language.Language.INDONESIAN), //
        //    th(15, new Locale("tai"), com.google.api.translate.Language.THAI, com.memetix.mst.language.Language.THAI), //
        //    vn(16, new Locale("vn"), com.google.api.translate.Language.VIETNAMESE, com.memetix.mst.language.Language.VIETNAMESE), //
        //    it(17, Locale.ITALY, com.google.api.translate.Language.ITALIAN, com.memetix.mst.language.Language.ITALIAN), //
        //    tr(18, new Locale("tr"), com.google.api.translate.Language.TURKISH, com.memetix.mst.language.Language.TURKISH), //
        //    se(19, new Locale("se"), com.google.api.translate.Language.SWEDISH, com.memetix.mst.language.Language.SWEDISH), //
        //    heb(20, new Locale("heb"), com.google.api.translate.Language.HEBREW, com.memetix.mst.language.Language.HEBREW), //
        //    my(21, new Locale("my"), com.google.api.translate.Language.MALAY, com.memetix.mst.language.Language.MALAY), //
        //    po(22, new Locale("po"), com.google.api.translate.Language.POLISH, com.memetix.mst.language.Language.POLISH), //
        //    fi(23, new Locale("fi"), com.google.api.translate.Language.FINNISH, com.memetix.mst.language.Language.FINNISH), //
    }


