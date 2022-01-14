using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarrenLee.Media;
using System.IO;
using System.Drawing.Imaging;

namespace O.O.P_FinalPproject
{
    public partial class Form1 : Form
    {
        Camera DetectingCamera = new Camera();
        public Form1()
        {
            InitializeComponent();

            GetInfo();
            DetectingCamera.OnFrameArrived += DetectingCameraOnFramedArrived;
        }

        private void DetectingCameraOnFramedArrived(object source, FrameArrivedEventArgs e)
        {
            Image img = e.GetFrame();
            capturePic.Image = img;
        }

        private void GetInfo()
        {
            var cameraDevices = DetectingCamera.GetCameraSources();
            var cameraResolution = DetectingCamera.GetSupportedResolutions();

            foreach (var ele in cameraDevices)
            {
                cbox_device.Items.Add(ele);
            }

            cbox_device.SelectedIndex = 0;

            foreach (var ele in cameraResolution)
            {
                cbox_resolution.Items.Add(ele);
            }

            cbox_resolution.SelectedIndex = 0;  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(@"C:\Users\user\Desktop\Wei\隨班附讀\OOP_師大吳順德\O.O.P_project\CaptruedPhoto"))
                    Directory.CreateDirectory(@"C:\Users\user\Desktop\Wei\隨班附讀\OOP_師大吳順德\O.O.P_project\CaptruedPhoto");
                else
                {
                    string path = @"C:\Users\user\Desktop\Wei\隨班附讀\OOP_師大吳順德\O.O.P_project\CaptruedPhoto";
                    capturePic.Image.Save(path + @"\" + txt_photoName.Text + ".jpg", ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbox_device_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectingCamera.ChangeCamera(cbox_device.SelectedIndex);
        }

        private void cbox_resolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetectingCamera.Start(cbox_resolution.SelectedIndex);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DetectingCamera.Stop();
        }
    }
}
