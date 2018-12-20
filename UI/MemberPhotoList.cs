using AForge;
using AForge.Controls;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Formats;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Video.FFMPEG;
using Bll;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MemberPhotoList : Form
    {
        public MemberPhotoList()
        {
            InitializeComponent();
        }

        private static MemberPhotoList mil;
        public static MemberPhotoList Create()
        {
            //判断是否存在
            if (mil == null || mil.IsDisposed)
            {
                //新建
                mil = new MemberPhotoList();
            }
            //返回对象
            return mil;
        }

        //定义全局变量
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;

        int mid = 0;
        private void MemberPhotoList_Load(object sender, EventArgs e)
        {
            string mcid = Convert.ToString(Tag);
            MemberInfo miSreach = new MemberInfo();
            miSreach.MCId = mcid;

            MemberInfoBll miBll = new MemberInfoBll();
            var list = miBll.GetList(miSreach);
            if (list.Count == 1)
            {
                mid = list[0].MId;
                var path = list[0].MPhoto;
                if (!string.IsNullOrEmpty(path))
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(path);
                }
            }
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

                pictureBox1.Image = System.Drawing.Image.FromHbitmap(mbitmap.GetHbitmap());

                //pictureBox1.Image = System.Drawing.Image.FromFile(path);
            }
            else
            {
                button1_Click(null, null);
            }
        }

        private void MemberPhotoList_FormClosing(object sender, FormClosingEventArgs e)
        {
            vspMember.SignalToStop();
            vspMember.WaitForStop();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                MemberInfo mi = new MemberInfo();
                MemberInfoBll miBll = new MemberInfoBll();
                DialogResult result = MessageBox.Show("用户照片将进行修改，是否继续？", "提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string fileName = "photo" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-ff") + ".jpg";
                    mbitmap.Save(@"..\\img\\" + fileName, ImageFormat.Jpeg);
                    string path = "..\\img\\" + fileName;
                    mi.MPhoto = path;
                    mi.MId = mid;
                    mbitmap.Dispose();
                    if (miBll.UpdatePhoto(mi))
                    {
                        UpdataPhotoEvent();
                        this.Close();                      
                    }
                }
            }
            else
            {
                MessageBox.Show("您还没有拍照");
            }
        }
        public event Action UpdataPhotoEvent;


    }
}
