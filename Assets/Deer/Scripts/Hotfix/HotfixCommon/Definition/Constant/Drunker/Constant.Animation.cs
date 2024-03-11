using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public static partial class Constant
    {
        public static class RoleAnimation
        {

            public static readonly string Idle = "idle";
            public static readonly string Move = "move";
            public static readonly string Attack = "attack1";
            public static readonly string Hit = "hit";
            public static readonly string Death = "dead";
            public static readonly string Win = "win";

        }

        public static class BulletAnimation
        {
            /// <summary>
            /// 出现
            /// </summary>
            public static readonly string Appear = "appear_Bullet";
            /// <summary>
            /// 移动
            /// </summary>
            public static readonly string Flying = "flying_Bullet";
            /// <summary>
            /// 消失
            /// </summary>
            public static readonly string Disappear = "disappear_Bullet";

        }
        public static class MagicPropAnimation
        {
            /// <summary>
            /// 出现
            /// </summary>
            public static readonly string Appear = "appear";
            /// <summary>
            /// 移动
            /// </summary>
            public static readonly string Idle = "idle";
            /// <summary>
            /// 消失
            /// </summary>
            public static readonly string Disappear = "disappear";

        }

        public static class BulletAnimationEvent
        {
            public static readonly string BulletFinish = "BulletFinish";
        }

        public static class AnimationEvent
        {
            public static readonly string AttackSell = "AttackSell";
            public static readonly string AttackFinish = "AttackFinish";
            public static readonly string HitFinish = "HitFinish";
            public static readonly string DeathFinish = "DeathFinish";
        }

        public static class PortalAnimationEvent
        {
            public static readonly string PortalFinish = "PortalFinish"; 
            public static readonly string PortalEnemy = "PortalEnemy"; 
        }
        public static class MagicPropAnimationEvent
        {
            public static readonly string MagicPropTakeEffect = "MagicPropTakeEffect";
            public static readonly string MagicPropFinish = "MagicPropFinish";
            public static readonly string MagicPropDisappear = "MagicPropDisappear";
        }
        public static class BonusBoxAnimationEvent
        {
            public static readonly string OpenProfit = "OpenProfit";
            public static readonly string OpenFinish = "OpenFinish";
        }


    }
