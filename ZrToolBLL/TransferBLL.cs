using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZrTool.DAL;


namespace ZrTool.BLL
{
    public class TransferBLL
    {
        public void transfer(string inpath, string outpath)
        {
            TransferDAL dal = new TransferDAL();
            dal.transfer(inpath, outpath);
           
        }
    }
}
