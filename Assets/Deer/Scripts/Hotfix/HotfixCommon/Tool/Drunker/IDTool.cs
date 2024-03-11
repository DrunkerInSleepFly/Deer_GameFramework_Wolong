using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class IDTool
    {
        //public static bool IsKey(int id) {
        //    if (id/100000000==6&&id% 100000000 == 8) {
        //        return true;
        //    }            
        //    return false;
        //}
        //public static bool IsHero(int id)
        //{
        //    if (id / 10000000 == 10) { 
        //        return true;
        //    }
        //    return false;
        //}
        //public static bool IsRes(int id) {
        //    if (id / 10000000 == 50)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //public static int getRes1Id(int id) {
        //   return ((int)IdNewType.itemRes1) + id;
        //}
        //public static int getRes2Id(int id)
        //{
        //    return ((int)IdNewType.itemRes2) + id;
        //}
        //public static bool IsRewardBox(int id)
        //{
        //    return id / 10000000 == 23;
        //}
        //public static bool IsHeroSpecific(int id)
        //{
        //    return id / 10000000 == 11;
        //}
        //public static bool IsHeroAttack(int id)
        //{
        //    return id / 100000000 == 9;
        //}
        //public static bool IsEnemyAttack(int id)
        //{
        //    return id / 10000000 == 32;
        //}
        //public static bool IsEnemy(int id)
        //{
        //    return id / 100000000 == 3;
        //}

        //public static bool IsCityEffect(int id)
        //{
        //    return id / 10000000 == 13;
        //}
        //public static bool IsKeyEffect(int id) {
        //    return id / 10000000 == 14;
        //}

        //public static bool IsBattleBuff(int id)
        //{
        //    return id / 10000000 == 27;
        //}

        //public static int GetBattleLevel(int id)
        //{
        //    return 400000000 + id;
        //}

        public static string GetIdName(int id)
        {
            return "n" + id;
        }

        public static string GetIdDes(int id)
        {
            return "d" + id;
        }
        public static string GetElementName(int id)
        {
            return "en" + id;
        }
        public static string GetPriceId(float id)
        {
            return "p" + id;
        }

        //public static int GetHeroId(int heroId, int enhanceLevel) {
        //    return (10000 + heroId) * 10000 + enhanceLevel;
        //}

        public static string GetCareerName(int id)
        {
            return "career" + id;
        }

        public static string GetBuffLabel(int buffType)
        {
            return "bl" + buffType;
        }

        public static string GetEnemyTypeName(int etype)
        {
            return "et" + etype;
        }


        public static string GetLevelName(int level)
        {
            return "lvl" + level;
        }

        public static string GetStageName(int level)
        {
            return "stage" + level;
        }

        public static string GetHeroLevelDes(int id,int level)
        {
            return $"heroLvl_{id}_{level}";
        }

        public static string GetEliteName(int group)
        {
            return $"eliteName_{group}";
        }

        public static string GetChapterRewardState(int state)
        {
            return $"crs_{state}";
        }

        public static string GetQualityName(int quality)
        {
            return $"HeroQuality{quality}";
        }
        public static string GetEnhanceQualityName(int quality)
        {
            return $"HeroEnhance{quality}";
        }
        public static string GetAttName(int att)
        {
            return $"attName{att}";
        }
        public static string GetAttDes(int att)
        {
            return $"attDes{att}";
        }
        public static string GetSummonRateDes(int id,int quality)
        {
            return $"sr_{id}_{quality}";
        }


    }

