// ================================================
//描 述:
//作 者:Wyp
//创建时间:2023年6月9日
//修改作者:Wyp
//修改时间:2023年6月9日
//版 本:0.1 
// ===============================================
using System;
using TMPro;
using UnityEngine;
using UnityGameFramework.Runtime;
public sealed partial class ExtendLocalizationComponent : GameFrameworkComponent
{
    [Serializable]
    private sealed class FontGroup
    {
        [SerializeField]
        private string m_Name = null;

        [SerializeField]
        private TMP_FontAsset m_Font;
        public string Name
        {
            get
            {
                return m_Name;
            }
        }

        public TMP_FontAsset Font
        {
            get
            {
                return m_Font;
            }
        }
    }
}

