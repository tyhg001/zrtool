using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace ZrTool.DAL
{
    public class TransferDAL
    {
        public void transfer(string inpath, string outpath)
        {
            string filepath = @"E:\ZR\excel\in\业务系统数据.xls";
            ExcelHelper exl = new ExcelHelper(filepath);
            DataTable dt = new DataTable();   
            if(inpath.IndexOf(".csv") > 0)
            {
                dt = CsvHelper.OpenCSV(inpath);
            }
            else
            {
                dt = exl.ExcelToDataTable("Sheet1", true);
            }
            Dictionary<string, Single> dic = new Dictionary<string, Single>();

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                DataRow dr = dt.Rows[i];
                string w = dr["帐项代码"].ToString();
                string sql = "select kdid from tb_xrkm where xrid = '" + w + "'";
                SQLiteDataReader read = SqliteHelper.ExecuteReader(sql);
                //read.Read();
                w = read["kdid"].ToString();
                Single k = Convert.ToSingle(dr["并行价格"]);

                if (!dic.ContainsKey(w))
                {
                    dic.Add(w, 0);
                }
                else
                {
                    dic[w] = dic[w] + k;
                }
            }

            dic.Clear();

        }

    }
}
