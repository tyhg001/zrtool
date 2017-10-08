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
    public partial class Formkd : Form
{

        KdBLL bll = new KdBLL();
    public Formkd()
    {
        InitializeComponent();
    }

    private void Formkd_Load(object sender, EventArgs e)
    {
            Loadtree();
            Loadmydata();

    }

    private void Loadtree()
        {

        }

    private void Loadmydata()
        {
           dgv.AutoGenerateColumns = false;//禁止自动生成列
           dgv.DataSource = bll.GetFiled();
            if (dgv.Rows.Count > 0)
            {
                dgv.SelectedRows[0].Selected = false;//禁止默认第一行选中
            }
        }

        public event EventHandler evtFcp;//产品增加或修改的事件
        FrmEventArgs fea = new FrmEventArgs();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadFrmChange(1);
        }

        private void LoadFrmChange(int p)
        {
            FormkdAdd fcp = new FormkdAdd();
            this.evtFcp += new EventHandler(fcp.SetTxt);//注册新增或修改的产品的窗体的传值事件
            //此处的fea对象在新增或修改==类别的上面声明的,===
            fea.Temp = p;//存储标识,1表示新增产品信息,2---表示修改产品信息
            if (this.evtFcp != null)//事件不能为空
            {
                this.evtFcp(this, fea);//执行事件
                fcp.FormClosed += new FormClosedEventHandler(fcp_FormClosed);//关闭后刷新
                fcp.ShowDialog();//显示窗体
            }
        }

        private void fcp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Loadmydata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                //获取选中的行的id
                string kdid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                //存对象
                fea.Obj = bll.GetInfoById(kdid);//判断不是null再赋值
                LoadFrmChange(2);
            }
            else
            {
                MessageBox.Show("请选中要修改的行");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                string kdid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string msg = bll.DeleteInfoById(kdid) ? "操作成功" : "操作失败";
                MessageBox.Show(msg);
                //刷新
                Loadmydata();
            }
            else
            {
                MessageBox.Show("请选中要删除的数据");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

