
using GameFramework.DataTable;
using HotfixFramework.DR;
using System;
using System.Collections.Generic;
using UnityGameFramework.Runtime;

namespace HotfixFramework
{
    /// <summary>
    /// 此组件 框架和具体项目未解耦 待处理
    /// </summary>
    public static class GameDataTable
    {
        private const string DataRowClassPrefixName = "HotfixFramework.DR.DR";

        #region others
        private static Dictionary<int, DRRoleLevel> m_roleLevelDataDic;
        private static Dictionary<int, DRBattlePortal> m_battlePortalDataDic;
        private static Dictionary<string, DRHero> m_heroDataDic;
        private static Dictionary<int, DRHero> m_heroDataDic2;
        private static Dictionary<int, DRHeroLevel> m_heroLevelDataDic;
        private static Dictionary<int, DRMapChapter> m_mapChapterDataDic;
        private static Dictionary<int, DRMapChapterMoney> m_mapGoldChapterDataDic;
        private static Dictionary<int, DRMapChapterHard> m_mapEliteChapterDataDic;
        private static Dictionary<int, List<DRMapChapterHard>> m_eliteChapterDataDic;
        private static Dictionary<int, DRBattleLevel> m_battleLevelDataDic;
        private static Dictionary<int, DRBattleWaves> m_battleWavesDataDic;
        private static Dictionary<int, DREnemyRoute> m_enemyRouteDataDic;
        private static Dictionary<int, DREnemyBattle> m_enemyBattleDataDic;
        private static Dictionary<int, DRSkill> m_skillDataDic;
        private static Dictionary<int, DRGlobalParam> m_globalParam;
        private static Dictionary<int, DRHeroGene> m_heroGeneDic;
        private static Dictionary<int, DRBuff> m_battleBuffDic;
        private static Dictionary<string, DRHeroTeam> m_heroTeamDic;
        private static Dictionary<int, DREquipment> m_equipmentDic;
        private static Dictionary<int, DRItemRes> m_itemRes;
        private static Dictionary<int, DRTaskMain> m_taskMainDic;
        private static Dictionary<int, DRTaskAchieve> m_taskAchieveDic;
        private static Dictionary<int, DRTaskDaily> m_taskDailyDic;
        private static Dictionary<int, DRTaskDaily7> m_taskDaily7Dic;
        private static Dictionary<int, DRTaskBox> m_taskBoxDic;
        private static Dictionary<int, DRTaskBox> m_taskBox7Dic;

        private static Dictionary<int, DRBillingHeap> m_billingHeapDic;
        private static Dictionary<int, DRStoreMapBox> m_storeMapBoxDic;
        private static Dictionary<int, DRStoreHeroList> m_storeListDic;
        private static Dictionary<int, DRStoreZuan> m_storeZuanDic;
        private static Dictionary<int, DRVip30> m_vip3DataDic;
        private static Dictionary<int, DRVip30Effect> m_vip3EffectDataDic;
        private static Dictionary<int, DRDraw> m_drawDataDic;
        private static Dictionary<int, List<DRDrawGroup>> m_drawGroupDataDic;
        private static Dictionary<int, Dictionary<int, DRSignin7>> m_signin7DataDic;
        private static Dictionary<int, Dictionary<int, DRSignin7600>> m_signin7600DataDic;
        private static Dictionary<int, DRGameHead> m_gameHeadDic;
        private static Dictionary<int, DRGameSystem> m_gameSystemDataDic;

        private static Dictionary<int, DRSoundId> m_soundDic;
        private static Dictionary<int, DRNoviceGuide> m_noviceGuideDic;
        #endregion

        private static Dictionary<int, DRSkillInfo> m_SkillInfoDataDic;

        public static Dictionary<int, DRSkillInfo> SkillInfoDataDic { get => m_SkillInfoDataDic; set => m_SkillInfoDataDic = value; }


        // private static Dictionary<int, DRUIForm> m_uiformDic;


        public static void LoadDataTable(this DataTableComponent dataTableComponent, string dataTableName, string dataTableAssetName, object userData)
        {
            if (string.IsNullOrEmpty(dataTableName))
            {
                Log.Warning("Data table name is invalid.");
                return;
            }
            string[] splitedNames = dataTableName.Split('_');
            if (splitedNames.Length > 2)
            {
                Log.Warning("Data table name is invalid.");
                return;
            }
            string dataRowClassName = DataRowClassPrefixName + splitedNames[0] + ",HotfixFramework.Runtime";
            //Debug.Log(dataRowClassName);
            Type dataRowType = Type.GetType(dataRowClassName);
            if (dataRowType == null)
            {
                Log.Warning("Can not get data row type with class name '{0}'.", dataRowClassName);
                return;
            }
            string name = splitedNames.Length > 1 ? splitedNames[1] : null;
            DataTableBase dataTable = dataTableComponent.CreateDataTable(dataRowType, name);
            dataTable.ReadData(dataTableAssetName, Constant.AssetPriority.DataTableAsset, userData);
        }

        public static void InitTable()
        {
            GetDRSkillInfo(1);
        }
        public static DRSkillInfo GetDRSkillInfo(int id)
        {
            if (m_SkillInfoDataDic == null)
            {
                m_SkillInfoDataDic = new Dictionary<int, DRSkillInfo>();
                DRSkillInfo[] allDataRow = GameEntry.DataTable.GetDataTable<DRSkillInfo>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_SkillInfoDataDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_SkillInfoDataDic.ContainsKey(id))
                return m_SkillInfoDataDic[id];
            return null;
        }


        public static DRRoleLevel GetUserLevelById(int level)
        {
            if (m_roleLevelDataDic == null)
            {
                m_roleLevelDataDic = new Dictionary<int, DRRoleLevel>();
                DRRoleLevel[] allDataRow = GameEntry.DataTable.GetDataTable<DRRoleLevel>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_roleLevelDataDic.Add(allDataRow[i].RoleLevel, allDataRow[i]);
                }
            }
            if (m_roleLevelDataDic.ContainsKey(level))
                return m_roleLevelDataDic[level];
            return null;
        }

        public static DRBattlePortal GetBattlePortalById(int id)
        {
            if (m_battlePortalDataDic == null)
            {
                m_battlePortalDataDic = new Dictionary<int, DRBattlePortal>();
                DRBattlePortal[] allDataRow = GameEntry.DataTable.GetDataTable<DRBattlePortal>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_battlePortalDataDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_battlePortalDataDic.ContainsKey(id))
                return m_battlePortalDataDic[id];
            return null;
        }

        public static DRHero GetHeroByInfo(int id, int star)
        {
            string selectKey = string.Format("{0}_{1}", id, star);
            if (m_heroDataDic == null)
            {
                m_heroDataDic = new Dictionary<string, DRHero>();
                m_heroDataDic2 = new Dictionary<int, DRHero>();
                DRHero[] allDataRow = GameEntry.DataTable.GetDataTable<DRHero>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    string key = string.Format("{0}_{1}", allDataRow[i].HeroId, allDataRow[i].Star);
                    m_heroDataDic.Add(key, allDataRow[i]);
                    m_heroDataDic2.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_heroDataDic.ContainsKey(selectKey))
            {
                return m_heroDataDic[selectKey];
            }
            return null;
        }

        public static DRHero GetHeroById(int id)
        {
            if (m_heroDataDic == null)
            {
                m_heroDataDic = new Dictionary<string, DRHero>();
                m_heroDataDic2 = new Dictionary<int, DRHero>();
                DRHero[] allDataRow = GameEntry.DataTable.GetDataTable<DRHero>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    string key = string.Format("{0}_{1}", allDataRow[i].HeroId, allDataRow[i].Star);
                    m_heroDataDic.Add(key, allDataRow[i]);
                    m_heroDataDic2.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_heroDataDic2.ContainsKey(id))
            {
                return m_heroDataDic2[id];
            }
            return null;
        }

        //public static DRHero GetHeroEnhanceByInfo(int heroId, int enhanceLevel)
        //{
        //    return GetHeroByInfo(IDTool.GetHeroId(heroId, enhanceLevel));
        //}

        public static DRHeroLevel GetHeroLevelByInfo(int level)
        {
            if (m_heroLevelDataDic == null)
            {
                m_heroLevelDataDic = new Dictionary<int, DRHeroLevel>();
                DRHeroLevel[] allDataRow = GameEntry.DataTable.GetDataTable<DRHeroLevel>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_heroLevelDataDic.Add(allDataRow[i].Level, allDataRow[i]);
                }
            }
            return m_heroLevelDataDic[level];
        }
        public static Dictionary<int, DRMapChapter> GetMapChapters()
        {
            if (m_mapChapterDataDic == null)
            {
                m_mapChapterDataDic = new Dictionary<int, DRMapChapter>();
                DRMapChapter[] allDataRow = GameEntry.DataTable.GetDataTable<DRMapChapter>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_mapChapterDataDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            return m_mapChapterDataDic;
        }
        public static DRMapChapter GetMapChapterById(int id)
        {
            if (m_mapChapterDataDic == null)
            {
                m_mapChapterDataDic = new Dictionary<int, DRMapChapter>();
                DRMapChapter[] allDataRow = GameEntry.DataTable.GetDataTable<DRMapChapter>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_mapChapterDataDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_mapChapterDataDic.ContainsKey(id))
                return m_mapChapterDataDic[id];
            return null;
        }
        public static DRMapChapterHard GetEliteMapChapterById(int id)
        {
            if (m_mapEliteChapterDataDic == null)
            {
                m_mapEliteChapterDataDic = new Dictionary<int, DRMapChapterHard>();
                DRMapChapterHard[] allDataRow = GameEntry.DataTable.GetDataTable<DRMapChapterHard>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_mapEliteChapterDataDic.Add(allDataRow[i].Id, allDataRow[i]);

                    if (m_eliteChapterDataDic.ContainsKey(allDataRow[i].GroupId))
                    {
                        m_eliteChapterDataDic[allDataRow[i].GroupId].Add(allDataRow[i]);
                    }
                    else
                    {
                        List<DRMapChapterHard> clist = new List<DRMapChapterHard>();
                        clist.Add(allDataRow[i]);
                        m_eliteChapterDataDic.Add(allDataRow[i].GroupId, clist);
                    }

                }
            }
            if (m_mapEliteChapterDataDic.ContainsKey(id))
                return m_mapEliteChapterDataDic[id];
            return null;
        }
        public static Dictionary<int, List<DRMapChapterHard>> GetEliteMapChapter()
        {
            if (m_mapEliteChapterDataDic == null)
            {
                m_mapEliteChapterDataDic = new Dictionary<int, DRMapChapterHard>();
                m_eliteChapterDataDic = new Dictionary<int, List<DRMapChapterHard>>();
                DRMapChapterHard[] allDataRow = GameEntry.DataTable.GetDataTable<DRMapChapterHard>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_mapEliteChapterDataDic.Add(allDataRow[i].Id, allDataRow[i]);

                    if (m_eliteChapterDataDic.ContainsKey(allDataRow[i].GroupId))
                    {
                        m_eliteChapterDataDic[allDataRow[i].GroupId].Add(allDataRow[i]);
                    }
                    else
                    {
                        List<DRMapChapterHard> clist = new List<DRMapChapterHard>();
                        clist.Add(allDataRow[i]);
                        m_eliteChapterDataDic.Add(allDataRow[i].GroupId, clist);
                    }

                }
            }
            return m_eliteChapterDataDic;
        }
        public static List<DRMapChapterHard> GetEliteMapChapterByGroup(int group)
        {
            if (m_mapEliteChapterDataDic == null)
            {
                m_mapEliteChapterDataDic = new Dictionary<int, DRMapChapterHard>();
                m_eliteChapterDataDic = new Dictionary<int, List<DRMapChapterHard>>();
                DRMapChapterHard[] allDataRow = GameEntry.DataTable.GetDataTable<DRMapChapterHard>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_mapEliteChapterDataDic.Add(allDataRow[i].Id, allDataRow[i]);

                    if (m_eliteChapterDataDic.ContainsKey(allDataRow[i].GroupId))
                    {
                        m_eliteChapterDataDic[allDataRow[i].GroupId].Add(allDataRow[i]);
                    }
                    else
                    {
                        List<DRMapChapterHard> clist = new List<DRMapChapterHard>();
                        clist.Add(allDataRow[i]);
                        m_eliteChapterDataDic.Add(allDataRow[i].GroupId, clist);
                    }

                }
            }
            if (!m_eliteChapterDataDic.ContainsKey(group))
                return null;
            return m_eliteChapterDataDic[group];
        }
        public static Dictionary<int, DRMapChapterMoney> GetGoldChapters()
        {
            if (m_mapGoldChapterDataDic == null)
            {
                m_mapGoldChapterDataDic = new Dictionary<int, DRMapChapterMoney>();
                DRMapChapterMoney[] allDataRow = GameEntry.DataTable.GetDataTable<DRMapChapterMoney>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_mapGoldChapterDataDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            return m_mapGoldChapterDataDic;
        }
        public static DRMapChapterMoney GetGoldChapterById(int id)
        {
            if (m_mapGoldChapterDataDic == null)
            {
                m_mapGoldChapterDataDic = new Dictionary<int, DRMapChapterMoney>();
                DRMapChapterMoney[] allDataRow = GameEntry.DataTable.GetDataTable<DRMapChapterMoney>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_mapGoldChapterDataDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_mapGoldChapterDataDic.ContainsKey(id))
                return m_mapGoldChapterDataDic[id];
            return null;
        }
        public static DRBattleLevel GetBattleLevelById(int id)
        {
            if (m_battleLevelDataDic == null)
            {
                m_battleLevelDataDic = new Dictionary<int, DRBattleLevel>();
                DRBattleLevel[] allDataRow = GameEntry.DataTable.GetDataTable<DRBattleLevel>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_battleLevelDataDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_battleLevelDataDic.ContainsKey(id))
                return m_battleLevelDataDic[id];
            return null;
        }

        public static DRBattleWaves GetBattleWavesById(int id)
        {
            if (m_battleWavesDataDic == null)
            {
                m_battleWavesDataDic = new Dictionary<int, DRBattleWaves>();
                DRBattleWaves[] allDataRow = GameEntry.DataTable.GetDataTable<DRBattleWaves>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_battleWavesDataDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_battleWavesDataDic.ContainsKey(id))
                return m_battleWavesDataDic[id];
            return null;
        }
        public static DREnemyRoute GetEnemyLineById(int id)
        {
            if (m_enemyRouteDataDic == null)
            {
                m_enemyRouteDataDic = new Dictionary<int, DREnemyRoute>();
                DREnemyRoute[] allDataRow = GameEntry.DataTable.GetDataTable<DREnemyRoute>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_enemyRouteDataDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_enemyRouteDataDic.ContainsKey(id))
                return m_enemyRouteDataDic[id];
            return null;
        }

        public static DREnemyBattle GetEnemyBattleById(int id)
        {
            if (m_enemyBattleDataDic == null)
            {
                m_enemyBattleDataDic = new Dictionary<int, DREnemyBattle>();
                DREnemyBattle[] allDataRow = GameEntry.DataTable.GetDataTable<DREnemyBattle>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_enemyBattleDataDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_enemyBattleDataDic.ContainsKey(id))
                return m_enemyBattleDataDic[id];
            return null;
        }

        public static DRSkill GetSkillById(int id)
        {
            if (m_skillDataDic == null)
            {
                m_skillDataDic = new Dictionary<int, DRSkill>();
                DRSkill[] allDataRow = GameEntry.DataTable.GetDataTable<DRSkill>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_skillDataDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_skillDataDic.ContainsKey(id))
                return m_skillDataDic[id];
            return null;
        }

        public static DRGlobalParam GetNormalGlobalParam()
        {
            return GetGlobalParamById(1);
        }

        public static DRGlobalParam GetGlobalParamById(int id)
        {

            if (m_globalParam == null)
            {
                m_globalParam = new Dictionary<int, DRGlobalParam>();
                DRGlobalParam[] allDataRow = GameEntry.DataTable.GetDataTable<DRGlobalParam>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_globalParam.Add(allDataRow[i].Id, allDataRow[i]);
                }

            }
            if (m_globalParam.ContainsKey(id))
                return m_globalParam[id];
            return null;
        }

        public static Dictionary<int, DRHeroGene> GetHeroGenes()
        {
            if (m_heroGeneDic == null)
            {
                m_heroGeneDic = new Dictionary<int, DRHeroGene>();
                DRHeroGene[] allDataRow = GameEntry.DataTable.GetDataTable<DRHeroGene>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_heroGeneDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            return m_heroGeneDic;
        }
        public static DRHeroGene GetHeroGeneByLevel(int id)
        {
            if (m_heroGeneDic == null)
            {
                m_heroGeneDic = new Dictionary<int, DRHeroGene>();
                DRHeroGene[] allDataRow = GameEntry.DataTable.GetDataTable<DRHeroGene>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_heroGeneDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_heroGeneDic.ContainsKey(id))
                return m_heroGeneDic[id];
            return null;
        }

        public static List<DRHeroGene> GetHerosGeneByLevel(int id)
        {
            if (m_heroGeneDic == null)
            {
                m_heroGeneDic = new Dictionary<int, DRHeroGene>();
                DRHeroGene[] allDataRow = GameEntry.DataTable.GetDataTable<DRHeroGene>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_heroGeneDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }

            List<DRHeroGene> genes = new List<DRHeroGene>();

            foreach (var item in m_heroGeneDic.Values)
            {
                if (item.UserLevel <= id)
                {
                    genes.Add(item);
                }
            }

            return genes;
        }

        public static DRBuff GetBattleBuffById(int id)
        {
            if (m_battleBuffDic == null)
            {
                m_battleBuffDic = new Dictionary<int, DRBuff>();
                DRBuff[] allDataRow = GameEntry.DataTable.GetDataTable<DRBuff>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_battleBuffDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_battleBuffDic.ContainsKey(id))
                return m_battleBuffDic[id];
            return null;
        }

        public static DRHeroTeam GetHeroTeamById(int quality, int count)
        {
            string selectKey = string.Format("{0}_{1}", quality, count);
            if (m_heroTeamDic == null)
            {
                m_heroTeamDic = new Dictionary<string, DRHeroTeam>();
                DRHeroTeam[] allDataRow = GameEntry.DataTable.GetDataTable<DRHeroTeam>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    string key = string.Format("{0}_{1}", allDataRow[i].HeroQuality, allDataRow[i].Numbers);
                    m_heroTeamDic.Add(key, allDataRow[i]);
                }
            }
            if (m_heroTeamDic.ContainsKey(selectKey))
                return m_heroTeamDic[selectKey];
            return null;
        }

        public static DREquipment GetEquipmentById(int id)
        {
            if (m_equipmentDic == null)
            {
                m_equipmentDic = new Dictionary<int, DREquipment>();
                DREquipment[] allDataRow = GameEntry.DataTable.GetDataTable<DREquipment>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_equipmentDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_equipmentDic.ContainsKey(id))
                return m_equipmentDic[id];
            return null;
        }
        public static DRItemRes GetItemResById(int id)
        {

            if (m_itemRes == null)
            {
                m_itemRes = new Dictionary<int, DRItemRes>();
                DRItemRes[] allDataRow = GameEntry.DataTable.GetDataTable<DRItemRes>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_itemRes.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_itemRes.ContainsKey(id))
                return m_itemRes[id];
            return null;
        }
        public static DRTaskMain GetMainTaskById(int id)
        {
            if (m_taskMainDic == null)
            {
                m_taskMainDic = new Dictionary<int, DRTaskMain>();
                DRTaskMain[] allDataRow = GameEntry.DataTable.GetDataTable<DRTaskMain>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_taskMainDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_taskMainDic.ContainsKey(id))
                return m_taskMainDic[id];
            return null;
        }
        public static DRTaskAchieve GetTaskAchieveById(int id)
        {
            if (m_taskAchieveDic == null)
            {
                m_taskAchieveDic = new Dictionary<int, DRTaskAchieve>();
                DRTaskAchieve[] allDataRow = GameEntry.DataTable.GetDataTable<DRTaskAchieve>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_taskAchieveDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_taskAchieveDic.ContainsKey(id))
                return m_taskAchieveDic[id];
            return null;
        }

        public static DRTaskDaily7 GetTaskDaily7ById(int id)
        {
            if (m_taskDaily7Dic == null)
            {
                m_taskDaily7Dic = new Dictionary<int, DRTaskDaily7>();
                DRTaskDaily7[] allDataRow = GameEntry.DataTable.GetDataTable<DRTaskDaily7>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_taskDaily7Dic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_taskDaily7Dic.ContainsKey(id))
                return m_taskDaily7Dic[id];
            return null;
        }
        public static DRTaskDaily GetTaskDailyById(int id)
        {
            if (m_taskDailyDic == null)
            {
                m_taskDailyDic = new Dictionary<int, DRTaskDaily>();
                DRTaskDaily[] allDataRow = GameEntry.DataTable.GetDataTable<DRTaskDaily>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_taskDailyDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_taskDailyDic.ContainsKey(id))
                return m_taskDailyDic[id];
            return null;
        }

        public static Dictionary<int, DRTaskBox> GetTaskBoxs()
        {
            if (m_taskBoxDic == null)
            {
                m_taskBoxDic = new Dictionary<int, DRTaskBox>();
                m_taskBox7Dic = new Dictionary<int, DRTaskBox>();
                DRTaskBox[] allDataRow = GameEntry.DataTable.GetDataTable<DRTaskBox>().GetAllDataRows();
                int type_1_Count = 0;
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    if (allDataRow[i].Type == 1)
                    {
                        type_1_Count++;
                        m_taskBoxDic.Add(allDataRow[i].Id, allDataRow[i]);
                    }
                    else if (allDataRow[i].Type == 2)
                    {
                        m_taskBox7Dic.Add(allDataRow[i].Id - type_1_Count, allDataRow[i]);
                    }
                }
            }
            return m_taskBoxDic;
        }

        public static DRTaskBox GetTaskBoxById(int id)
        {
            if (m_taskBoxDic == null)
            {
                m_taskBoxDic = new Dictionary<int, DRTaskBox>();
                m_taskBox7Dic = new Dictionary<int, DRTaskBox>();
                DRTaskBox[] allDataRow = GameEntry.DataTable.GetDataTable<DRTaskBox>().GetAllDataRows();
                int type_1_Count = 0;
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    if (allDataRow[i].Type == 1)
                    {
                        type_1_Count++;
                        m_taskBoxDic.Add(allDataRow[i].Id, allDataRow[i]);
                    }
                    else if (allDataRow[i].Type == 2)
                    {
                        m_taskBox7Dic.Add(allDataRow[i].Id - type_1_Count, allDataRow[i]);
                    }
                }
            }
            if (m_taskBoxDic.ContainsKey(id))
                return m_taskBoxDic[id];
            return null;
        }
        public static DRTaskBox GetTaskBox7ById(int id)
        {
            if (m_taskBox7Dic == null)
            {
                m_taskBoxDic = new Dictionary<int, DRTaskBox>();
                m_taskBox7Dic = new Dictionary<int, DRTaskBox>();
                DRTaskBox[] allDataRow = GameEntry.DataTable.GetDataTable<DRTaskBox>().GetAllDataRows();
                int type_1_Count = 0;
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    if (allDataRow[i].Type == 1)
                    {
                        type_1_Count++;
                        m_taskBoxDic.Add(allDataRow[i].Id, allDataRow[i]);
                    }
                    else if (allDataRow[i].Type == 2)
                    {
                        m_taskBox7Dic.Add(allDataRow[i].Id - type_1_Count, allDataRow[i]);
                    }
                }
            }
            if (m_taskBox7Dic.ContainsKey(id))
                return m_taskBox7Dic[id];
            return null;
        }

        public static DRBillingHeap GetBillingHeapById(int id)
        {
            if (m_billingHeapDic == null)
            {
                m_billingHeapDic = new Dictionary<int, DRBillingHeap>();
                DRBillingHeap[] allDataRow = GameEntry.DataTable.GetDataTable<DRBillingHeap>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_billingHeapDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_billingHeapDic.ContainsKey(id))
                return m_billingHeapDic[id];
            return null;
        }

        public static DRStoreMapBox GetMapStoreBoxById(int id)
        {
            if (m_storeMapBoxDic == null)
            {
                m_storeMapBoxDic = new Dictionary<int, DRStoreMapBox>();
                DRStoreMapBox[] allDataRow = GameEntry.DataTable.GetDataTable<DRStoreMapBox>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_storeMapBoxDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_storeMapBoxDic.ContainsKey(id))
                return m_storeMapBoxDic[id];
            return null;
        }

        public static DRStoreHeroList GetStoreListById(int id)
        {
            if (m_storeListDic == null)
            {
                m_storeListDic = new Dictionary<int, DRStoreHeroList>();
                DRStoreHeroList[] allDataRow = GameEntry.DataTable.GetDataTable<DRStoreHeroList>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_storeListDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_storeListDic.ContainsKey(id))
                return m_storeListDic[id];
            return null;
        }

        public static DRStoreZuan GetStoreZuanById(int id)
        {
            if (m_storeZuanDic == null)
            {
                m_storeZuanDic = new Dictionary<int, DRStoreZuan>();
                DRStoreZuan[] allDataRow = GameEntry.DataTable.GetDataTable<DRStoreZuan>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_storeZuanDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_storeZuanDic.ContainsKey(id))
                return m_storeZuanDic[id];
            return null;
        }
        public static DRVip30 GetVip30DataById(int id)
        {
            if (m_vip3DataDic == null)
            {
                m_vip3DataDic = new Dictionary<int, DRVip30>();
                DRVip30[] allDataRow = GameEntry.DataTable.GetDataTable<DRVip30>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_vip3DataDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_vip3DataDic.ContainsKey(id))
                return m_vip3DataDic[id];
            return null;
        }
        public static DRVip30Effect GetVip30EffectDataById(int id)
        {
            if (m_vip3EffectDataDic == null)
            {
                m_vip3EffectDataDic = new Dictionary<int, DRVip30Effect>();
                DRVip30Effect[] allDataRow = GameEntry.DataTable.GetDataTable<DRVip30Effect>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_vip3EffectDataDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_vip3EffectDataDic.ContainsKey(id))
                return m_vip3EffectDataDic[id];
            return null;
        }
        public static DRDraw GetDrawDataById(int id)
        {
            if (m_drawDataDic == null)
            {
                m_drawDataDic = new Dictionary<int, DRDraw>();
                DRDraw[] allDataRow = GameEntry.DataTable.GetDataTable<DRDraw>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_drawDataDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_drawDataDic.ContainsKey(id))
                return m_drawDataDic[id];
            return null;
        }
        public static List<DRDrawGroup> GetDrawGroupDataById(int type)
        {
            if (m_drawGroupDataDic == null)
            {
                m_drawGroupDataDic = new Dictionary<int, List<DRDrawGroup>>();
                DRDrawGroup[] allDataRow = GameEntry.DataTable.GetDataTable<DRDrawGroup>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    if (m_drawGroupDataDic.ContainsKey(allDataRow[i].Type))
                    {
                        m_drawGroupDataDic[allDataRow[i].Type].Add(allDataRow[i]);
                    }
                    else
                    {
                        List<DRDrawGroup> dropList = new List<DRDrawGroup>();
                        dropList.Add(allDataRow[i]);
                        m_drawGroupDataDic.Add(allDataRow[i].Type, dropList);
                    }
                }
            }
            if (m_drawGroupDataDic.ContainsKey(type))
                return m_drawGroupDataDic[type];
            return null;
        }

        public static Dictionary<int, DRSignin7> GetSignin7DataById(int type)
        {
            if (m_signin7DataDic == null)
            {
                m_signin7DataDic = new Dictionary<int, Dictionary<int, DRSignin7>>();
                DRSignin7[] allDataRow = GameEntry.DataTable.GetDataTable<DRSignin7>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    if (m_signin7DataDic.ContainsKey(allDataRow[i].Which))
                    {
                        m_signin7DataDic[allDataRow[i].Which].Add(allDataRow[i].Pos, allDataRow[i]);
                    }
                    else
                    {
                        Dictionary<int, DRSignin7> dropDic = new Dictionary<int, DRSignin7>();
                        dropDic.Add(allDataRow[i].Pos, allDataRow[i]);
                        m_signin7DataDic.Add(allDataRow[i].Which, dropDic);
                    }
                }
            }
            if (m_signin7DataDic.ContainsKey(type))
                return m_signin7DataDic[type];
            return null;
        }

        public static Dictionary<int, DRSignin7600> GetSignin7600DataById(int type)
        {
            if (m_signin7600DataDic == null)
            {
                m_signin7600DataDic = new Dictionary<int, Dictionary<int, DRSignin7600>>();
                DRSignin7600[] allDataRow = GameEntry.DataTable.GetDataTable<DRSignin7600>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    if (m_signin7600DataDic.ContainsKey(allDataRow[i].Which))
                    {
                        m_signin7600DataDic[allDataRow[i].Which].Add(allDataRow[i].Pos, allDataRow[i]);
                    }
                    else
                    {
                        Dictionary<int, DRSignin7600> dropDic = new Dictionary<int, DRSignin7600>();
                        dropDic.Add(allDataRow[i].Pos, allDataRow[i]);
                        m_signin7600DataDic.Add(allDataRow[i].Which, dropDic);
                    }
                }
            }
            if (m_signin7600DataDic.ContainsKey(type))
                return m_signin7600DataDic[type];
            return null;
        }
        public static Dictionary<int, DRGameHead> GetGameHeads()
        {
            if (m_gameHeadDic == null)
            {
                m_gameHeadDic = new Dictionary<int, DRGameHead>();
                DRGameHead[] allDataRow = GameEntry.DataTable.GetDataTable<DRGameHead>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_gameHeadDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            return m_gameHeadDic;
        }

        public static DRGameHead GetGameHeadById(int id)
        {
            if (m_gameHeadDic == null)
            {
                m_gameHeadDic = new Dictionary<int, DRGameHead>();
                DRGameHead[] allDataRow = GameEntry.DataTable.GetDataTable<DRGameHead>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_gameHeadDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_gameHeadDic.ContainsKey(id))
                return m_gameHeadDic[id];
            return null;
        }
        public static DRGameSystem GetGameSystemById(int id)
        {
            if (m_gameSystemDataDic == null)
            {
                m_gameSystemDataDic = new Dictionary<int, DRGameSystem>();
                DRGameSystem[] allDataRow = GameEntry.DataTable.GetDataTable<DRGameSystem>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_gameSystemDataDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_gameSystemDataDic.ContainsKey(id))
                return m_gameSystemDataDic[id];
            return null;
        }
        public static DRSoundId GetSoundById(int id)
        {
            if (m_soundDic == null)
            {
                m_soundDic = new Dictionary<int, DRSoundId>();
                DRSoundId[] allDataRow = GameEntry.DataTable.GetDataTable<DRSoundId>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_soundDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_soundDic.ContainsKey(id))
                return m_soundDic[id];
            return null;
        }
        public static DRNoviceGuide GetNoviceGuideById(int id)
        {
            if (m_noviceGuideDic == null)
            {
                m_noviceGuideDic = new Dictionary<int, DRNoviceGuide>();
                DRNoviceGuide[] allDataRow = GameEntry.DataTable.GetDataTable<DRNoviceGuide>().GetAllDataRows();
                for (int i = 0; i < allDataRow.Length; i++)
                {
                    m_noviceGuideDic.Add(allDataRow[i].Id, allDataRow[i]);
                }
            }
            if (m_noviceGuideDic.ContainsKey(id))
                return m_noviceGuideDic[id];
            return null;
        }

    }
}