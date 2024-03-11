
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
public delegate void AddEffectComplete(bool success, PrefabsPool effectPool, string effectName);

    public class EffectsComponent : GameFrameworkComponent
    {
        private Dictionary<string, PrefabsPool> m_effectPoolDic = new Dictionary<string, PrefabsPool>();

        public void AddEffect(string effectPath, string effectName, AddEffectComplete complete)
        {
            GameEntry.AssetObject.LoadGameObject(effectPath, effectName, delegate (bool success, object obj, int serial)
             {
                 if (success)
                 {
                     GameObject effectObj = (GameObject)obj;
                     effectObj.SetActive(false);
                     effectObj.hideFlags = HideFlags.HideInHierarchy;
                     PrefabsPool ppool = GameEntry.PrefabsPool.CreateMultiSpawnObjectPool(effectName, effectObj, transform, false, 0);
                     m_effectPoolDic.Add(effectName, ppool);
                     complete?.Invoke(success, ppool, effectName);
                 }
                 else
                 {
                     Debug.Log("EffectsComponent LoadGameObject Fail:" + effectName);
                 }
             });
        }

        public bool HasEffect(string effectName)
        {
            if (!m_effectPoolDic.ContainsKey(effectName))
            {
                return false;
            }
            return true;
        }

        public void ShowEffect(string effectName, Vector3 effectPosition)
        {
            ShowEffect(effectName, null, effectPosition, Vector3.one);
        }
        public void ShowEffect(string effectName, Vector3 effectPosition, Vector3 effectScale)
        {
            if (!HasEffect(effectName))
            {
                return;
            }
            ShowEffect(effectName, null, effectPosition, effectScale);
        }

        public void ShowEffect(string effectName)
        {
            ShowEffect(effectName, null, Vector3.zero, Vector3.one);
        }
        public void ShowEffect(string effectName, Transform parent)
        {
            ShowEffect(effectName, parent, Vector3.zero, Vector3.one);
        }

        public void ShowEffect(string effectName, Transform parent, Vector3 effectPosition, Vector3 effectScale)
        {

            if (!m_effectPoolDic.ContainsKey(effectName))
            {
                Debug.Log($"Not have {effectName} the Effect");
                return;
            }
            PrefabsPool effectPool = m_effectPoolDic[effectName];

            GameObject go = effectPool.Spawn(true, parent);

            if (go.transform.FindInChild("Effect").GetComponent<AnimatorListener>() != null)
            {
                AnimationEffect aEffect = go.GetOrAddComponent<AnimationEffect>();
                aEffect.SetEffectInfo(effectName, EffectEnum.Animation);
            }

            go.hideFlags = HideFlags.None;
            go.transform.localPosition = effectPosition;
            go.transform.localScale = effectScale;
        }

        public void RecoveryEffect(string effectName, GameObject go)
        {
            if (!m_effectPoolDic.ContainsKey(effectName))
            {
                GameObject.Destroy(go);
                Debug.Log($"Not have {effectName} the Effect");
                return;
            }
            PrefabsPool effectPool = m_effectPoolDic[effectName];
            effectPool.Unspawn(go);
        }
    }
