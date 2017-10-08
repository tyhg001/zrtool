using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZrTool.Model;
using System.Data;
using System.Data.SQLite;

namespace ZrTool.DAL
{
    public class KdDAL
    {
        public List<KdFiled> GetFiled()
        {
            string sql = "select * from kdkm";
            DataTable dt = SqliteHelper.ExecuteTable(sql);
            List<KdFiled> list = new List<KdFiled>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(RowToField(dr));
                }
            }
            return list;
        }

        public int DeleteInfoById(string kdid)
        {
            string sql = "DELETE FROM kdkm WHERE kdid=" + "'"+ kdid + "'";
            return SqliteHelper.ExecuteNonQuery(sql);
        }

        public int UpdateInfo(KdFiled ct)
        {
            string sql = "update kdkm set kdName=@kdName,department=@department where kdid=@kdid";
            return AddAndUpdateInfo(ct, sql);
        }

        public int AddInfo(KdFiled ct)
        {
            string sql = "insert into kdkm(kdid,kdName,department) values(@kdid,@kdName,@department)";
            return AddAndUpdateInfo(ct, sql);
        }

        private int AddAndUpdateInfo(KdFiled ct, string sql)
        {
            SQLiteParameter[] ps = {
                  new SQLiteParameter("@kdid",ct.kdid),
                   new SQLiteParameter("@kdName",ct.kdName),
                    new SQLiteParameter("@department",ct.department)
                                  };

            List<SQLiteParameter> list = new List<SQLiteParameter>();
            list.AddRange(ps);
            return SqliteHelper.ExecuteNonQuery(sql, list.ToArray());
        }

        public KdFiled GetInfoById(string kdid)
        {
            string sql = "select * from kdkm where kdid=" + "'"+kdid+"'";
            DataTable dt = SqliteHelper.ExecuteTable(sql);
            KdFiled ct = null;
            if (dt.Rows.Count > 0)
            {
                ct = RowToField(dt.Rows[0]);
            }
            return ct;
        }

        private KdFiled RowToField(DataRow dr)
        {
            KdFiled ct = new KdFiled();
            ct.kdid = dr["kdid"].ToString();
            ct.kdName = dr["kdName"].ToString();
            ct.department = dr["department"].ToString();
            return ct;
        }
    }
}
