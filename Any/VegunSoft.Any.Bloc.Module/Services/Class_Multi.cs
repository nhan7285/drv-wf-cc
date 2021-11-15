using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace VegunSoft.Layer.UcService.Provider.Any
{
    public class Multi
    {
        public string ReadLine(string path)
        {
            string line = "";
            using (StreamReader sr = new StreamReader(path))
            {
                line = sr.ReadLine();
            }
            return line;
        }
        public void WriteLine(string text, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Flush();
                sw.WriteLine(text);
            }
        }

        //
        public string ReadLineFrom64bit(string path)
        {
            string line = "";
            using (StreamReader sr = new StreamReader(path))
            {
                line = sr.ReadLine();
            }
            return Base64ToString(line);
        }

        public void WriteLineTo64bit(string text, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Flush();
                sw.WriteLine(StringToBase64(text));
            }
        }

        public string ReadMultiLine(string path)
        {
            string line = "";
            using (StreamReader sr = new StreamReader(path))
            {
                line = sr.ReadToEnd();
            }
            return line;
        }

        public void WriteMultiLine(string[] text, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Flush();
                foreach (string line in text)
                    sw.WriteLine(line.ToString());

            }
        }

        //Convert String
        // Mã hóa Base64 với chuỗi Unicode.
        public string StringToBase64(string src)
        {
            // Chuyển chuỗi thành mảng kiểu byte.
            byte[] b = Encoding.Unicode.GetBytes(src);
            // Trả về chuỗi được mã hóa theo Base64.
            return Convert.ToBase64String(b);
        }

        // Giải mã một chuỗi Unicode được mã hóa theo Base64.
        public string Base64ToString(string src)
        {
            // Giải mã vào mảng kiểu byte.
            byte[] b = Convert.FromBase64String(src);
            // Trả về chuỗi Unicode.
            return Encoding.Unicode.GetString(b);
        }

        /// <summary>
        /// Chuyển chuổi Xml sang định dạng đối tượng XmlDocument
        /// </summary>
        /// <param name="pObj">Đối tượng cần chuyển đổi sang XmlDocument</param>
        /// <returns>Đối tượng trả về XmlDocument</returns>
        public XmlDocument ConvertModelToXML(object pObj)
        {
            XmlDocument xlmDocument = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(pObj.GetType());
            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, pObj);
                xmlStream.Position = 0;
                xlmDocument.Load(xmlStream);
                return xlmDocument;
            }
        }

        /// <summary>
        /// Chuyển chuổi Xml sang định dạng String Xml
        /// </summary>
        /// <param name="pObj">Đối tượng cần chuyển đổi sang XmlDocument</param>
        /// <param name="pRootName">Tên node root xml</param>
        /// <returns>Đối tượng trả về dạng String Xml</returns>
        public string ConvertModelToXML(object pObj, string pRootName)
        {
            XmlDocument xlmDocument = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(pObj.GetType());
            string strResult = "";
            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, pObj);
                xmlStream.Position = 0;
                xlmDocument.Load(xmlStream);
                // return xlmDocument.DocumentElement.InnerXml;
                strResult = xlmDocument.DocumentElement.InnerXml;
            }

            if ((pRootName == null) || (pRootName.Equals("")))
            {
                strResult = "<Root>" + strResult + "</Root>";
            }
            else
            {
                strResult = "<" + pRootName.Trim() + ">" + strResult + "</" + pRootName.Trim() + ">";
            }
            return strResult;
        }

        /// <summary>
        /// Chuyển chuổi Xml sang dạng đôi tượng
        /// </summary>
        /// <typeparam name="T">Đối tượng cần chuyển đổi sang</typeparam>
        /// <param name="pXml">Chuổi Xml</param>
        /// <returns>Trả về đối tượng</returns>
        public T ConvertXMLToModel<T>(string pXml)
        {
            T ObjectT = (T)Activator.CreateInstance<T>();
            StringReader stringReader = new StringReader(pXml);
            DataSet ds = new DataSet();
            ds.ReadXml(stringReader);
            DataTable dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            foreach (DataColumn col in dt.Columns)
            {
                PropertyInfo proInfo = ObjectT.GetType().GetProperty(col.ColumnName.Trim());
                if(proInfo != null)
                    proInfo.SetValue(ObjectT, Convert.ChangeType(row[col.ColumnName].ToString().Trim(), proInfo.PropertyType), null);
            }
            return ObjectT;
        }

        /// <summary>
        /// Convert Xmldocument sang Model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmldoc"></param>
        /// <returns></returns>
        public T ConvertXMLToModel<T>(XmlDocument xmldoc)
        {
            string pXml = "<Root>" + xmldoc.DocumentElement.InnerXml + "</Root>";
            T ObjectT = (T)Activator.CreateInstance<T>();
            StringReader stringReader = new StringReader(pXml);
            DataSet ds = new DataSet();
            ds.ReadXml(stringReader);
            DataTable dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            foreach (DataColumn col in dt.Columns)
            {
                PropertyInfo proInfo = ObjectT.GetType().GetProperty(col.ColumnName.Trim());
                if (proInfo != null)
                    proInfo.SetValue(ObjectT, Convert.ChangeType(row[col.ColumnName].ToString().Trim(), proInfo.PropertyType), null);
            }
            return ObjectT;
        }
        /// <summary>
        /// Chuyển chuổi Xml sang dạng đôi List tượng
        /// </summary>
        /// <typeparam name="T">Đối tượng cần chuyển đổi sang</typeparam>
        /// <param name="pXml">Chuổi Xml</param>
        /// <returns>Trả về một List đối tương</returns>
        public List<T> ConvertXMLToListModel<T>(string pXml)
        {
            StringReader stringReader = new StringReader(pXml);
            DataSet ds = new DataSet();
            ds.ReadXml(stringReader);
            DataTable dt = ds.Tables[0];
            List<T> listUser = new List<T>();

            foreach (DataRow row in dt.Rows)
            {
                T ObjectT = (T)Activator.CreateInstance<T>();
                foreach (DataColumn col in dt.Columns)
                {
                    PropertyInfo proInfo = ObjectT.GetType().GetProperty(col.ColumnName.Trim());
                    if (proInfo != null)
                        proInfo.SetValue(ObjectT, Convert.ChangeType(row[col.ColumnName].ToString().Trim(), proInfo.PropertyType), null);
                }
                listUser.Add(ObjectT);
            }
            return listUser;
        }

        /// <summary>
        /// Convert Xmldocument sang List Model 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmldoc"></param>
        /// <returns></returns>
        public List<T> ConvertXMLToListModel<T>(XmlDocument xmldoc)
        {
            string pXml = "<Root>" + xmldoc.DocumentElement.InnerXml + "</Root>";
            StringReader stringReader = new StringReader(pXml);
            DataSet ds = new DataSet();
            ds.ReadXml(stringReader);
            DataTable dt = ds.Tables[0];
            List<T> listUser = new List<T>();

            foreach (DataRow row in dt.Rows)
            {
                T ObjectT = (T)Activator.CreateInstance<T>();
                foreach (DataColumn col in dt.Columns)
                {
                    PropertyInfo proInfo = ObjectT.GetType().GetProperty(col.ColumnName.Trim());
                    if (proInfo != null)
                        proInfo.SetValue(ObjectT, Convert.ChangeType(row[col.ColumnName].ToString().Trim(), proInfo.PropertyType), null);
                }
                listUser.Add(ObjectT);
            }
            return listUser;
        }
   
        /// <summary>
        /// Lấy một đối tượng bất kỳ của danh sách theo từ khóa(key) và giá trị(value)
        /// </summary>
        /// <typeparam name="T">Kiểu đối tượng</typeparam>
        /// <param name="pList">Danh sách đối tượng</param>
        /// <param name="pKey">Từ khóa(key)</param>
        /// <param name="pValue">Giá trị(value)</param>
        /// <returns>Object đối tượng</returns>
        public T GetObjectByKey<T>(List<T> pList, string pKey, object pValue)
        {
            T ObjectT = pList.Where<T>(a => a.GetType().GetProperty(pKey).GetValue(a, null).Equals(pValue)).Single<T>();
            return ObjectT;
        }

        /// <summary>
        /// Xóa đối tượng danh sách
        /// </summary>
        /// <typeparam name="T">Kiểu đối tượng</typeparam>
        /// <param name="pList">Danh sách đối tượng</param>
        /// <param name="pObj">Object đối tượng</param>
        /// <returns>Trả về một List đối tương</returns>
        public List<T> DeleteObject<T>(List<T> pList, T pObj)
        {
            int intIndex = pList.IndexOf(pObj);
            pList.RemoveAt(intIndex);
            return pList;
        }

      
    }
}
