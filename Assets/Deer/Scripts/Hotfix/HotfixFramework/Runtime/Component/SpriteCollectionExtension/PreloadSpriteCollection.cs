// ================================================
//描 述:
//作 者:
//创建时间:2023年6月9日
//修改作者:Drunker
//修改时间:2023年6月9日
//版 本:0.1 
// ===============================================
using System;
using GameFramework;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace UGFExtensions.SpriteCollection
{
    [Serializable]
    public class PreloadSpriteCollection : IReference
    {
        //#if ODIN_INSPECTOR
        //        [ShowInInspector]
        //#endif
        //        private Image m_Image;

        public static PreloadSpriteCollection Create(string collection)
        {
            PreloadSpriteCollection preloadSpriteCollection = ReferencePool.Acquire<PreloadSpriteCollection>();
            //waitSetImage.m_Image = obj;
            //waitSetImage.SpritePath = spriteName;
            preloadSpriteCollection.CollectionPath = collection;
            //int index1 = preloadSpriteCollection.SpritePath.LastIndexOf("/", StringComparison.Ordinal);
            //int index2 = preloadSpriteCollection.SpritePath.LastIndexOf(".", StringComparison.Ordinal);
            //preloadSpriteCollection.SpriteName = index2 < index1
            //    ? preloadSpriteCollection.SpritePath.Substring(index1 + 1)
            //    : preloadSpriteCollection.SpritePath.Substring(index1 + 1, index2 - index1 - 1);
            return preloadSpriteCollection;
        }
        //#if ODIN_INSPECTOR
        //        [ShowInInspector]
        //#endif
        //        public string SpritePath { get; private set; }
#if ODIN_INSPECTOR
        [ShowInInspector]
#endif
        public string CollectionPath { get; private set; }
        //#if ODIN_INSPECTOR
        //        [ShowInInspector]
        //#endif
        //        private string SpriteName { get; set; }

        //public void SetSprite(Sprite sprite)
        //{
        //    if (m_Image != null)
        //    {
        //        m_Image.sprite = sprite;
        //    }
        //}

        //public bool IsCanRelease()
        //{
        //    return m_Image == null || m_Image.sprite == null || m_Image.sprite.name != SpriteName;
        //}
        //#if !ODIN_INSPECTOR && UNITY_EDITOR
        //        public Rect DrawSetSpriteObject(Rect rect)
        //        {
        //            EditorGUI.ObjectField(rect, "Image", m_Image, typeof(Image), true);
        //            rect.y += EditorGUIUtility.singleLineHeight;
        //            EditorGUI.TextField(rect, "CollectionPath", CollectionPath);
        //            rect.y += EditorGUIUtility.singleLineHeight;

        //            EditorGUI.TextField(rect, "SpritePath", SpritePath);
        //            rect.y += EditorGUIUtility.singleLineHeight;

        //            EditorGUI.TextField(rect, "CollectionPath", CollectionPath);
        //            rect.y += EditorGUIUtility.singleLineHeight;

        //            EditorGUI.TextField(rect, "SpriteName", SpriteName);
        //            rect.y += EditorGUIUtility.singleLineHeight;

        //            EditorGUI.Toggle(rect, "IsCanRelease", IsCanRelease());
        //            return rect;
        //        }
        //#endif
        public void Clear()
        {
            //m_Image = null;
            //SpritePath = null;
            CollectionPath = null;
            //SpriteName = null;
        }
    }
}