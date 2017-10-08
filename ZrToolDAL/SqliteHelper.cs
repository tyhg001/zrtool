using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Configuration;


namespace ZrTool.DAL
{
    public class SqliteHelper
    {
        //获取连接字符串

        private static readonly string str = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        /// <summary>
        /// 做增删改的功能
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="ps">sql语句中的参数</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] ps)
        {
            //连接数据库
            using (SQLiteConnection con = new SQLiteConnection(str))
            {

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {

                    con.Open();//打开数据库
                    if (ps != null)
                    {
                        cmd.Parameters.AddRange(ps);//参数
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 首行首列
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="ps">sql语句中的参数</param>
        /// <returns>返回的是首行首列</returns>
        public static object ExecuteScalar(string sql, params SQLiteParameter[] ps)
        {
            using (SQLiteConnection con = new SQLiteConnection(str))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    con.Open();
                    if (ps != null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }
        /// <summary>
        /// 查询的
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="ps">sql语句中的参数</param>
        /// <returns>返回的是SqliteDataReader</returns>
        public static SQLiteDataReader ExecuteReader(string sql, params SQLiteParameter[] ps)
        {
            SQLiteConnection con = new SQLiteConnection(str);
            using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
            {
                if (ps != null)
                {
                    cmd.Parameters.AddRange(ps);
                }
                try
                {
                    con.Open();
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (Exception ex)
                {
                    con.Close();
                    con.Dispose();
                    throw ex;
                }
            }
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="ps">sql语句中的参数</param>
        /// <returns>返回表</returns>
        public static DataTable ExecuteTable(string sql, params SQLiteParameter[] ps)
        {
            DataTable dt = new DataTable();
            using (SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, str))
            {
                if (ps != null)
                {
                    sda.SelectCommand.Parameters.AddRange(ps);
                }
                sda.Fill(dt);
                return dt;
            }
        }
    }
}
