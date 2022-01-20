using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace O.O.P_FinalPproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string id, string bodyTemp, string targetPath, bool hasMask)
        {
            InitializeComponent();
            SetResultPic(id, targetPath);
            SetLabelText(id, bodyTemp, hasMask);
        }

        private void SetLabelText(string id, string bodyTemp, bool hasMask)
        {
            lbl_employeeID.Text = "ID: " + id;

            if (int.Parse(bodyTemp) >= 38)
            {
                lbl_bodyTemp.Text = "體溫異常";
                lbl_bodyTemp.ForeColor = Color.Red;
            }
            else
                lbl_bodyTemp.Text = "體溫正常";

            if (!hasMask)
            {
                lbl_hasMask.Text = "未戴口罩";
                lbl_hasMask.ForeColor = Color.Red;
            }
            else
                lbl_hasMask.Text = "有戴口罩";
        }

        private void SetResultPic(string id, string targetPath)
        {
            //string pathWithMask = @"C:\Users\Asus\Desktop\OOP_FinalProject\output\WithMask\" + id + ".jpg";
            //string pathWithoutMask = @"C:\Users\Asus\Desktop\OOP_FinalProject\output\WithoutMask\" + id + ".jpg";

            /*string pathWithMask = @"C:\Users\Asus\Desktop\OOP_FinalProject\output\WithMask";
            string pathWithoutMask = @"C:\Users\Asus\Desktop\OOP_FinalProject\output\WithoutMask";

            string[] targetPicWithMask = Directory.GetFiles(pathWithMask, id + "*");
            string[] targetPicWithoutMask = Directory.GetFiles(pathWithoutMask, id + "*");


            if (hasMask)
            {
                if (!File.Exists(targetPicWithMask[0]))
                {
                    MessageBox.Show("Model prediction failed.");
                    return;
                }
                    
                resultPic.Image = Image.FromFile(targetPicWithMask[0]);
            }
                
            else
            {
                if (!File.Exists(targetPicWithoutMask[0]))
                {
                    MessageBox.Show("Model prediction failed.");
                    return;
                }
                    
                resultPic.Image = Image.FromFile(targetPicWithoutMask[0]);
            }*/
            resultPic.Image = Image.FromFile(targetPath);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (resultPic.Image != null)
            {
                resultPic.Image.Dispose();
                resultPic.Image = null;
            }
        }
    }
}
