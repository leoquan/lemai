using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Common.Language
{
    public class Language
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
    public class LanguageManager
    {
        //XElement doc;
        XmlDocument doc;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lang"></param>
        public LanguageManager()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Language\\" + PBean.LANGUAGE + ".xml";
            if (!File.Exists(path))
            {
                try
                {
                    using (StreamWriter st = new StreamWriter(path))
                    {
                        st.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                        st.WriteLine("<root>");
                        st.WriteLine("</root>");
                    }
                }
                catch
                {
                    throw;
                }
            }
            // Load xml
            doc = new XmlDocument();
            doc.Load(path);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetResourceString(string name)
        {
            List<string> ls = new List<string>();
            try
            {
                
                XmlNodeList list = doc.SelectNodes("root")[0].ChildNodes;
                foreach (XmlNode node in list)
                {
                    string nodeString = node.Attributes["name"].Value.ToString();
                    ls.Add(nodeString);
                    if (name == nodeString)
                    {
                        name = node.InnerText;
                        break;
                    }
                }
                string sq = ls.Count.ToString();
                return name;
            }
            catch
            {
                return name;
            }
        }
        public List<Language> GetResourceStringList(string name)
        {
            List<Language> ls = new List<Language>();
            try
            {
                XmlNodeList list = doc.SelectNodes("root")[0].ChildNodes;
                foreach (XmlNode node in list)
                {
                    if (node.Attributes["name"].Value.ToString().Contains(name))
                    {
                        Language l = new Language();
                        l.ID = node.Attributes["name"].Value.ToString();
                        l.Name = node.InnerText;
                        ls.Add(l);
                    }
                }
                return ls;
            }
            catch
            {
                return ls;
            }
        }
        public List<Language> GetLanguage()
        {
            List<Language> ls = new List<Language>();
            Language l = new Language();
            l.ID = "en-US";
            l.Name = "English";
            ls.Add(l);
            l = new Language();
            l.ID = "vi-VN";
            l.Name = "Việt Nam";
            ls.Add(l);
            l = new Language();
            l.ID = "ko-KR";
            l.Name = "Korean";
            ls.Add(l);
            return ls;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetResourceStringEmpty(string name)
        {
            try
            {
                XmlNodeList list = doc.SelectNodes("root")[0].ChildNodes;
                bool found = false;
                foreach (XmlNode node in list)
                {
                    if (name == node.Attributes["name"].Value.ToString())
                    {
                        name = node.InnerText;
                        found = true;
                        break;
                    }
                }
                if (found)
                    return name;
                else
                    return string.Empty;
            }
            catch
            {
                return string.Empty;
            }

        }
    }
}
