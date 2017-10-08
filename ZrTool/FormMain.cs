using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZrTool
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            FormUser fm = new FormUser();
            fm.ShowDialog();
        }

        private void btn_kd_Click(object sender, EventArgs e)
        {
            Formkd kd = new Formkd();
            kd.ShowDialog();
        }

        private void btn_single_Click(object sender, EventArgs e)
        {
            FormSingle kd = new FormSingle();
            kd.ShowDialog();
        }
    }
}
