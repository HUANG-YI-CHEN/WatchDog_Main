using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace WatchDog.Lib
{
    public static class XmlUtil
    {
        #region Serialize
        public static void SerializeToXml(string fileName, object obj)
        {
            Stream stream = null;
            StreamWriter writer = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(obj.GetType());
                stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read);
                writer = new StreamWriter(stream, Encoding.UTF8);
                xml.Serialize(writer, obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (stream != null && writer != null)
                {
                    writer.Close();
                    stream.Close();
                    writer.Dispose();
                    stream.Dispose();
                }
            }
        }
        #endregion

        #region Deserialize
        public static T DeserializeFromXml<T>(string FileName)
        {
            Stream stream = null;
            StreamReader reader = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                stream = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                reader = new StreamReader(stream, Encoding.UTF8);
                object obj = xml.Deserialize(reader);
                return (T)obj;
            }
            catch
            {
                return default;
            }
            finally
            {
                if (stream != null && reader != null)
                {
                    reader.Close();
                    stream.Close();
                    reader.Dispose();
                    stream.Dispose();
                }
            }
        }
        #endregion

        #region ConvertToDataTable
        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
        #endregion

        #region ConvertToList
        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
        #endregion
    }
}
