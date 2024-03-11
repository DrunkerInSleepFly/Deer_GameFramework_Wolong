// ================================================
//描 述:
//作 者:
//创建时间:2023年6月1日
//修改作者:Wyp
//修改时间:2023年6月1日
//版 本:0.1 
// ===============================================
using GameFramework.Localization;
using System;
using System.Xml;
using UnityGameFramework.Runtime;

namespace ExtendGameFramework.Runtime
{
    /// <summary>
    /// XML 格式的本地化辅助器。
    /// </summary>
    public class XmlLocalizationHelper : DefaultLocalizationHelper
    {
        /// <summary>
        /// 解析字典。
        /// 读取模版XmlDictionary
        /// </summary>
        /// <param name="dictionaryString">要解析的字典字符串。</param>
        /// <param name="userData">用户自定义数据。</param>
        /// <returns>是否解析字典成功。</returns>
        public override bool ParseData(ILocalizationManager localizationManager, string dictionaryString, object userData)
        {
            try
            {
                string currentLanguage = GameEntryMain.Localization.Language.ToString();
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(dictionaryString);
                XmlNode xmlRoot = xmlDocument.SelectSingleNode("Dictionary");
                XmlNodeList xmlNodeStringList = xmlRoot.ChildNodes;
                for (int j = 0; j < xmlNodeStringList.Count; j++)
                {
                    XmlNode xmlNodeString = xmlNodeStringList.Item(j);
                    if (xmlNodeString.Name != "String")
                    {
                        continue;
                    }

                    string key = xmlNodeString.Attributes.GetNamedItem("Key").Value;
                    string value = xmlNodeString.Attributes.GetNamedItem("Value").Value;

                    UnityEngine.Debug.Log("key_" + key + "??value_" + value);

                    XmlNode colorNode = xmlNodeString.Attributes.GetNamedItem("Color");
                    if (colorNode != null)
                    {
                        value = string.Format("<color=#{0}>{1}</color>", colorNode.Value, value);
                    }
                    if (!localizationManager.AddRawString(key, value))
                    {
                        Log.Warning("Can not add raw string with key '{0}' which may be invalid or duplicate.", key);
                        return false;
                    }
                }

                return true;
            }
            catch (Exception exception)
            {
                Log.Warning("Can not parse dictionary data with exception '{0}'.", exception.ToString());
                return false;
            }
        }
        /*
        /// <summary>
        /// 解析字典。
        /// 读取模版XmlDictionary
        /// </summary>
        /// <param name="dictionaryString">要解析的字典字符串。</param>
        /// <param name="userData">用户自定义数据。</param>
        /// <returns>是否解析字典成功。</returns>
        public override bool ParseData(ILocalizationManager localizationManager, string dictionaryString, object userData)
        {
            try
            {
                string currentLanguage = GameEntryMain.Localization.Language.ToString();
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(dictionaryString);
                XmlNode xmlRoot = xmlDocument.SelectSingleNode("Dictionaries");
                XmlNodeList xmlNodeDictionaryList = xmlRoot.ChildNodes;
                for (int i = 0; i < xmlNodeDictionaryList.Count; i++)
                {
                    XmlNode xmlNodeDictionary = xmlNodeDictionaryList.Item(i);
                    if (xmlNodeDictionary.Name != "Dictionary")
                    {
                        continue;
                    }
                    string language = xmlNodeDictionary.Attributes.GetNamedItem("Language").Value;
                    if (language != currentLanguage)
                    {
                        continue;
                    }

                    XmlNodeList xmlNodeStringList = xmlNodeDictionary.ChildNodes;
                    for (int j = 0; j < xmlNodeStringList.Count; j++)
                    {
                        XmlNode xmlNodeString = xmlNodeStringList.Item(j);
                        if (xmlNodeString.Name != "String")
                        {
                            continue;
                        }

                        string key = xmlNodeString.Attributes.GetNamedItem("Key").Value;
                        string value = xmlNodeString.Attributes.GetNamedItem("Value").Value;

                        UnityEngine.Debug.Log("key_" + key + "??value_" + value);

                        XmlNode colorNode = xmlNodeString.Attributes.GetNamedItem("Color");
                        if (colorNode != null)
                        {
                            value = string.Format("<color=#{0}>{1}</color>", colorNode.Value, value);
                        }
                        if (!localizationManager.AddRawString(key, value))
                        {
                            Log.Warning("Can not add raw string with key '{0}' which may be invalid or duplicate.", key);
                            return false;
                        }
                    }
                }

                return true;
            }
            catch (Exception exception)
            {
                Log.Warning("Can not parse dictionary data with exception '{0}'.", exception.ToString());
                return false;
            }
        }*/
    }
}
