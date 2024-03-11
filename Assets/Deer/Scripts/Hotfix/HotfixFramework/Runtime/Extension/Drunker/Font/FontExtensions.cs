// ================================================
//�� ��:
//�� ��:Wyp
//����ʱ��:2023��6��9��
//�޸�����:Wyp
//�޸�ʱ��:2023��6��9��
//�� ��:0.1 
// ===============================================

using GameFramework.Resource;
using TMPro;
using UnityEngine;
public static partial class FontExtensions
{
    /// <summary>
    /// �����ַ���
    /// </summary>
    /// <param name="text"></param>
    /// <param name="key"></param>
    /// <param name="isUseMainFont"></param>
    public static void SetString(this TextMeshProUGUI text, string key, bool isUseMainFont, params object[] args)
    {
        GameEntry.ExtendLocalization.SetTextString(text, key, isUseMainFont, args);
    }

    /// <summary>
    /// �����ַ���
    /// </summary>
    /// <param name="text"></param>
    /// <param name="key"></param>
    /// <param name="fontName"></param>
    //public static void SetString(this TextMeshProUGUI text, string key, string fontName, params object[] args)
    //{
    //    GameEntryMain.Localization.SetTextString(text, key, fontName, args);
    //}
    public static void SetString(this TextMeshProUGUI text, string key, params object[] args)
    {
        GameEntry.ExtendLocalization.SetTextString(text, key, args);
    }
    public static void SetString(this TextMeshProUGUI text, string key, TMP_FontAsset font, params object[] args)
    {
        GameEntry.ExtendLocalization.SetTextString(text, key, font, args);
    }

    /// <summary>
    /// ����ʹ��Ĭ������
    /// </summary>
    /// <param name="text"></param>
    /// <param name="key"></param>
    /// <param name="font"></param>
    public static void SetFont(this TextMeshProUGUI text)
    {
        GameEntry.ExtendLocalization.SetFont(text);
    }


    private static void LoadFontAsset(string fontAssetName)
    {
        LoadAssetCallbacks m_LoadFontAssetCallbacks = new LoadAssetCallbacks(LoadFontAssetSuccess, LoadFontAssetFailure);
        string assetPath = HotfixDrunker.Framework.AssetUtility.Font.GetFontAsset("fontAssetName");

        GameEntryMain.Resource.LoadAsset(assetPath, m_LoadFontAssetCallbacks);

    }

    private static void LoadFontAssetFailure(string assetName, LoadResourceStatus status, string errorMessage, object userData)
    {

    }

    private static void LoadFontAssetSuccess(string assetName, object asset, float duration, object userData)
    {
        if (asset == null)
            return;
        GameObject gameObject = (GameObject)asset;
        FontAsset loadFont = gameObject.GetComponent<FontAsset>();
        GameEntry.ExtendLocalization.SetMainFont(loadFont);
    }
}
