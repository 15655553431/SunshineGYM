using Bll;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ManagerLoad : Form
    {
        public ManagerLoad()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                ManagerInfo mi = new ManagerInfo();
                mi.MName = txtUser.Text;
                mi.MPwd = txtPwd.Text;

                ManagerInfoBll miBll = new ManagerInfoBll();
                if (miBll.Load(mi))
                {
                    string overdatestr = ConfigurationManager.ConnectionStrings["date"].ConnectionString;
                    DateTime overdate = Convert.ToDateTime(overdatestr);
                    if (DateTime.Now.Date < overdate.Date)
                    {
                        Mainform mainform = new Mainform();
                        mainform.Tag = mi.MType;
                        mainform.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("系统文件缺失，请联系开发人员QQ：1517680389");
                    }
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                }
            }
            catch
            {
                MessageBox.Show("数据库连接错误，请联系小雨QQ：1517680389");
            }

            
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLoad_Click(null,null);
            }
        }

    }
}
