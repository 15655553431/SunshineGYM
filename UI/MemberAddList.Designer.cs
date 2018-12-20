namespace UI
{
    partial class MemberAddList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberAddList));
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.txtCId = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbz = new System.Windows.Forms.TextBox();
            this.vspMember = new AForge.Controls.VideoSourcePlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCamera = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbm = new System.Windows.Forms.RadioButton();
            this.rbw = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(603, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 45);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "确认注册";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtp2
            // 
            this.dtp2.Enabled = false;
            this.dtp2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp2.Location = new System.Drawing.Point(822, 264);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(129, 23);
            this.dtp2.TabIndex = 44;
            // 
            // dtp1
            // 
            this.dtp1.Enabled = false;
            this.dtp1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp1.Location = new System.Drawing.Point(603, 264);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(123, 23);
            this.dtp1.TabIndex = 43;
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAdress.Location = new System.Drawing.Point(603, 220);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(348, 23);
            this.txtAdress.TabIndex = 5;
            // 
            // txtType
            // 
            this.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtType.FormattingEnabled = true;
            this.txtType.Location = new System.Drawing.Point(807, 178);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(144, 22);
            this.txtType.TabIndex = 4;
            this.txtType.SelectedIndexChanged += new System.EventHandler(this.txtType_SelectedIndexChanged);
            // 
            // txtCId
            // 
            this.txtCId.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCId.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCId.Location = new System.Drawing.Point(807, 94);
            this.txtCId.Name = "txtCId";
            this.txtCId.Size = new System.Drawing.Size(144, 23);
            this.txtCId.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhone.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPhone.Location = new System.Drawing.Point(807, 136);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(144, 23);
            this.txtPhone.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(807, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 23);
            this.txtName.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(743, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 14);
            this.label12.TabIndex = 36;
            this.label12.Text = "截止时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(523, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 35;
            this.label8.Text = "办卡时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(523, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 34;
            this.label7.Text = "住宿地址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(748, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 32;
            this.label5.Text = "电 话：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(748, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 31;
            this.label4.Text = "卡 号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(748, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 30;
            this.label3.Text = "类 型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(750, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "性 别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(748, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 28;
            this.label1.Text = "姓 名：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(520, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 14);
            this.label13.TabIndex = 60;
            this.label13.Text = "会员备注：";
            // 
            // txtbz
            // 
            this.txtbz.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbz.Location = new System.Drawing.Point(603, 309);
            this.txtbz.Multiline = true;
            this.txtbz.Name = "txtbz";
            this.txtbz.Size = new System.Drawing.Size(348, 60);
            this.txtbz.TabIndex = 6;
            // 
            // vspMember
            // 
            this.vspMember.Location = new System.Drawing.Point(12, 12);
            this.vspMember.Name = "vspMember";
            this.vspMember.Size = new System.Drawing.Size(485, 373);
            this.vspMember.TabIndex = 62;
            this.vspMember.VideoSource = null;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(289, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 63;
            this.button1.Text = "打开摄像头";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(406, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 38);
            this.button2.TabIndex = 64;
            this.button2.Text = "拍照";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCamera
            // 
            this.txtCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCamera.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCamera.FormattingEnabled = true;
            this.txtCamera.Location = new System.Drawing.Point(113, 420);
            this.txtCamera.Name = "txtCamera";
            this.txtCamera.Size = new System.Drawing.Size(134, 24);
            this.txtCamera.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(508, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 173);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "照片";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(769, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 45);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消填写";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbm
            // 
            this.rbm.AutoSize = true;
            this.rbm.Location = new System.Drawing.Point(820, 59);
            this.rbm.Name = "rbm";
            this.rbm.Size = new System.Drawing.Size(35, 16);
            this.rbm.TabIndex = 69;
            this.rbm.TabStop = true;
            this.rbm.Text = "男";
            this.rbm.UseVisualStyleBackColor = true;
            // 
            // rbw
            // 
            this.rbw.AutoSize = true;
            this.rbw.Location = new System.Drawing.Point(889, 59);
            this.rbw.Name = "rbw";
            this.rbw.Size = new System.Drawing.Size(35, 16);
            this.rbw.TabIndex = 70;
            this.rbw.TabStop = true;
            this.rbw.Text = "女";
            this.rbw.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(22, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 14);
            this.label6.TabIndex = 71;
            this.label6.Text = "摄像头选择：";
            // 
            // MemberAddList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 496);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbw);
            this.Controls.Add(this.rbm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCamera);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vspMember);
            this.Controls.Add(this.txtbz);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtCId);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberAddList";
            this.Text = "会员注册信息表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemberAddList_FormClosing);
            this.Load += new System.EventHandler(this.MemberAddList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.TextBox txtCId;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbz;
        private AForge.Controls.VideoSourcePlayer vspMember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox txtCamera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbm;
        private System.Windows.Forms.RadioButton rbw;
        private System.Windows.Forms.Label label6;
    }
}