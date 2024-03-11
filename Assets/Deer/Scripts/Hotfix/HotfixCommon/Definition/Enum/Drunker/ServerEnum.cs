
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
        // �ڲ����� < 0
        ErrorHttpConnectionError = -15, //
        ErrorHttpDataParseError = -16, //
        ErrorHttpReturnError = -17, //
        ErrorNoSuchMethod = -18, //

        Success = 0,
        ErrorLoginFailed = 4, // ��½����
        ErrorNoMoreSource = 1001,
        ServerError = 1002,
        ErrorCheckVerisonNoTheChannel = 213,//�ͻ��˴�������������upgrade_config���Ҳ���
        ErrorCloseServer = 214, // tcp�����ϣ���������������������ά��

        ErrorInvokeError = 202, // �������ڲ�����
        ErrorBanUser = 204, // �����û�
        ErrorTokenInvalid = 210, // token ��Ч,�˺��ڱ𴦵�¼
                                 // ErrorMustUpgrade=203, // ���u����
        ErrorMailDoesNotExists = 1100, // �ʼ�������
        ErrorMailNoReward = 1101, // �ʼ�û�н���
        ErrorMailHasBeenReward = 1102, // �ʼ������ѱ���ȡ

        ErrorNoInDb = 3999,//���ݿ���û��
        ErrorNoConf = 4000,//���ﲻ����
        ErrorEnergyNoEnough = 4001,
        ErrorChapterSelectedOverUserMax = 4002,//ѡ����½ڴ����������½�
        ErrorDelAccountCodeError = 4003,//ɾ�����Ѹ��»������������������
        ErrorBuyEnergyByAdButAdTimesZero = 4004,//�����������
        ErrorChapterBoxRewardNoThisChapterId = 4005,//û�д��½�id
        ErrorChapterBoxRewardNoThisLevelId = 4006,//û�д˹ؿ�
        ErrorChapterBoxRewardGetStateError = 4007,//״̬ 0 1 2 ֻ��1����ȡ
        ErrorShopBuyNoConf = 4008,//û�д���Ʒ

        ErrorTaskNull = 40010,//���ݿ�û�д�����
        ErrorTaskMainNoConf = 4011,//û�д���������
        ErrorTaskDailyNoConf = 4012,//û�д�����
        ErrorTaskAchieveNoConf = 4013,//û�д�����
        ErrorTaskDailyBoxNoConf = 4014,//û�д�����
        ErrorTaskStateNotCanReward = 4015,//״̬��1������ȡ
        ErrorNotUnLockHead = 4016,//δ������ͷ��
        ErrorUserExpNotSubtract = 4017,//���Ǿ��鲻�ܿ۳�
        ErrorUserLevelNotChangeByConf = 4018,//���ǵȼ��������õ�����	
        ErrorBuyEnergyByDiamondButTimesZero = 4019,
        ErrorBuyEnergyNeedWhat = 4020,//��ǰֻ����ad �� ��ʯ���� ������Դ�۳��Ǵ����
                                      //SigninError
        ErrorModifyNameOnlyOnece = 4021,//����ֻ��һ��
        ErrorSignin7NoConf = 4050,//û�������
        ErrorSignin7AlreadSigned = 4051,//�Ѿ�ǩ����

        ErrorDailyShopBuyCountZero = 4070,//ÿ���Ƽ��̵�����

        ErrorGameSystemNotUnlock = 4100,//����δ����
        ErrorGetPatrolRewardNotHas = 4150,//��ȡѲ�߽��� ����ǰû�н�������
        ErrorGetPatrolRewardAdTimesNotEnouth = 4151,//�����ȡ����Ѳ��ʱ ������������
        ErrorGetPatrolRewardEngreyTimesNotEnouth = 4152,//������ȡ����Ѳ��ʱ ������������
        ErrorGetSpecialEventRewardTimesNotEnouth = 4153,//Ѳ���������¼���ȡ���ǽ�������Ѿ�Ϊ0�� Ϊʲô������
                                                        //TalentError
        ErrorGetTalentNotUnLock = 4101,//δ���� �ȼ�����
        ErrorGetTalentAheadNotUnlock = 4102,//ǰһ��δ����
        ErrorGetTalentAlreadyUnlock = 4103,//�ѽ���
        ErrorGetTalentNoThisType = 4104,//Ŀǰֻ��TalentType   ���츳С�츳 ����2��������ʾ

        ErrorVip30NotSameTimeOn = 4200,//��Ҫͬʱ������vipû��ͬʱ����
        ErrorVip30SameTimeRewarded = 4201,//�Ѿ������
        ErrorVip30NomalOff = 4202,//��ͨ�¿���ʧЧ
        ErrorVip30NomalRewarded = 4203,//��ͨ�¿�����ȡ
        ErrorVip30HightOff = 4204,//�߼��¿���ʧЧ
        ErrorVip30HightRewarded = 4205,//�߼��¿�����ȡ


        ErrorHeroReplaceError = 4241,//Ҫ�滻��Ӣ�۲�������
        ErrorHeroLineup = 4242,//��Ӣ��������
        //ErrorHeroUpLevelMaxLevel = 4243,//������
        ErrorHeroUpLevelNotBelongYou = 4244,//�������˵�Ӣ���ǲ���
        ErrorHeroReplaceNotBelongYou = 4245,//�滻���˵�Ӣ���ǲ���
        ErrorHeroRebirthNotBreak = 4246,//����ʱ���Ӣ��ָ����������
        ErrorHeroRebirthLevelOrStarMustOverOne = 4247,//����ʱӢ�۱���ֻ�ǵȼ������Ǽ�����1
        ErrorHeroRebirthNotBelongYou = 4248,//��Ӣ�۲�������
        ErrorHeroUpStarButSelected = 4249,//���ǵ���ʹ���������

        ErrorDrawAdTimesNotEnouth = 4250,
        ErrorDrawTimesNotEnouth = 4251,//�齱������׼
        ErrorHeroLevelLimit = 4260,//����Ӣ�� ����ǰӢ�۵ȼ�������  
        ErrorHeroCanNotUpStar = 4261,//����ͻ��Ӣ�� ��Ӣ�۱��������˲���ͻ�� IsUplevel
        ErrorHeroUpStarButNeedNotEnouth = 4262,//���ǵ���������
        ErrorHeroUpStarNeedSelf = 4263,//����ͻ��Ӣ�� ��Ҫ�����Լ�heroidһ��
        ErrorHeroUpStarCostItemNeedSame = 4264,//�ͻ��˴��������ĵ��� �����ĵ��ߺ���Ҫ���߲�һ��
        ErrorHeroUpStarNeedTypeSame = 4265,//��Ҫ��ְͬҵ��Ӣ��

        ErrorGoldFightTimesNotEnouth = 4266,//��Ҹ��������������
        ErrorHardFightNeedMainChapterNotEnouth = 4267,//��ս������Ҫ�������½ڲ�����
        ErrorHardFightNotUnlock = 4268,//����ս���� δ���� ����������ᷢ��
        ErrorHardFightUpChapterNotPass = 4269,//��һ��û��ͨ�� ����������ᷢ��
        ErrorHardChapterState = 4270,//��ս����������ʱ�� ״̬��Ϊ1
        ErrorHardChapterGetStateError = 4271,//HardChapterStateType ֻ��canGet������ȡ

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


