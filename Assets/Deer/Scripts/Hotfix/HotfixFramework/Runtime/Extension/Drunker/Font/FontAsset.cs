using TMPro;
using UnityEngine;


public class FontAsset : MonoBehaviour
{
    [SerializeField]
    private string m_FontName;
    [SerializeField]
    private TMP_FontAsset m_Font;

    public string FontName
    {
        get
        {
            return m_FontName;
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

