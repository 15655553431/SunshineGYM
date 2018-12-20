using Bll;
using Model;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ManagerInfoList : Form
    {
        private ManagerInfoList()
        {
            InitializeComponent();
        }
        private static ManagerInfoList mil;
        public static ManagerInfoList Create()
        {
            if (mil == null || mil.IsDisposed)
            { 
                mil = new ManagerInfoList();
            }
            return mil;
        }

        ManagerInfoBll miBll = new ManagerInfoBll();

        private void ManagerInfoList_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = miBll.GetList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                switch(e.Value.ToString())
                {
                    case "1":
                        e.Value = "经理";
                        break;
                    case "0":
                        e.Value = "店员";
                        break;
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            txtMId.Text = "添加时无编号";
            txtMName.Text = "";
            txtMPwd.Text = "";
            radioButton2.Checked = true;
            btnAdd.Text = "添加";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ManagerInfo mi = new ManagerInfo() 
            {
                MName = txtMName.Text,
                MPwd = txtMPwd.Text,
                MType = radioButton1.Checked ? 1 : 0
            };
            if(btnAdd.Text == "添加")
            {
                if(miBll.Add(mi))
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
                mi.MId = Convert.ToInt32(txtMId.Text);
                if (miBll.Update(mi))
                {
                    btnQuit_Click(null, null);
                    LoadList();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            txtMId.Text = row.Cells[0].Value.ToString();
            txtMName.Text = row.Cells[1].Value.ToString();
            txtMPwd.Text = "******";
            if (row.Cells[2].Value.ToString() == "1")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            btnAdd.Text = "修改";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var rows = dataGridView1.SelectedRows;

            if (rows.Count > 0)
            {
                DialogResult reslut = MessageBox.Show("确定要删除吗？","提示",MessageBoxButtons.OKCancel);
                if (reslut == DialogResult.OK)
                {
                    int id = Convert.ToInt32(rows[0].Cells[0].Value);
                    if(miBll.Remove(id))
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
        }

        private void btnxls_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("点击【确定】将把所有会员信息导出为xls表格！", "会员信息导出提示！", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                #region 弹出保存窗口对话框，选择保存路径，创建工作本
                /*******************************************************/
                /*******************************************************/
                /*******************************************************/
                //弹出保存对话框
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "请选择要保存的路径，默认为桌面";
                sfd.InitialDirectory = @"C:\Users\Administrator\Desktop";
                sfd.Filter = "xls表格文件|*.xls|所有文件|*.*";
                sfd.ShowDialog();
                //获得保存文件的路径
                string path = sfd.FileName;
                if (path == "")//打开了对话框，但是没有选择地址
                {
                    return;
                }
                //创建工作本
                HSSFWorkbook workbook = new HSSFWorkbook();
                //如果用户选择了保存路径，则开始进行保存操作
                #endregion

                #region 表格样式操作

                //导出：将数据库中的数据，存储到一个excel中
                //2、生成excel
                //生成workbook
                //生成sheet
                //遍历集合，生成行。（一个对象就是一行）
                //根据对象生成单元格，一个属性对应一个单元格


                //样式表
                /*****************************************************************************/
                /******************表格样式操作*********************************************/
                /*****************************************************************************/
                /************/
                //表头标题样式操作（水平垂直居中，黄色背景，字体颜色黑色，微软雅黑加粗，字体大小18）
                /*************/
                var styleTitle = workbook.CreateCellStyle();
                //style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;//左对齐  
                //style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Right;//右对齐  
                styleTitle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;//居中  
                //垂直居中
                styleTitle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                //
                //字体样式设置
                HSSFFont fontTitle = (HSSFFont)workbook.CreateFont();
                fontTitle.FontName = "微软雅黑";//字体  
                fontTitle.FontHeightInPoints = 18;//字号  
                fontTitle.Color = HSSFColor.Red.Index; //颜色 红色
                fontTitle.IsBold = true;//加粗  
                // font.Underline = NPOI.SS.UserModel.FontUnderlineType.Double;//下划线  
                // font.IsStrikeout = true;//删除线  
                // font.IsItalic = true;//斜体  

                //将字体样式加入表头样式中
                styleTitle.SetFont(fontTitle);

                //背景色设置
                //styleTitle.FillBackgroundColor = HSSFColor.Yellow.Index;//背景色  
                styleTitle.FillForegroundColor = HSSFColor.Yellow.Index;//前景色  
                styleTitle.FillPattern = NPOI.SS.UserModel.FillPattern.SolidForeground;//填充方式 AltBars


                /****************/
                //表格列头样式操作
                /****************/
                //表格列头样式操作（水平垂直居中，蓝色背景，字体颜色白色，黑体，字体大小16）
                var styleHeader = workbook.CreateCellStyle();
                styleHeader.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;//水平居中  
                styleHeader.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;//垂直居中  
                styleHeader.FillForegroundColor = HSSFColor.Blue.Index;//前景色  
                styleHeader.FillPattern = NPOI.SS.UserModel.FillPattern.SolidForeground;//填充方式 AltBars
                HSSFFont fontHeader = (HSSFFont)workbook.CreateFont();
                fontHeader.FontName = "黑体";//字体  
                fontHeader.FontHeightInPoints = 12;//字号  
                fontHeader.Color = HSSFColor.White.Index; //颜色 
                fontHeader.IsBold = true;//加粗  
                styleHeader.SetFont(fontHeader);
                /*****************/
                /****************/


                /*****************/
                //*表脚样式*//
                /*****************/
                var styleFoot = workbook.CreateCellStyle();
                styleFoot.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;//水平居中  
                styleFoot.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;//垂直居中  
                styleFoot.FillForegroundColor = HSSFColor.Blue.Index;//前景色  
                styleFoot.FillPattern = NPOI.SS.UserModel.FillPattern.SolidForeground;//填充方式 AltBars
                HSSFFont fontFoot = (HSSFFont)workbook.CreateFont();
                fontFoot.FontName = "黑体";//字体  
                fontFoot.FontHeightInPoints = 10;//字号  
                fontFoot.Color = HSSFColor.White.Index; //颜色 
                fontFoot.IsBold = true;//加粗  
                styleFoot.SetFont(fontFoot);
                /*****************/
                /****************/

                /*****************/
                //*表格正文样式*//
                /*****************/
                var styleBody = workbook.CreateCellStyle();
                styleBody.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;//水平居中  
                styleBody.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;//垂直居中                      
                HSSFFont fontBody = (HSSFFont)workbook.CreateFont();
                fontBody.FontName = "宋体";//字体  
                fontBody.FontHeightInPoints = 12;//字号  
                fontBody.Color = HSSFColor.Black.Index; //颜色 
                fontBody.IsBold = true;//加粗  
                styleBody.SetFont(fontBody);
                /*****************/
                /****************/

                /******************************************************************************/
                /***************************表格样式操作***************************************/
                /*****************************************************************************/
                #endregion

                #region 会员信息存储
                /***********************创建工作表，在一个工作本里面可以有多张表*************************/
                /******************************************************************************************************************************************/
                /******************************************************************************************************************************************/
                /******************************************************************************************************************************************/
                //1、查询数据
                //保存人员信息表
                MemberInfoBll miBll = new MemberInfoBll();
                MemberInfo mi = new MemberInfo();
                var listmiInfo = miBll.GetList(mi);


                //创建工作表
                //NPOI.SS.UserModel.ISheet sheet = workbook.CreateSheet("管理员");
                ISheet sheet = workbook.CreateSheet("会员信息表");


                //创建标题行
                IRow row = sheet.CreateRow(0);
                //合并单元格
                sheet.AddMergedRegion(new CellRangeAddress(0, 0, 0, 11));
                ICell cellTitle = row.CreateCell(0);
                cellTitle.SetCellValue("阳光力美健身中心会员信息表");
                row.HeightInPoints = 45;//表头标题行高
                //应用样式
                cellTitle.CellStyle = styleTitle;



                //创建列名称
                IRow row1 = sheet.CreateRow(1);
                row1.HeightInPoints = 20;//表列头行高
                //创建单元格
                //设置名称
                //应用样式
                //设置列的宽度
                //SetColumnWidth（）方法有两个参数，第一个是列的索引，从0开始。注意第二个参数，是以1/256为单位。
                ICell cellId = row1.CreateCell(0);
                cellId.SetCellValue("编号");
                cellId.CellStyle = styleHeader;
                sheet.SetColumnWidth(0, 8 * 256);

                ICell cellName = row1.CreateCell(1);
                cellName.SetCellValue("姓名");
                cellName.CellStyle = styleHeader;
                sheet.SetColumnWidth(1, 10 * 256);

                ICell cellNumber = row1.CreateCell(2);
                cellNumber.SetCellValue("性别");
                cellNumber.CellStyle = styleHeader;
                sheet.SetColumnWidth(2, 6 * 256);

                ICell cellDepartment = row1.CreateCell(3);
                cellDepartment.SetCellValue("卡号");
                cellDepartment.CellStyle = styleHeader;
                sheet.SetColumnWidth(3, 12 * 256);

                ICell cellDuty = row1.CreateCell(4);
                cellDuty.SetCellValue("类型");
                cellDuty.CellStyle = styleHeader;
                sheet.SetColumnWidth(4, 10 * 256);

                ICell cellPhone = row1.CreateCell(5);
                cellPhone.SetCellValue("联系方式");
                cellPhone.CellStyle = styleHeader;
                sheet.SetColumnWidth(5, 16 * 256);

                ICell cellQQ = row1.CreateCell(6);
                cellQQ.SetCellValue("会员住址");
                cellQQ.CellStyle = styleHeader;
                sheet.SetColumnWidth(6, 18 * 256);

                ICell cellPAdd = row1.CreateCell(7);
                cellPAdd.SetCellValue("锻炼次数");
                cellPAdd.CellStyle = styleHeader;
                sheet.SetColumnWidth(7, 12 * 256);

                ICell cellJoinTime = row1.CreateCell(8);
                cellJoinTime.SetCellValue("最近锻炼时间");
                cellJoinTime.CellStyle = styleHeader;
                sheet.SetColumnWidth(8, 20 * 256);

                ICell cellLeaveTime = row1.CreateCell(9);
                cellLeaveTime.SetCellValue("办卡时间");
                cellLeaveTime.CellStyle = styleHeader;
                sheet.SetColumnWidth(9, 20 * 256);

                ICell cellendTime = row1.CreateCell(10);
                cellendTime.SetCellValue("截止时间");
                cellendTime.CellStyle = styleHeader;
                sheet.SetColumnWidth(10, 20 * 256);

                ICell cellbz = row1.CreateCell(11);
                cellbz.SetCellValue("备注");
                cellbz.CellStyle = styleHeader;
                sheet.SetColumnWidth(11, 20 * 256);


                //遍历集合，生成行
                int index = 2;//索引，0,1是表头。所以从2开始。
                foreach (var item in listmiInfo)
                {
                    //创建下面每行单元格的值
                    var row2 = sheet.CreateRow(index++);

                    var cell0 = row2.CreateCell(0);
                    cell0.SetCellValue(item.MId.ToString());
                    cell0.CellStyle = styleBody;

                    var cell1 = row2.CreateCell(1);
                    cell1.SetCellValue(item.MName);

                    var cell2 = row2.CreateCell(2);
                    cell2.SetCellValue(item.MSex);

                    var cell3 = row2.CreateCell(3);
                    cell3.SetCellValue(item.MCId);

                    var cell4 = row2.CreateCell(4);
                    cell4.SetCellValue(item.TypeTitle);

                    var cell5 = row2.CreateCell(5);
                    cell5.SetCellValue(item.MPhone);

                    var cell6 = row2.CreateCell(6);
                    cell6.SetCellValue(item.MAdress);

                    var cell7 = row2.CreateCell(7);
                    cell7.SetCellValue(item.MCount.ToString());

                    var cell8 = row2.CreateCell(8);
                    cell8.SetCellValue(item.MDate.ToString());

                    var cell9 = row2.CreateCell(9);
                    cell9.SetCellValue(item.MStartDate.ToString());

                    var cell10 = row2.CreateCell(10);
                    cell10.SetCellValue(item.MEndDate.ToString());

                    var cell11 = row2.CreateCell(11);
                    cell11.SetCellValue(item.MBZ);

                }

                /**表页脚**/
                //创建标题行
                IRow row3 = sheet.CreateRow(index);
                //合并单元格
                sheet.AddMergedRegion(new CellRangeAddress(index, index, 0, 11));
                ICell cellFoot = row3.CreateCell(0);
                cellFoot.SetCellValue("欢迎使用！如有建议或需求反馈可以联系梦雨客服（小雨）QQ:1517680389");
                row3.HeightInPoints = 22;//表头标题行高
                //应用样式
                cellFoot.CellStyle = styleFoot;
                /**********/

                /*********************************************/
                /**************会员信息表*********************/
                /*********************************************/
                #endregion


                #region 写入文件保存
                //是否成功标志
                bool flag = false;
                try
                {
                    FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
                    workbook.Write(file);
                    file.Dispose();//使用完要释放资源，或者使用using（）{}
                    flag = true;
                }
                catch
                {
                    MessageBox.Show("保存出错！\n请关闭其他xls文件，再重试！");
                    flag = false;
                }
                /*******************************************************/
                if (flag)
                {
                    //操作完成，导出成功提示
                    MessageBox.Show("数据导出成功！导出路径如下：\n" + path + "\n敬请及时查收！");
                }
                #endregion

            }
        }

      
    }
}
