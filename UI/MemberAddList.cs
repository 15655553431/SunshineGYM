using Bll;
using Model;
using AForge;
using AForge.Controls;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Formats;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace UI
{
    public partial class MemberAddList : Form
    {
        private MemberAddList()
        {
            InitializeComponent();
        }

        private static MemberAddList mil;
        public static MemberAddList Create()
        {
            if (mil == null || mil.IsDisposed)
            {
                mil = new MemberAddList();
            }
            return mil;
        }

        MemberInfo mi = new MemberInfo();
        private void MemberAddList_Load(object sender, EventArgs e)
        {
            LoadList();
            LoadTypeList();
            rbm.Checked = true;
            dtp1.Enabled = false;
            dtp2.Enabled = false;

            try
            {
                // 枚举所有视频输入设备
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                foreach (FilterInfo device in videoDevices)
                {
                    txtCamera.Items.Add(device.Name);
                }

                txtCamera.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                txtCamera.Items.Add("No local capture devices");
                videoDevices = null;
            }

        }

        private void LoadList()
        {
            
            mi.MName = txtName.Text;
            mi.MPhone = txtPhone.Text;
            mi.MCId = txtCId.Text;     
            mi.MAdress = txtAdress.Text;
            mi.MTypeId = Convert.ToInt32(txtType.SelectedValue);
            if (rbm.Checked)
            {
                mi.MSex = "男";
            }
            else
            {
                mi.MSex = "女";
            }
            if (string.IsNullOrEmpty(txtbz.Text))
            {
                mi.MBZ = "无";
            }
            else
            {
                mi.MBZ = txtbz.Text;
            }
            
            dtp1.Value = DateTime.Now;

            
            
        }

        private void LoadTypeList()
        {
            //获取会员卡分类对象，查询会员卡分类信息
            MemberCTypeInfoBll mtiBll = new MemberCTypeInfoBll();
            List<MemberCTypeInfo> list = mtiBll.GetList(0);
            //将会员卡信息绑定到控件上
            txtType.DisplayMember = "MCType";//显示的属性（看见的）
            txtType.ValueMember = "MCId";     //用于存储值的属性
            txtType.DataSource = list;
        }

        DateTime temp;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            mi.MStartDate = DateTime.Now;
            mi.MEndDate = temp;
            mi.MDate = DateTime.Now;
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(txtType.Text) && !string.IsNullOrEmpty(txtAdress.Text) && !string.IsNullOrEmpty(txtCId.Text))
            {
                if (txtPhone.Text.Length == 11)
                {
                    if (pictureBox1.Image != null)
                    {
                        MemberInfoBll miBll = new MemberInfoBll();
                        DialogResult result = MessageBox.Show("用户信息核对完成，是否要注册？", "提示", MessageBoxButtons.OKCancel);
                        LoadList();
                        if (result == DialogResult.OK)
                        {
                            string fileName = "photo" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-ff") + ".jpg";
                            mbitmap.Save(@"..\\img\\" + fileName, ImageFormat.Jpeg);
                            string path = "..\\img\\" + fileName;
                            mi.MPhoto = path;
                            mbitmap.Dispose(); 
                            if (miBll.Add(mi))
                            {
                                MessageBox.Show("注册成功");
                                btnCancel_Click(null,null);
                            }
                        }
                     }
                    else
                    {
                        MessageBox.Show("您还没有拍照");
                    }
                }
                else
                {
                    MessageBox.Show("手机号填写错误！");
                }
            }
            else 
            {
                MessageBox.Show("请将信息填写完整！");
            }
        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MemberCTypeInfoBll mtiBll = new MemberCTypeInfoBll();
            int idtemp = Convert.ToInt32(txtType.SelectedValue);
            var listdays = mtiBll.GetList(idtemp);
            int days = Convert.ToInt32(listdays[0].MCDay);

            if (listdays.Count == 1)
            {
                
                dtp2.Value = DateTime.Now.AddDays(days);
            }
            temp = dtp2.Value;
        }


        //定义全局变量
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        //public int selectedDeviceIndex = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "打开摄像头")
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);               
                videoSource = new VideoCaptureDevice(videoDevices[txtCamera.SelectedIndex].MonikerString);//连接摄像头 
                
                //videoSource.VideoResolution = videoSource.VideoCapabilities[txtCamera.SelectedIndex];
                vspMember.VideoSource = videoSource;
                // set NewFrame event handler
                vspMember.Start();
                button1.Text = "关闭摄像头";
            }
            else
            {
                vspMember.SignalToStop();
                vspMember.WaitForStop();
                button1.Text = "打开摄像头";
            }
        }

        Bitmap mbitmap;
        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "关闭摄像头")
            {
                if (videoSource == null)
                    return;
                mbitmap = vspMember.GetCurrentVideoFrame();

                pictureBox1.Image = System.Drawing.Image.FromHbitmap(mbitmap.GetHbitmap()); ;

                //pictureBox1.Image = System.Drawing.Image.FromFile(path);
            }
            else
            {
                button1_Click(null,null);
            }

        }

        private void MemberAddList_FormClosing(object sender, FormClosingEventArgs e)
        {
            vspMember.SignalToStop();
            vspMember.WaitForStop();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            txtName.Text = "";
            txtCId.Text = "";
            txtPhone.Text = "";
            dtp1.Value = DateTime.Now;
            txtType.SelectedIndex = 0;
            txtbz.Text = "";
            txtAdress.Text = "";
            
           

        }

       

    
      
    }
}
