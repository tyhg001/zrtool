using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZrTool.BLL;
using ZrTool.Model;

namespace ZrTool
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            LoadUserberInfo(0);
        }

        private void LoadUserberInfo(int p)
        {
            //
            UserChangeBll bll = new UserChangeBll();
            dgv.AutoGenerateColumns = false;//禁止自动生成列
            dgv.DataSource = bll.GetAllUserInfoByDelFlag(p);
            if (dgv.Rows.Count > 0)
            {
                //dgv.SelectedRows[0].Selected = false;//第一行不选中
            }
        }

        private void btnAddMemMber_Click(object sender, EventArgs e)
        {
            //LoadFrmChangeMemmber(1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选中要删除的账号");
                return;
            }

            //选中
            string loginName = dgv.SelectedRows[0].Cells[0].Value.ToString();
            UserChangeBll bll = new UserChangeBll();
            string msg = bll.SoftDeleteUserInfoByloginName(loginName) ? "操作成功" : "操作失败";
            LoadUserberInfo(0);//刷新
            MessageBox.Show(msg);
        }
    }
}
