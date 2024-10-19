using System;

public class DateTimeTool
    {
        static int lingshi_zone = -99;//ֻ�в���ָ��ʱ��ʱ�Ų���-99
        /// <summary>
        /// ���ص�ǰʱ��
        /// </summary>
        /// <param name="lingshi_zone">��ָ������ʱ�����ô��룬ָ��ʱ����Ҫ����-12��12 </param>
        /// <returns></returns>
        public static DateTime GetNowDateTime() {
            if (lingshi_zone == -99)
            {
                return DateTime.Now;
            }
            int curZone = TimeZoneInfo.Local.BaseUtcOffset.Hours;
            if (curZone > 12) {
                curZone = 12;
            }
            int willAdd = lingshi_zone - curZone;
            DateTime result = DateTime.Now.AddHours(willAdd);
            return result;
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
    }
