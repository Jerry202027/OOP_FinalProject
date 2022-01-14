namespace O.O.P_FinalPproject
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbox_resolution = new System.Windows.Forms.ComboBox();
            this.cbox_device = new System.Windows.Forms.ComboBox();
            this.txt_photoName = new System.Windows.Forms.TextBox();
            this.capturePic = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capturePic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Photo Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Camera Device";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Camera Resolution";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbox_resolution);
            this.groupBox1.Controls.Add(this.cbox_device);
            this.groupBox1.Controls.Add(this.txt_photoName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(325, 550);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 240);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera Info";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("新細明體", 12F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(113, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Capture";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbox_resolution
            // 
            this.cbox_resolution.FormattingEnabled = true;
            this.cbox_resolution.Location = new System.Drawing.Point(145, 119);
            this.cbox_resolution.Name = "cbox_resolution";
            this.cbox_resolution.Size = new System.Drawing.Size(181, 23);
            this.cbox_resolution.TabIndex = 5;
            this.cbox_resolution.SelectedIndexChanged += new System.EventHandler(this.cbox_resolution_SelectedIndexChanged);
            // 
            // cbox_device
            // 
            this.cbox_device.FormattingEnabled = true;
            this.cbox_device.Location = new System.Drawing.Point(145, 77);
            this.cbox_device.Name = "cbox_device";
            this.cbox_device.Size = new System.Drawing.Size(181, 23);
            this.cbox_device.TabIndex = 4;
            this.cbox_device.SelectedIndexChanged += new System.EventHandler(this.cbox_device_SelectedIndexChanged);
            // 
            // txt_photoName
            // 
            this.txt_photoName.Location = new System.Drawing.Point(145, 34);
            this.txt_photoName.Name = "txt_photoName";
            this.txt_photoName.Size = new System.Drawing.Size(181, 25);
            this.txt_photoName.TabIndex = 3;
            // 
            // capturePic
            // 
            this.capturePic.Location = new System.Drawing.Point(125, 37);
            this.capturePic.Name = "capturePic";
            this.capturePic.Size = new System.Drawing.Size(750, 500);
            this.capturePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capturePic.TabIndex = 4;
            this.capturePic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 803);
            this.Controls.Add(this.capturePic);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Mask Detection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capturePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbox_resolution;
        private System.Windows.Forms.ComboBox cbox_device;
        private System.Windows.Forms.TextBox txt_photoName;
        private System.Windows.Forms.PictureBox capturePic;
        private System.Windows.Forms.Button button1;
    }
}

