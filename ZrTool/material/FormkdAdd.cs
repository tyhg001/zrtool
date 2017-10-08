using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZrTool.Model;
using ZrTool.BLL;

namespace ZrTool
{
    public partial class FormkdAdd : Form
{
     KdBLL bll = new KdBLL();
        public FormkdAdd()
    {
      InitializeComponent();
    }

        private int TP { get; set; }

        internal void SetTxt(object sender, EventArgs e)
        {
            FrmEventArgs fea = e as FrmEventArgs;
            this.TP = fea.Temp;//标识
            if (this.TP == 1)//新增
            {

            }
            else if (this.TP == 2)//修改
            {
                KdFiled ct = fea.Obj as KdFiled;
                txid.Text = ct.kdid;
                txname.Text = ct.kdName;
                txdp.Text = ct.department;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                KdFiled ct = new KdFiled();
                ct.kdid = txid.Text;//编号
                ct.kdName = txname.Text;//名称
                ct.department = txdp.Text;//部门

                string msg = bll.SaveInfo(ct, this.TP) ? "操作成功" : "操作失败";
                MessageBox.Show(msg);
                this.Close();
            }
        }

        private bool Check()
        {
            if (string.IsNullOrEmpty(txid.Text))
            {
                MessageBox.Show("科目代码不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(txname.Text))
            {
                MessageBox.Show("科目名称不能为空");
                return false;
            }
            return true;
        }
    }
}
