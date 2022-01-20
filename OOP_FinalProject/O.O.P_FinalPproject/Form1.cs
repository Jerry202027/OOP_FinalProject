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
            if (txt_photoName.Text == "")
            {
                MessageBox.Show("Please enter the employee ID.");
                return;
            }

            else if (txt_bodyTemp.Text == "")
            {
                MessageBox.Show("Please enter the body temprature.");
            }

            else
            {
                SaveEmployeeIDandBodyTemp();
                SaveCapturedImg();
                FindPic();
            }
        }

        private void FindPic()
        {
            string targetPath = "";
            bool hasMask = false;
            //string pathWithMask = @"C:\Users\Asus\Desktop\OOP_FinalProject\output\WithMask\" + txt_photoName.Text + ".jpg";
            string pathWithMask = @"C:\Users\Asus\Desktop\OOP_FinalProject\output\WithMask\";
            string pathWithoutMask = @"C:\Users\Asus\Desktop\OOP_FinalProject\output\WithoutMask\";
            string[] targetPicWithMask = Directory.GetFiles(pathWithMask, "*.jpg");
            string[] targetPicWithoutMask = Directory.GetFiles(pathWithoutMask, "*.jpg");
            //string[] targetPicWithMask = pathWithMask.GetFileNameWithoutExtension("*.jpg");
            //string[] targetPicWithoutMask = pathWithoutMask.GetFileNameWithoutExtension("*.jpg");

            for (int i = 0; i < targetPicWithMask.Length; i++)
            {
                string targetPicID = targetPicWithMask[i].Substring(targetPicWithMask[i].LastIndexOf('\\') + 1);
                string[] fileID = targetPicID.Split('_');
                屋if (fileID[0] == txt_photoName.Text)
                {
                    targetPath = targetPicWithMask[i];
                    hasMask = true;
                    SetResultForm(targetPath, hasMask);
                    return;
                }
            }

            for (int i = 0; i < targetPicWithoutMask.Length; i++)
            {
                string targetPicID = targetPicWithoutMask[i].Substring(targetPicWithoutMask[i].LastIndexOf('\\') + 1);
                string[] fileID = targetPicID.Split('_');
                if (fileID[0] == txt_photoName.Text)
                {
                    targetPath = targetPicWithoutMask[i];
                    hasMask = false;
                    SetResultForm(targetPath, hasMask);
                    return;
                }
            }

           
        }

        private void SetResultForm(string targetPath, bool hasMask)
        {
            try
            {
                Form2 resultInfoForm = new Form2(txt_photoName.Text, txt_bodyTemp.Text, targetPath, hasMask);
                resultInfoForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SaveCapturedImg()
        {
                string path = @"C:\Users\Asus\Desktop\OOP_FinalProject\input\CapturedPhoto";
                try
                {
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    else
                    {

                        string targetPath = path + @"\" + txt_photoName.Text + ".jpg";
                        capturePic.Image.Save(targetPath, ImageFormat.Jpeg);
                        if (File.Exists(targetPath))
                        {
                            MessageBox.Show("Processing....");
                            var t = Task.Run(async delegate
                            {
                                await Task.Delay(5000);
                                return;
                            });
                            t.Wait();
                    }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void SaveEmployeeIDandBodyTemp()
        {
            string path = @"C:\Users\Asus\Desktop\OOP_FinalProject\input\EmployeeInfo";
            StreamWriter sw = new StreamWriter(path + ".txt");
            sw.WriteLine("Employee ID: " + txt_photoName.Text + ", " + "Body Temperature: " + txt_bodyTemp.Text);
            sw.Flush();
            sw.Close();
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
