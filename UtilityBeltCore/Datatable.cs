using System;
using System.Data;
using System.IO;

namespace UtilityBeltCore
{
    public static class Datatable
    {
        public static int GetInt(DataRow SourceRow, string ColumnName, int IfNull)
        {
            try
            {
                if (SourceRow[ColumnName] == DBNull.Value)
                {
                    return IfNull;
                }
                else
                {
                    return Convert.ToInt32(SourceRow[ColumnName]);
                }
            }
            catch
            {
                return IfNull;
            }
        }
        public static int GetInt(DataRow SourceRow, string ColumnName)
        {
            return GetInt(SourceRow, ColumnName, 0);
        }
        public static decimal GetDecimal(DataRow SourceRow, string ColumnName, decimal IfNull)
        {
            try
            {
                if (SourceRow[ColumnName] == DBNull.Value)
                {
                    return IfNull;
                }
                else
                {
                    return Convert.ToDecimal(SourceRow[ColumnName]);
                }
            }
            catch
            {
                return IfNull;
            }
        }
        public static decimal GetDecimal(DataRow SourceRow, string ColumnName)
        {
            return GetDecimal(SourceRow, ColumnName, 0m);
        }
        public static DateTime GetDate(DataRow SourceRow, string ColumnName, DateTime IfNull)
        {
            try
            {
                if (SourceRow[ColumnName] == DBNull.Value)
                {
                    return IfNull;
                }
                else
                {
                    return Convert.ToDateTime(SourceRow[ColumnName]);
                }
            }
            catch
            {
                return IfNull;
            }
        }
        public static DateTime GetDate(DataRow SourceRow, string ColumnName)
        {
            return GetDate(SourceRow, ColumnName, new DateTime(1900, 1, 1));
        }
        public static string GetString(DataRow SourceRow, string ColumnName)
        {
            return GetString(SourceRow, ColumnName, "");
        }
        public static string GetString(DataRow SourceRow, string ColumnName, string IfNull)
        {
            try
            {
                if (SourceRow[ColumnName] == DBNull.Value)
                {
                    return IfNull;
                }
                else
                {
                    return Convert.ToString(SourceRow[ColumnName]);
                }
            }
            catch
            {
                return IfNull;
            }
        }
        public static int GetUserID(DataRow SourceRow, string ColumnName)
        {
            return GetInt(SourceRow, ColumnName, 0);
        }
        public static bool GetYN(DataRow SourceRow, string ColumnName, bool IfNull)
        {
            try
            {
                if (SourceRow[ColumnName] == DBNull.Value)
                {
                    return IfNull;
                }
                else
                {
                    return Convert.ToString(SourceRow[ColumnName]).Trim().ToUpper() == "Y";
                }
            }
            catch
            {
                return IfNull;
            }
        }
        public static bool GetBit(DataRow SourceRow, string ColumnName, bool IfNull)
        {
            try
            {
                if (SourceRow[ColumnName] == DBNull.Value)
                {
                    return IfNull;
                }
                else
                {
                    return Convert.ToBoolean(SourceRow[ColumnName]);
                }
            }
            catch
            {
                return IfNull;
            }
        }
        public static bool GetActive(DataRow SourceRow, string ColumnName, bool IfNull)
        {
            try
            {
                if (SourceRow[ColumnName] == DBNull.Value)
                {
                    return IfNull;
                }
                else
                {
                    return Convert.ToString(SourceRow[ColumnName]).Trim().ToUpper() == "ACTIVE";
                }
            }
            catch
            {
                return IfNull;
            }
        }
        public static bool GetActive(DataRow SourceRow)
        {
            return GetActive(SourceRow, "status", false);
        }
        public static DataTable ConvertToDataTable(FileInfo File, bool isRowOneHeader)
        {
            DataTable csvDataTable = new DataTable();
            try
            {
                String[] csvData = System.IO.File.ReadAllLines(File.FullName);

                //if no data in file ‘manually’ throw an exception
                if (csvData.Length == 0)
                {
                    string s = "asdfasd";
                    s += "asdfasdf";
                    throw new Exception("CSV File Appears to be Empty");
                }

                String[] headings = csvData[0].Split(',');
                int index = 0; //will be zero or one depending on isRowOneHeader

                if (isRowOneHeader) //if first record lists headers
                {
                    index = 1; //so we won’t take headings as data

                    //for each heading
                    for (int i = 0; i < headings.Length; i++)
                    {
                        //replace spaces with underscores for column names
                        headings[i] = headings[i].Replace(" ", "_");

                        //add a column for each heading
                        csvDataTable.Columns.Add(headings[i], typeof(string));
                    }
                }
                else //if no headers just go for col1, col2 etc.
                {
                    for (int i = 0; i < headings.Length; i++)
                    {
                        //create arbitary column names
                        csvDataTable.Columns.Add("col" + (i + 1).ToString(), typeof(string));
                    }
                }

                //populate the DataTable
                for (int i = index; i < csvData.Length; i++)
                {
                    string RowInfo = csvData[i];
                    if (RowInfo != string.Empty && RowInfo.Length > 1)
                    {
                        //create new rows
                        DataRow row = csvDataTable.NewRow();

                        for (int j = 0; j < headings.Length; j++)
                        {
                            //fill them
                            row[j] = csvData[i].Split(',')[j];
                        }

                        //add rows to over DataTable
                        csvDataTable.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                string ClassName = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName;
                string MethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            }
            //return the CSV DataTable
            return csvDataTable;
        }
    }
}
