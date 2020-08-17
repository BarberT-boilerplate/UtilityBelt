using System.Xml;

namespace UtilityBeltCore
{
    public static class XMLNodeHelper
    {
        public static string GetStringValue(XmlDocument _doc, string _xPath)
        {
            XmlNode node = _doc.SelectSingleNode(_xPath);

            if (node == null)
            {
                return null;
            }
            return node.InnerText;
        }
        public static decimal GetDecimalValue(XmlDocument _doc, string _xPath)
        {
            XmlNode node = _doc.SelectSingleNode(_xPath);

            if (node == null)
            {
                return 0.0M;
            }
            string sTemp = (node.InnerText ?? "");
            decimal dRet = 0.0M;
            decimal.TryParse(sTemp, out dRet);

            return dRet;
        }
        public static int GetIntValue(XmlDocument _doc, string _xPath)
        {
            XmlNode node = _doc.SelectSingleNode(_xPath);

            if (node == null)
            {
                return 0;
            }
            string sTemp = (node.InnerText ?? "");
            int iRet = 0;
            int.TryParse(sTemp, out iRet);

            return iRet;
        }
        public static int GetIntValue(XmlNode _node, string _xPath)
        {
            XmlNode node = _node.SelectSingleNode(_xPath);

            if (node == null)
            {
                return 0;
            }
            string sTemp = (node.InnerText ?? "");
            int iRet = 0;
            int.TryParse(sTemp, out iRet);

            return iRet;
        }
    }
}
