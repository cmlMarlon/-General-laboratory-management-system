using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text;
using System.Data;
using MySQLDriverCS;                //网上下载mysql主键
using System.Text.RegularExpressions;
//using System.Data.Odbc;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
//using System.Data.SqlClient;
using System.Threading.Tasks;

/// <summary>
/// MysqlHelper 的摘要说明
/// </summary>
/// 

namespace mysqlHelper
{
    public class MysqlHelper
    {
        /// string sever,string database, string login,string pass,int port
        //public static string my_connectionString ="data source=rdsago67f260cp38q5f9.mysql.rds.aliyuncs.com; port=3306; database=r898dnkttu0rqtm8; username=r898dnkttu0rqtm8; password=czl13699086468; ";
        public static string connectionString = new MySQLConnectionString("rdsago67f260cp38q5f9.mysql.rds.aliyuncs.com", "r898dnkttu0rqtm8", "r898dnkttu0rqtm8", "czl13699086468", 3306).AsString;
        public MysqlHelper()
        {

        }
        //执行SQL语句，返回影响的记录数
        //<param name="sqlString">sql语句</param>
        public static int ExcuteNonQuery(string SQLString)
        {
            using (MySQLConnection connection = new MySQLConnection(connectionString))
            {
                using (MySQLCommand cmd = new MySQLCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (MySQLException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }
        public static int ExecuteNonQuery(string SQLString, params MySQLParameter[] cmdParms)
        {
            using (MySQLConnection connection = new MySQLConnection(connectionString))
            {
                using (MySQLCommand cmd = new MySQLCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        int rows = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch (MySQLException e)
                    {
                        throw e;
                    }
                }
            }
        }


        public static object ExecuteScalar(string SQLString)
        {
            using (MySQLConnection connection = new MySQLConnection(connectionString))
            {
                using (MySQLCommand cmd = new MySQLCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = cmd.ExecuteScalar();
                        if (Object.Equals(obj, null) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (MySQLException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }

        public static object ExecuteScalar(string SQLString, params MySQLParameter[] cmdParms)
        {
            using (MySQLConnection connection = new MySQLConnection(connectionString))
            {
                using (MySQLCommand cmd = new MySQLCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (MySQLException e)
                    {
                        throw e;
                    }
                }
            }
        }

        public static MySQLDataReader ExecuteReader(string strSQL)
        {
            MySQLConnection connection = new MySQLConnection(connectionString);
            MySQLCommand cmd = new MySQLCommand(strSQL, connection);
            MySQLDataReader myReader = null;
            try
            {
                connection.Open();
                myReader = cmd.ExecuteReaderEx();

                return myReader;
            }
            catch (MySQLException e)
            {
                throw e;
            }
            finally
            {
                myReader.Close();
            }
        }

        public static MySQLDataReader ExecuteReader(string SQLString, params MySQLParameter[] cmdParms)
        {
            MySQLConnection connection = new MySQLConnection(connectionString);
            MySQLCommand cmd = new MySQLCommand();
            MySQLDataReader myReader = null;
            try
            {
                PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                myReader = cmd.ExecuteReaderEx();
                cmd.Parameters.Clear();
                return myReader;
            }
            catch (MySQLException e)
            {
                throw e;
            }
            finally
            {
                myReader.Close();
                cmd.Dispose();
                connection.Close();

            }
        }

        public static DataTable ExecuteDataTable(string SQLString)
        {
            using (MySQLConnection connection = new MySQLConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    MySQLDataAdapter command = new MySQLDataAdapter(SQLString, connection);
                    MySQLCommand commn = new MySQLCommand("set names gbk", connection);
                    commn.ExecuteNonQuery();
                    command.Fill(ds, "ds");
                    connection.Close();
                }
                catch (MySQLException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds.Tables[0];
            }
        }

        public static DataTable ExecuteDataTable(string SQLString, params MySQLParameter[] cmdParms)
        {
            using (MySQLConnection connection = new MySQLConnection(connectionString))
            {
                MySQLCommand cmd = new MySQLCommand();
                PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                using (MySQLDataAdapter da = new MySQLDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "ds");
                        cmd.Parameters.Clear();
                    }
                    catch (MySQLException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    return ds.Tables[0];
                }
            }
        }
        //获取起始页码和结束页码  
        public static DataTable ExecuteDataTable(string cmdText, int startResord, int maxRecord)
        {
            using (MySQLConnection connection = new MySQLConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    MySQLDataAdapter command = new MySQLDataAdapter(cmdText, connection);
                    command.Fill(ds, startResord, maxRecord, "ds");
                    connection.Close();
                }
                catch (MySQLException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds.Tables[0];
            }
        }

        public static DataTable getPager(out int recordCount, string selectList, string tableName, string whereStr, string orderExpression, int pageIdex, int pageSize)
        {
            int rows = 0;
            DataTable dt = new DataTable();
            MatchCollection matchs = Regex.Matches(selectList, @"top\s+\d{1,}", RegexOptions.IgnoreCase);//含有top  
            string sqlStr = string.Format("select {0} from {1} where 1=1 {2}", selectList, tableName, whereStr);
            if (!string.IsNullOrEmpty(orderExpression)) { sqlStr += string.Format(" Order by {0}", orderExpression); }
            if (matchs.Count > 0) //含有top的时候  
            {
                DataTable dtTemp = ExecuteDataTable(sqlStr);
                rows = dtTemp.Rows.Count;
            }
            else //不含有top的时候  
            {
                string sqlCount = string.Format("select count(*) from {0} where 1=1 {1} ", tableName, whereStr);
                //获取行数  
                object obj = ExecuteScalar(sqlCount);
                if (obj != null)
                {
                    rows = Convert.ToInt32(obj);
                }
            }
            dt = ExecuteDataTable(sqlStr, (pageIdex - 1) * pageSize, pageSize);
            recordCount = rows;
            return dt;
        }

        private static void PrepareCommand(MySQLCommand cmd, MySQLConnection conn, MySQLTransaction trans, string cmdText, MySQLParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;  
            if (cmdParms != null)
            {
                foreach (MySQLParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                    (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
            conn.Close();
        }

    }
}