using Google.Protobuf.WellKnownTypes;
using System;
using System.Diagnostics;
    public class DateTimeToolEx
    {

        public static TimeSpan Subtract(DateTime a,DateTime b) { 
            TimeSpan timeSpan= b.Subtract(a);
            return timeSpan;
        }

        public static long GetNowLoneTime()
        {
            //��ȷ������
            return new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        }
        public static int GetNowIntTime() {
            return (int)(GetNowLoneTime() / 1000);
        }
        static int lingshi_zone = -99;
        /// <summary>
        /// ���ص�ǰʱ��
        /// </summary>
        /// <param name="lingshi_zone">��ָ������ʱ�����ô��룬ָ��ʱ����Ҫ����-12��12 </param>
        /// <returns></returns>
        public static DateTime GetNowDateTime() {
            if (lingshi_zone == -99)
            {
                lingshi_zone = TimeZoneInfo.Local.BaseUtcOffset.Hours;
            }            
            return   DateTime.Now.AddHours(lingshi_zone - 8);
        }

        /// <summary>
        /// ʱ���תC#ʱ��  �������·���ʱ���Ѿ��������ʱ��������ת����Ӧ�ķ�����ʱ��ʱ��
        /// </summary>
        public static DateTime TimeStamp2DateTime(long timeStamp, int timeZone = 0, bool isSecond = true)
        {
            DateTime startTime = new DateTime(1970, 1, 1, 0, 0, 0);
            DateTime dt = isSecond
            ? startTime.AddSeconds(timeStamp)
                : startTime.AddMilliseconds(timeStamp);

            return dt.AddHours(timeZone);
        }


        /// <summary>
        /// ��ȡʱ���-��λ��
        /// </summary>
        /// <returns></returns>
        public static long GetTimeStampSecond()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            try
            {
                return Convert.ToInt64(ts.TotalSeconds);
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.Log($"GetTimeStampSecond Error = {ex}");
                return 0;
            }
        }
        /// <summary>
        /// ��ȡʱ���-��λ����
        /// </summary>
        /// <returns></returns>
        public static long GetTimeStampMilliSecond()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            try
            {
                return Convert.ToInt64(ts.TotalMilliseconds);
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.Log($"GetTimeStampMilliSecond Error = {ex}");
                return 0;
            }
        }
        public static DateTime GetDateTimeByLong11(long aTime) {
            DateTime startTime = TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc), TimeZoneInfo.Local);// TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));//��ȡʱ���
            DateTime ADateTime = startTime.AddSeconds(aTime);
            return ADateTime;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aTime">Сʱ��</param>
        /// <param name="bTime">��ʱ��</param>
        /// <returns></returns>
        public static bool IsNewDay(long aTime, long bTime) {
            DateTime startTime = TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc), TimeZoneInfo.Local);// TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));//��ȡʱ���
            DateTime ADateTime = startTime.AddSeconds(aTime);          
            DateTime AZeroDateTime = new DateTime(ADateTime.Year, ADateTime.Month, ADateTime.Day);
            DateTime BDateTime = startTime.AddSeconds(bTime);
            DateTime BZeroDateTime = new DateTime(BDateTime.Year, BDateTime.Month, BDateTime.Day);
            if (AZeroDateTime.Year == BZeroDateTime.Year && AZeroDateTime.Month == BZeroDateTime.Month && AZeroDateTime.Day == BZeroDateTime.Day)
            {
                return false;
            }
           // UnityEngine.Debug.Log("IsNewDay:"+DateTime.Compare(AZeroDateTime, BZeroDateTime));
            if (DateTime.Compare(AZeroDateTime, BZeroDateTime)<0)
            {
                return true;
            }
            return false;
        }
        public static int ChaZhi(long refreshTime,long otherTime)
        {
            if (otherTime <= refreshTime)
            {
                return 1;
            }
            else {
                return -1;
            }
            return 0;
        }
        /// <summary>/// ʱ��ת��Ϊ13λʱ���/// 
        /// </summary>/// <param name="_time"></param>
        /// <returns></returns>
        public static long ConvertDateTimeToUtc(DateTime _time) 
        { 
            DateTime time = TimeZoneInfo.ConvertTimeToUtc(new DateTime(1970, 1, 1, 0, 0, 0, 0)); 
            long t = (_time.Ticks - time.Ticks) / 10000; 
            return t;
        }



        /// <summary>
        /// 13λʱ���ת��Ϊʱ��
        /// </summary>
        /// <param name="_utcTime">ʱ���</param>
        /// <returns></returns>
        public static DateTime Convert13UtcToDateTime(string _utcTime)
        {
            DateTime dt = TimeZoneInfo.ConvertTimeToUtc(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            long lTime = long.Parse(_utcTime + "0000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dt.Add(toNow);
        }
        public static DateTime ConvertServerUtcToDateTime10(long _utcTime)
        {
            DateTime dt = TimeZoneInfo.ConvertTimeToUtc(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            TimeSpan toNow = new TimeSpan(_utcTime* 10000);
            return dt.Add(toNow);
        }

        public static DateTime ConvertUtcToDateTime10(long _utcTime)
        {
            DateTime dt = TimeZoneInfo.ConvertTimeToUtc(new DateTime(1970, 1, 1, 0, 0, 0, 0));           
            TimeSpan toNow = new TimeSpan(_utcTime * 10000000);
            return dt.Add(toNow);
        }
        public static long GetNowDateTimeLong()
        {
            DateTime nextDateTime = DateTime.Now;
            return ConvertDateTimeToUtc(nextDateTime) / 1000;
        }
        public static long GetNextDateTime(int second)
        {
            DateTime nextDateTime = DateTime.Now;
            nextDateTime = nextDateTime.AddSeconds(second);
            return ConvertDateTimeToUtc(nextDateTime) / 1000;
        }

        public static long GetNextZeroDateTime() {
            DateTime zeroDateTime = DateTime.Now.Date;
            zeroDateTime=zeroDateTime.AddDays(1);
            return ConvertDateTimeToUtc(zeroDateTime)/1000; 
        }
        public static DateTime GetNextDateTime()
        {
            DateTime zeroDateTime = DateTime.Now.Date;
            zeroDateTime =zeroDateTime.AddDays(1);
            return zeroDateTime;
        }

        //public static long GetNowDateTime()
        //{
        //    return ConvertDateTimeToUtc(DateTime.Now.Date) / 1000; ;//.Ticks;
        //}

        public static string ConvertDate(double allseconds,string format=null)
        {
            return ConvertDate((int)allseconds, format);
        }
        public static string ConvertDate(float allseconds, string format = null)
        {
            return ConvertDate((int)allseconds, format);
        }
        public static string ConvertDate(int allseconds, string format = null)
        {
            if (allseconds >= 3600 * 24)
            {
                if (format == null)
                {
                    return string.Format("{0}:{1}:{2}", (allseconds / 3600).ToString(), ((allseconds % 3600) / 60).ToString("00"), (allseconds % 60).ToString("00"));
                }
                return string.Format(format, (allseconds / 3600 / 24).ToString(), ((allseconds / 3600) % 24).ToString(), ((allseconds % 3600) / 60).ToString("00"), (allseconds % 60).ToString("00"));
            }
            else if (allseconds >= 3600)
            {
                return string.Format("{0}:{1}:{2}", (allseconds / 3600).ToString(), ((allseconds % 3600) / 60).ToString("00"), (allseconds % 60).ToString("00"));
            }
            else
            {
                return string.Format("{0}:{1}", (allseconds / 60).ToString(), (allseconds % 60).ToString("00"));
            }
        }


        /// <summary>
        /// ��ȡ�������
        /// </summary>
        /// <param name="startTimer"></param>
        /// <param name="endTimer"></param>
        /// <returns></returns>
        public static int GetSubSeconds(DateTime startTimer, DateTime endTimer)
        {
            TimeSpan startSpan = new TimeSpan(startTimer.Ticks);

            TimeSpan nowSpan = new TimeSpan(endTimer.Ticks);

            TimeSpan subTimer = nowSpan.Subtract(startSpan).Duration();

            //���ؼ�������������ķ��Ӻ�Сʱ�ȣ�������������֮��Ĳ
            //return subTimer.Seconds;

            //�������ʱ�������Ϸ֡�ʱ�Ĳ�ֵ������������������
            return (int)subTimer.TotalSeconds;
        }

        /// <summary>
        /// ��ȡ����ʱ��������ٷ���
        /// </summary>
        /// <param name="startTimer"></param>
        /// <param name="endTimer"></param>
        /// <returns></returns>
        public static int GetSubMinutes(DateTime startTimer, DateTime endTimer)
        {
            TimeSpan startSpan = new TimeSpan(startTimer.Ticks);

            TimeSpan nowSpan = new TimeSpan(endTimer.Ticks);

            TimeSpan subTimer = nowSpan.Subtract(startSpan).Duration();

           // �������ʱ�������������ķ�������
        //return subTimer.Minutes;
        //�������ʱ���������������ܷ�������
        return (int)subTimer.TotalMinutes;
        }


        /// <summary>
        /// ��ȡ����ʱ���������Сʱ
        /// </summary>
        /// <param name="startTimer"></param>
        /// <param name="endTimer"></param>
        /// <returns></returns>
        public static int GetSubHours(DateTime startTimer, DateTime endTimer)
        {
            TimeSpan startSpan = new TimeSpan(startTimer.Ticks);

            TimeSpan nowSpan = new TimeSpan(endTimer.Ticks);

            TimeSpan subTimer = nowSpan.Subtract(startSpan).Duration();

            //�������ʱ��������������Сʱ��
            //return subTimer.Hours;
            //�������ʱ��������������Сʱ����
            return (int)subTimer.TotalHours;
        }

        /// <summary>
        /// ��ȡ����ʱ�����������
        /// </summary>
        /// <param name="startTimer"></param>
        /// <param name="endTimer"></param>
        /// <returns></returns>
        public static int GetSubDays(DateTime startTimer, DateTime endTimer)
        {
            TimeSpan startSpan = new TimeSpan(startTimer.Ticks);

            TimeSpan nowSpan = new TimeSpan(endTimer.Ticks);

            TimeSpan subTimer = nowSpan.Subtract(startSpan).Duration();

            //�������ʱ��������������������
            //return subTimer.Days;
            //�������ʱ��������������������
            return (int)subTimer.TotalDays;
        }
        //test
        //public static void ConvertServerUtcToDateTime10(long _utcTime, int x)
        //{
        //    DateTime dt = TimeZoneInfo.ConvertTimeToUtc(new DateTime(1970, 1, 1, 0, 0, 0, 0));
        //    TimeSpan toNow = new TimeSpan(_utcTime * x);
        //    Debug.Log(dt.Add(toNow));
        //}
    }
