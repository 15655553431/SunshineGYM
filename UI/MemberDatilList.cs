using Bll;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MemberDatilList : Form
    {
        
        public MemberDatilList()
        {
            
            InitializeComponent();
        }

        int mid = 0;
        MemberInfoBll miBll = new MemberInfoBll();
        private void MemberDatilList_Load(object sender, EventArgs e)
        {
            string mcid = Convert.ToString(Tag);
            LoadList();           

            endtime.Enabled = false;           

            MemberInfo miSreach = new MemberInfo();
            miSreach.MCId = mcid;
            var list = miBll.GetList(miSreach);
            if (list.Count == 1)
            {
                btnUpdate.Text = "修改信息";
                
                txtName.Text = list[0].MName;
                txtPhone.Text = list[0].MPhone;
                txtCId.Text = list[0].MCId;
                txtAdress.Text = list[0].MAdress;
                txtSex.Text = list[0].MSex;
                txtbz.Text = list[0].MBZ;
                txtCount.Text = Convert.ToString(list[0].MCount);
                dtp1.Value = list[0].MStartDate;
                dtp2.Value = list[0].MEndDate;
                dtp3.Value = list[0].MDate;
                mid = list[0].MId;

                txtName.ReadOnly = true;
                txtPhone.ReadOnly = true;
                txtAdress.ReadOnly = true;
                txtCId.ReadOnly = true;
                txtSex.Enabled = false;
                txtCount.ReadOnly = true;
                txtbz.ReadOnly = true;
                dtp1.Enabled = false;
                dtp2.Enabled = false;
                dtp3.Enabled = false;

                var path = list[0].MPhoto;
                if (!string.IsNullOrEmpty(path))
                {
                    pictureBox1.Image = Image.FromFile(path);
                }               

             }
        }


        private void LoadList()
        {
            MemberCTypeInfoBll mtiBll = new MemberCTypeInfoBll();
            List<MemberCTypeInfo> list1 = mtiBll.GetList(0);
            list1.Insert(0, new MemberCTypeInfo()
            {
                MCId = 0,
                MCType = "请选择类型",
            });
            txtxkType.DisplayMember = "MCType";
            txtxkType.ValueMember = "MCId";
            txtxkType.DataSource = list1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "修改信息")
            {
                txtName.ReadOnly = false;
                txtPhone.ReadOnly = false;
                txtAdress.ReadOnly = false;
                txtCId.ReadOnly = false;
                txtCount.ReadOnly = true;
                txtSex.Enabled = true;
                dtp1.Enabled = false;
                dtp2.Enabled = false;
                dtp3.Enabled = false;
                txtbz.ReadOnly = false;
                btnUpdate.Text = "确认修改";
            }
            else
            {
                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtCId.Text) && !string.IsNullOrEmpty(txtAdress.Text) && !string.IsNullOrEmpty(txtbz.Text) && txtPhone.Text.Length == 11)
                {
                    MemberInfo mitemp = new MemberInfo();
                    mitemp.MName = txtName.Text;
                    mitemp.MPhone = txtPhone.Text;
                    mitemp.MCId = txtCId.Text;
                    mitemp.MAdress = txtAdress.Text;
                    mitemp.MSex = txtSex.Text;
                    mitemp.MId = mid;
                    mitemp.MBZ = txtbz.Text;
                    if (miBll.Edit(mitemp))
                    {
                        txtName.ReadOnly = true;
                        txtPhone.ReadOnly = true;
                        txtAdress.ReadOnly = true;
                        txtCId.ReadOnly = true;
                        txtSex.Enabled = false;
                        txtCount.ReadOnly = true;
                        txtbz.ReadOnly = true;
                        dtp1.Enabled = false;
                        dtp2.Enabled = false;
                        dtp3.Enabled = false;
                        btnUpdate.Text = "修改信息";
                        UpdateTypeEvent();
                        MessageBox.Show("修改信息成功");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改信息失败");
                    }
                }
                else
                {
                    MessageBox.Show("修改信息有误！请核查是否有空白和手机号位数！");
                }
            }
        }
        public event Action UpdateTypeEvent;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtxkType.SelectedIndex != 0)
            {
                MemberInfo mitemp = new MemberInfo();
                mitemp.MEndDate = temp1;
                mitemp.MBZ = txtbz.Text;
                mitemp.MSex = txtxkType.Text;
                mitemp.MId = mid;
                if (miBll.UpdateEndtime(mitemp))
                {
                    DialogResult result = MessageBox.Show("续卡成功后日期不能再进行修改，是否继续？", "提示", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        dtp2.Value = temp1;
                        LoadList();
                        endtime.Value = DateTime.Now;
                        MessageBox.Show("续卡成功");
                    }
                }
            }
        }

        DateTime temp1;
        private void txtxkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MemberCTypeInfoBll mtiBll = new MemberCTypeInfoBll();
            int idtemp = Convert.ToInt32(txtxkType.SelectedValue);
            var listdays = mtiBll.GetList(idtemp);
            int days = Convert.ToInt32(listdays[0].MCDay);            

            if (listdays.Count == 1)
            {
                if (dtp2.Value > DateTime.Now)
                {
                    endtime.Value = dtp2.Value.AddDays(days);                   
                }
                else
                {
                    endtime.Value = DateTime.Now.AddDays(days);
                }
            }
            temp1 = endtime.Value;                 
        }


        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            MemberPhotoList mpiList = MemberPhotoList.Create();
            mpiList.UpdataPhotoEvent += UpdataPhoto;
            mpiList.Tag = txtCId.Text;
            mpiList.Show();
            mpiList.Focus();
        }

        private void UpdataPhoto()
        {
            MemberDatilList_Load(null,null);
        }

    
      
    }
}
