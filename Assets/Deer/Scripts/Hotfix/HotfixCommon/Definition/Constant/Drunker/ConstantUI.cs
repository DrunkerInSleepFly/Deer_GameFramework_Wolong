// ================================================
//描 述:
//作 者:杜鑫
//创建时间:2022-06-17 15-50-10
//修改作者:杜鑫
//修改时间:2022-06-17 15-50-10
//版 本:0.1 
// ===============================================

using System;
using System.Collections.Generic;

public static class HotfixICallTheShotsConstantUI
{
    private static Dictionary<EUIFormId, ConstantUI.UIFormInfo> uiForms = new Dictionary<EUIFormId, ConstantUI.UIFormInfo>()
        {
            {EUIFormId.UIcForm, new  ConstantUI.UIFormInfo( ConstantUI.EUIFormType.SubForm,"ICallTheShots","UIcForm", ConstantUI.EUIGroupName.PopUI,true,true)},
            {EUIFormId.UIServerLodingForm, new  ConstantUI.UIFormInfo( ConstantUI.EUIFormType.SubForm,"ICallTheShots","UIServerLodingForm", ConstantUI.EUIGroupName.PopUI,true,true)},
            //{EUIFormId.UILoadingForm, new UIFormInfo(EUIFormType.MainForm,"BaseAssets","UILoadingForm",EUIGroupName.AnimationOn,false,true)},
            //{EUIFormId.UILoadingOneForm, new UIFormInfo(EUIFormType.MainForm,"BaseAssets","UILoadingOneForm",EUIGroupName.PopUI,false,true)},
            //{EUIFormId.UIMainMenuForm, new UIFormInfo(EUIFormType.MainForm,"BaseAssets","UIMainMenuForm",EUIGroupName.Background,false,true)},
        };

    public static ConstantUI.UIFormInfo GetUIFormInfo(EUIFormId euiFormId)
    {
        if (uiForms.ContainsKey(euiFormId))
        {
            return uiForms[euiFormId];
        }
        return null;
    }
    public static ConstantUI.UIFormInfo GetUIFormInfo<T>()
    {
        string name = typeof(T).Name;
        try
        {
            EUIFormId euiFormId = (EUIFormId)System.Enum.Parse(typeof(EUIFormId), name);
            if (uiForms.ContainsKey(euiFormId))
            {
                return uiForms[euiFormId];
            }
        }
        catch (Exception e)
        {
            Logger.Error(e.ToString());
            return null;
        }
        return null;
    }

    /// <summary>
    /// 界面编号。
    /// </summary>
    public enum EUIFormId
    {
        Undefined = 0,

        /// <summary>
        /// 弹出框。 网络转圈
        /// </summary>
        UIcForm = 2,
        /// <summary>
        /// 提示框。 服务器Loding
        /// </summary>
        UIServerLodingForm = 3
    }
}

