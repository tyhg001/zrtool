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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //帐号和密码都是正确的
            if (CheckEmpty())
            {
                //帐号和密码都不为空
                UserInfoBLL bll = new UserInfoBLL();
                string msg;
                if (bll.GetUserInfoByLoginUserNameAndPwd(txtName.Text, txtPwd.Text, out msg))
                {
                    msgDiv1.MsgDivShow(msg, 1, Bind);
                }
                else
                {
                    msgDiv1.MsgDivShow(msg, 1);
                }
            }
            // 
        }
        void Bind()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;//设置当前窗体的对话框结果
        }
        private bool CheckEmpty()
        {
            if (string.IsNullOrEmpty(txtName.Text))//帐号为空
            {
                msgDiv1.MsgDivShow("帐号不能为空", 1);
                return false;
            }
            if (string.IsNullOrEmpty(txtPwd.Text))//密码为空
            {
                msgDiv1.MsgDivShow("密码不能为空", 1);
                return false;
            }
            return true;
        }
    }
}
