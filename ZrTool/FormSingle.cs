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

namespace ZrTool
{
    public partial class FormSingle : Form
    {
        public FormSingle()
        {
            InitializeComponent();
        }

        private void btnCFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (txtCFile.Text == "")
                    txtCFile.Text = openFileDialog.FileName;
                else
                    txtCFile.Text += "," + openFileDialog.FileName;
            }
        }

        private void btnCPath_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtCPath.Text = saveFileDialog.FileName;
            }
        }

        private void btnCombin_Click(object sender, EventArgs e)
        {
            TransferBLL bll = new TransferBLL();
            try
            {
                    bll.transfer(txtCFile.Text, txtCPath.Text);                
            }
            catch { }
        }
    }
}
