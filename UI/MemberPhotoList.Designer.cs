namespace UI
{
    partial class MemberPhotoList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberPhotoList));
            this.label6 = new System.Windows.Forms.Label();
            this.txtCamera = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.vspMember = new AForge.Controls.VideoSourcePlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(553, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 76;
            this.label6.Text = "摄像头选择：";
            // 
            // txtCamera
            // 
            this.txtCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCamera.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCamera.FormattingEnabled = true;
            this.txtCamera.Location = new System.Drawing.Point(660, 261);
            this.txtCamera.Name = "txtCamera";
            this.txtCamera.Size = new System.Drawing.Size(162, 24);
            this.txtCamera.TabIndex = 75;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(633, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 46);
            this.button2.TabIndex = 74;
            this.button2.Text = "拍照";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(536, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 46);
            this.button1.TabIndex = 73;
            this.button1.Text = "打开摄像头";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vspMember
            // 
            this.vspMember.Location = new System.Drawing.Point(12, 12);
            this.vspMember.Name = "vspMember";
            this.vspMember.Size = new System.Drawing.Size(485, 373);
            this.vspMember.TabIndex = 72;
            this.vspMember.VideoSource = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(523, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(731, 315);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(91, 46);
            this.btnEnter.TabIndex = 78;
            this.btnEnter.Text = "确认修改";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // MemberPhotoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 401);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCamera);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vspMember);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberPhotoList";
            this.Text = "照片修改界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemberPhotoList_FormClosing);
            this.Load += new System.EventHandler(this.MemberPhotoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtCamera;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private AForge.Controls.VideoSourcePlayer vspMember;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnter;
    }
}