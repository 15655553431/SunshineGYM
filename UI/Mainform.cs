using Bll;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Properties;

namespace UI
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void menuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void menuMember_Click(object sender, EventArgs e)
        {
            MemberInfoList miList = MemberInfoList.Create();
            miList.Show();
            miList.Focus();
        }


        private void menuManager_Click(object sender, EventArgs e)
        {
            MemberAddList miList = MemberAddList.Create();
            miList.Show();
            miList.Focus();
        }

        private void qtmanager_Click(object sender, EventArgs e)
        {
            ManagerInfoList miList = ManagerInfoList.Create();
            miList.Show();
            miList.Focus();
        }

        private void mtype_Click(object sender, EventArgs e)
        {
            MemberCTypeInfoList miList = MemberCTypeInfoList.Create();
            miList.Show();
            miList.Focus();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            ManagerInfo mi = new ManagerInfo();
            mi.MType = Convert.ToInt32(Tag);
            if (mi.MType == 1)
            {
                menuboss.Visible = true;
            }
            else
            {
                menuboss.Visible = false;
            }

            txtName.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtCount.ReadOnly = true;
            txtCId.ReadOnly = false;
            dtp2.Enabled = false;
            dtp3.Enabled = false;
        }

        private void LoadPhoto()
        {
            MemberInfoBll miBll = new MemberInfoBll();
            MemberInfo mi = new MemberInfo();
            mi.MName = txtName.Text;
            mi.MCId = txtCId.Text;
            mi.MPhone = txtPhone.Text;
            var list = miBll.GetList(mi);
            if (list.Count == 1)
            {
                
                txtName.ReadOnly = true;
                txtPhone.ReadOnly = true;
                txtCId.ReadOnly = true;
                txtName.Text = list[0].MName;
                txtPhone.Text = list[0].MPhone;
                txtCId.Text = list[0].MCId;
                txtCount.Text = Convert.ToString(list[0].MCount);
                dtp2.Value = list[0].MEndDate;
                dtp3.Value = list[0].MDate;
                txtType.Text = list[0].TypeTitle;
                txtCBZ.Text = list[0].TypeBz;
                TimeSpan temsub = DateTime.Now.Subtract(Convert.ToDateTime(list[0].MEndDate));
                string subdays = Math.Abs(Convert.ToInt32(temsub.Days)).ToString();
                string lblstr = "";
                
                if (DateTime.Now > Convert.ToDateTime(list[0].MEndDate))
                {
                    lblstr += list[0].MName.ToString() + "您好,对不起！您的会员卡已经过期：" + subdays + "天！";
                    lblred.ForeColor = Color.Red;
                }
                else
                {
                    lblstr += list[0].MName.ToString() + "您好,欢迎您！您的会员卡还剩余：" + subdays + "天！";
                    lblred.ForeColor = Color.Black;
                }
                lblred.Text = lblstr;
                var path = list[0].MPhoto;
                if (!string.IsNullOrEmpty(path))
                {
                    pictureBox1.Image = Image.FromFile(path);
                }
                else
                {
                    MessageBox.Show("显示错误或没有照片");
                }

            }
        }
       
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.ReadOnly == false)
            {
                LoadPhoto();
            }
        }

        private void txtCId_TextChanged(object sender, EventArgs e)
        {
            if (txtName.ReadOnly == false)
            {
                LoadPhoto();
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtName.ReadOnly == false)
            {
                LoadPhoto();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblred.ForeColor != Color.Red)
            {
                if (txtName.ReadOnly == true)
                {
                    MemberInfoBll miBll = new MemberInfoBll();
                    MemberInfo mi = new MemberInfo();
                    mi.MCId = txtCId.Text;
                    miBll.UpdateCount(mi);
                    txtName.Text = "";
                    txtPhone.Text = "";
                    txtCId.Text = "";
                    txtCount.Text = "";
                    txtCBZ.Text = "";
                    txtType.Text = "";
                    txtName.ReadOnly = false;
                    txtPhone.ReadOnly = false;
                    txtCId.ReadOnly = false;

                    pictureBox1.Image = Resources.psb;
                    lblred.Text = "等待检测中";
                    lblred.ForeColor = Color.Black;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("该会员已经到期，确认通过吗？", "会员到期提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    if (txtName.ReadOnly == true)
                    {
                        MemberInfoBll miBll = new MemberInfoBll();
                        MemberInfo mi = new MemberInfo();
                        mi.MCId = txtCId.Text;
                        miBll.UpdateCount(mi);
                        txtName.Text = "";
                        txtPhone.Text = "";
                        txtCId.Text = "";
                        txtCount.Text = "";
                        txtCBZ.Text = "";
                        txtType.Text = "";

                        txtName.ReadOnly = false;
                        txtPhone.ReadOnly = false;
                        txtCId.ReadOnly = false;

                        pictureBox1.Image = Resources.psb;
                        lblred.Text = "等待检测中";
                        lblred.ForeColor = Color.Black;
                    }
                }
                else
                {
                    if (txtName.ReadOnly == true)
                    {
                        txtName.Text = "";
                        txtPhone.Text = "";
                        txtCId.Text = "";
                        txtCount.Text = "";
                        txtCBZ.Text = "";
                        txtType.Text = "";

                        txtName.ReadOnly = false;
                        txtPhone.ReadOnly = false;
                        txtCId.ReadOnly = false;

                        pictureBox1.Image = Resources.psb;
                        lblred.Text = "等待检测中";
                        lblred.ForeColor = Color.Black;
                    }
                }
            }
            txtCId.Select();
        }

        private void Mainform_SizeChanged(object sender, EventArgs e)
        {
            if (this.ClientSize.Width > (gbmember.Width + 20) && this.ClientSize.Height > (gbmember.Height + 110))
            {
                int cx = gbf.ClientSize.Width / 2;
                int cy = gbf.ClientSize.Height / 2;
                int x = cx - gbmember.Width / 2;
                int y = cy - gbmember.Height / 2;
                gbmember.Location = new Point(x,y);
            }
        }

        private void txtCId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtName.ReadOnly == true)
                {
                    button1.Select();
                }
            }
        }






    }
}
