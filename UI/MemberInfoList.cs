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
    public partial class MemberInfoList : Form
    {
        public MemberInfoList()
        {
            InitializeComponent();
        }
        //通过指定的方式来创建窗体对象
        private static MemberInfoList mil;
        public static MemberInfoList Create()
        {
            //判断是否存在
            if (mil == null || mil.IsDisposed)
            {
                //新建
                mil = new MemberInfoList();
            }
            //返回对象
            return mil;
        }

        MemberInfoBll miBll = new MemberInfoBll();

        private void LoadList()
        {
            MemberInfo mi = new MemberInfo();
            mi.MName = txtMName1.Text;
            mi.MPhone = txtMPhone1.Text;
            mi.MCId = txtCId.Text;             

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = miBll.GetList(mi);
        }

        private void MemberInfoList_Load(object sender, EventArgs e)
        {
            LoadList();
            //comboBox1.Text = comboBox1.Items[0].ToString(); 
            comboBox1.SelectedIndex = 0;
 
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            if (rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    int id = int.Parse(rows[0].Cells[0].Value.ToString());
                    if (miBll.Remove(id))
                    {
                      
                        LoadList();
                    }
                    else
                    {
                        MessageBox.Show("删除失败，请稍后重试");
                    }
                }
            }
            else
            {
                MessageBox.Show("修改失败，请稍后重试");
            }
        }


        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    MemberInfo mi = new MemberInfo();
        //    mi.MName = txtMName2.Text;
        //    mi.MPhone = txtMPhone2.Text;
        //    mi.MTypeId = Convert.ToInt32(txtMType.SelectedValue);
        //    mi.MCId = txtMCId.Text;
        //    mi.MStartDate = DateTime.Now;
        //   // mi.MEndDate = DateTime.Now.AddDays();

        //    if (btnAdd.Text.Equals("添加"))
        //    {
        //        if (miBll.Add(mi))
        //        {
        //            LoadList();
        //        }
        //        else
        //        {
        //            MessageBox.Show("添加失败,请稍后重试");
        //        }
        //    }
        //    else
        //    {
        //        mi.MId = Convert.ToInt32(txtMId.Text);
        //        if (miBll.Edit(mi))
        //        {
        //            btnQuit_Click(null, null);
        //            LoadList();
        //        }
        //        else
        //        {
        //            MessageBox.Show("修改失败，请稍后重试");
        //        }
        //    }
        //var row = dataGridView1.Rows[e.RowIndex];
        //txtMId.Text = row.Cells[0].Value.ToString();
        //txtMName2.Text = row.Cells[1].Value.ToString();
        //txtMPhone2.Text = row.Cells[4].Value.ToString();
        //txtMCId.Text = row.Cells[2].Value.ToString();
        //btnAdd.Text = "修改";

        //}

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string mcid = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                MemberDatilList mdiList = new MemberDatilList();
                mdiList.UpdateTypeEvent += UpdateType;
                mdiList.Tag = mcid;
                mdiList.Show();
            }
            catch { }
        }

        private void UpdateType()
        {
            LoadList();
        }
 
        //条件查询事件
        private void txtMName1_TextChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void txtMPhone1_TextChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void txtCId_TextChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            txtMName1.Text = "";
            txtMPhone1.Text = "";
            txtCId.Text = "";

            LoadList();
        }

        int mid = 0;
        private void btnReplace_Click(object sender, EventArgs e)
        {
            MemberInfo mi = new MemberInfo();
            mi.MCId = txtNewCId.Text;

            var rows = dataGridView1.SelectedRows;          

            if (rows.Count > 0)
            {               
                mid = int.Parse(rows[0].Cells[0].Value.ToString());
                mi.MId = mid;
                if (!string.IsNullOrEmpty(txtNewCId.Text))
                {
                    if (miBll.UpdateNewCId(mi))
                    {
                        LoadList();
                        txtNewCId.Text = "";
                        MessageBox.Show("补办成功");
                    }
                }
                else
                {
                    MessageBox.Show("请输入新卡号！");
                }
            }
        }
    
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            string mcid = rows[0].Cells[2].Value.ToString();
            MemberDatilList DatilList = new MemberDatilList();
            DatilList.Tag = mcid;
            DatilList.Show();
                      
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MemberInfo mi = new MemberInfo();
            mi.MTag = comboBox1.SelectedIndex;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = miBll.GetList(mi);
        }

                        
    }
}
