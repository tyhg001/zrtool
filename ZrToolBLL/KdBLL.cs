using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZrTool.Model;
using ZrTool.DAL;

namespace ZrTool.BLL
{
    public class KdBLL
    {
        KdDAL dal = new KdDAL();
        public List<KdFiled> GetFiled()
        {
            return dal.GetFiled();
        }

        public object GetInfoById(string kdid)
        {
            return dal.GetInfoById(kdid);
        }

        public bool DeleteInfoById(string kdid)
        {
            return dal.DeleteInfoById(kdid) > 0;
        }

        public bool SaveInfo(KdFiled ct, int temp)
        {
            int r = -1;
            if (temp == 1)
            {
                r = dal.AddInfo(ct);
            }
            else if (temp == 2)
            {
                r = dal.UpdateInfo(ct);
            }
            return r > 0;
        }
    }
}
