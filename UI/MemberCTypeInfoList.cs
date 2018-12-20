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
    public partial class MemberCTypeInfoList : Form
    {
        public MemberCTypeInfoList()
        {
            InitializeComponent();
        }

        private static MemberCTypeInfoList mil;
        public static MemberCTypeInfoList Create()
        {
            //判断是否存在
            if (mil == null || mil.IsDisposed)
            {
                //新建
                mil = new MemberCTypeInfoList();
            }
            //返回对象
            return mil;
        }

        MemberCTypeInfoBll mtiBll = new MemberCTypeInfoBll();

        private void MemberCTypeInfoList_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = mtiBll.GetList(0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MemberCTypeInfo mti = new MemberCTypeInfo() 
            { 
                MCType = txtMCType.Text,
                MCDay = txtDay.Text,
                MCBZ = txtBZ.Text
            };
            if(btnAdd.Text == "添加")
            {
                if(mtiBll.Add(mti))
                {
                    btnQuit_Click(null,null);
                    LoadList();
               
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else
            {
                mti.MCId = Convert.ToInt32(txtMCId.Text);
                if(mtiBll.Update(mti))
                {
                    btnQuit_Click(null, null);
                    LoadList();
                
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            txtMCId.Text = "添加时无编号";
            txtMCType.Text = "";
            txtDay.Text = "";
            txtBZ.Text = "";
            btnAdd.Text = "添加";
        }
      
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取双击的单元格所在的行
            var row = dataGridView1.Rows[e.RowIndex];

            //将行中的数组，显示到控件中
            txtMCId.Text = row.Cells[0].Value.ToString();
            txtMCType.Text = row.Cells[1].Value.ToString();
            txtDay.Text = row.Cells[2].Value.ToString();
            txtBZ.Text = row.Cells[3].Value.ToString();
            btnAdd.Text = "修改";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            if (rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    int id = int.Parse(rows[0].Cells[0].Value.ToString());
                    if (mtiBll.Delete(id))
                    {
                        btnQuit_Click(null, null);
                        LoadList();
                   
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的行");
            }
        }

    }
}
