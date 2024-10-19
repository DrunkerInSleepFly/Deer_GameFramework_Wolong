// ================================================
//描 述:
//作 者:
//创建时间:2023年9月1日
//修改作者:Drunker
//修改时间:2023年9月1日
//版 本:0.1 
// ===============================================

using UnityEngine;

    public class AnimationEffect : MonoBehaviour, IEffect
    {
        public EffectEnum m_effectEnum;
        public string m_effectName;
        protected AnimatorListener m_animatorListener;

        private void Awake()
        {
            m_animatorListener = transform.Find("Effect").GetComponent<AnimatorListener>();
            m_animatorListener.On(Constant.EffectAnimationEvent.EffectFinish, OnEffectFinish);
        }

        public EffectEnum EffectEnum()
        {
            return m_effectEnum;
        }

        public string EffectName()
        {
            return m_effectName;
        }

        public void OnRecovery()
        {

        }

        public void OnShow()
        {

        }

        public void SetEffectInfo(string effectName, EffectEnum effectEnum)
        {
            m_effectName = effectName;
        }

        public void OnEffectFinish()
        {
            GameEntry.Effect.RecoveryEffect(m_effectName, gameObject);
        }
    }
