// ================================================
//描 述:
//作 者:杜鑫
//创建时间:2022-06-05 18-42-47
//修改作者:杜鑫
//修改时间:2022-06-05 18-42-47
//版 本:0.1 
// ===============================================
using Main.Runtime.Procedure;
using System.Collections.Generic;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
using UnityEngine;
using UnityGameFramework.Runtime;
using GameFramework.Event;
using HotfixFramework;

namespace HotfixBusiness.Procedure
{
    public class ProcedurePreload : ProcedureBase
    {
        private ProcedureOwner m_procedureOwner = null;

        public static readonly string[] DataTableNames = new string[]
       {
           "SkillInfo"
       };
      

        private HashSet<string> m_LoadConfigFlag = new HashSet<string>();
        private Dictionary<string, bool> m_LoadedFlag = new Dictionary<string, bool>();
        private int m_LoadAssetsCount;
        private int m_LoadAssetsAllCount;
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);

            Logger.Debug("tackor HotFix ProcedurePreload OnEnter");

            m_procedureOwner = procedureOwner;
            //初始化所有角色信息管理器
            PreloadConfig();

            GameEntry.Event.Subscribe(LoadDataTableSuccessEventArgs.EventId, OnLoadDataTableSuccess);
            GameEntry.Event.Subscribe(LoadDataTableFailureEventArgs.EventId, OnLoadDataTableFailure);
            m_LoadedFlag.Clear();

            PreloadResources();
        }
        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
            if (IsPreloadFinish())
            {
                ChangeState<ProcedureMainMenu>(procedureOwner);
            }
        }
        protected override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
        {
            base.OnLeave(procedureOwner, isShutdown);
            GameEntry.Event.Unsubscribe(LoadDataTableSuccessEventArgs.EventId, OnLoadDataTableSuccess);
            GameEntry.Event.Unsubscribe(LoadDataTableFailureEventArgs.EventId, OnLoadDataTableFailure);
        }
        private bool IsPreloadFinish()
        {
            if (m_LoadConfigFlag.Count == 0)
            {
                return true;
            }

            return false;
        }
        #region Config
        private void PreloadConfig()
        {
            m_LoadConfigFlag.Clear();
            m_LoadConfigFlag.Add("Config");
            GameEntry.Config.LoadAllUserConfig(OnLoadConfigComplete);
        }
        private void OnLoadConfigComplete(bool result, string resultMessage)
        {
            if (result)
            {
                m_LoadConfigFlag.Remove("Config");
                PreloadAfterLoadingConfig();
            }
            else
            {
                Logger.ColorInfo(ColorType.cadetblue, resultMessage);
            }
        }
        #endregion


        private void PreloadResources()
        {
            // Preload configs
            //LoadConfig("DefaultConfig");
            //LoadConfig("InitAccountConfig");

            // Preload data tables
            foreach (string dataTableName in DataTableNames)
            {
                LoadDataTable(dataTableName);
            }

            // Preload dictionaries
           // LoadDictionary();

            // Preload fonts
            //LoadFont("MainFont");
            //Preload SpriteCollection
           // LoadSpriteCollection();

           // LoadEffect();

           // LoadEntity();
        }

        private void LoadDataTable(string dataTableName)
        {
            m_LoadAssetsCount++;
            m_LoadAssetsAllCount++;
            string dataTableAssetName = AssetUtility.DataTable.GetDataTableAsset(dataTableName, false);
            // Debug.Log(dataTableAssetName);
            m_LoadedFlag.Add(dataTableAssetName, false);
            GameEntry.DataTable.LoadDataTable(dataTableName, dataTableAssetName, this);
           // GameDataTable.LoadDataTable(dataTableName, dataTableAssetName, this);
        }

        /// <summary>
        /// 加载完 config 之后，重新加载游戏配置
        /// </summary>
        private void PreloadAfterLoadingConfig()
        {
            PreloadView();
        }

        private void PreloadView()
        {


        }


        private void OnLoadDataTableSuccess(object sender, GameEventArgs e)
        {
            LoadDataTableSuccessEventArgs ne = (LoadDataTableSuccessEventArgs)e;
            if (ne.UserData != this)
            {
                return;
            }
            m_LoadAssetsCount--;
            // Debug.Log(string.Format("Load data table '{0}' OK.", ne.DataTableAssetName));
            m_LoadedFlag[ne.DataTableAssetName] = true;
            // Log.Info("Load data table '{0}' OK.", ne.DataTableAssetName);
        }

        private void OnLoadDataTableFailure(object sender, GameEventArgs e)
        {
            LoadDataTableFailureEventArgs ne = (LoadDataTableFailureEventArgs)e;
            if (ne.UserData != this)
            {
                return;
            }

          //  GameEntryMain.RecordLifeCycle(ProcedureID, string.Format("Can not load data table '{0}' from '{1}' with error message '{2}'.", ne.DataTableAssetName, ne.DataTableAssetName, ne.ErrorMessage));
            Debug.Log(string.Format("Can not load data table '{0}' from '{1}' with error message '{2}'.", ne.DataTableAssetName, ne.DataTableAssetName, ne.ErrorMessage));
            Log.Error("Can not load data table '{0}' from '{1}' with error message '{2}'.", ne.DataTableAssetName, ne.DataTableAssetName, ne.ErrorMessage);
        }
    }
}