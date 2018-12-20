namespace UI
{
    partial class MemberDatilList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberDatilList));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbz = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.ComboBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.dtp3 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtCId = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtxkType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.endtime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(316, 369);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 54);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "修改信息";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtbz);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSex);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.dtp3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.txtAdress);
            this.groupBox1.Controls.Add(this.txtCId);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(445, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 465);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改专区";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(313, 324);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 28);
            this.label14.TabIndex = 59;
            this.label14.Text = "提示：点击修改信息\r\n按钮可进行修改操作";
            // 
            // txtbz
            // 
            this.txtbz.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbz.Location = new System.Drawing.Point(20, 327);
            this.txtbz.Multiline = true;
            this.txtbz.Name = "txtbz";
            this.txtbz.Size = new System.Drawing.Size(276, 108);
            this.txtbz.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(17, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 14);
            this.label11.TabIndex = 57;
            this.label11.Text = "备注：";
            // 
            // txtSex
            // 
            this.txtSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSex.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSex.FormattingEnabled = true;
            this.txtSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.txtSex.Location = new System.Drawing.Point(75, 93);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(125, 22);
            this.txtSex.TabIndex = 3;
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCount.Location = new System.Drawing.Point(92, 204);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(126, 23);
            this.txtCount.TabIndex = 55;
            // 
            // dtp3
            // 
            this.dtp3.Enabled = false;
            this.dtp3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp3.Location = new System.Drawing.Point(92, 256);
            this.dtp3.Name = "dtp3";
            this.dtp3.Size = new System.Drawing.Size(126, 23);
            this.dtp3.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(13, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 14);
            this.label10.TabIndex = 53;
            this.label10.Text = "锻炼次数：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(13, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 14);
            this.label9.TabIndex = 52;
            this.label9.Text = "上次锻炼：";
            // 
            // dtp2
            // 
            this.dtp2.Enabled = false;
            this.dtp2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp2.Location = new System.Drawing.Point(314, 256);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(126, 23);
            this.dtp2.TabIndex = 51;
            // 
            // dtp1
            // 
            this.dtp1.Enabled = false;
            this.dtp1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp1.Location = new System.Drawing.Point(314, 204);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(126, 23);
            this.dtp1.TabIndex = 50;
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAdress.Location = new System.Drawing.Point(96, 151);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(350, 23);
            this.txtAdress.TabIndex = 6;
            // 
            // txtCId
            // 
            this.txtCId.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCId.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCId.Location = new System.Drawing.Point(299, 43);
            this.txtCId.Name = "txtCId";
            this.txtCId.Size = new System.Drawing.Size(126, 23);
            this.txtCId.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhone.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPhone.Location = new System.Drawing.Point(299, 93);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(126, 23);
            this.txtPhone.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(76, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 23);
            this.txtName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(234, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 14);
            this.label12.TabIndex = 43;
            this.label12.Text = "截止时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(234, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 42;
            this.label8.Text = "办卡时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(13, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 41;
            this.label7.Text = "住宿地址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(240, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 39;
            this.label5.Text = "电 话：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(240, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 38;
            this.label4.Text = "卡 号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 36;
            this.label2.Text = "性 别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 35;
            this.label1.Text = "姓 名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtxkType);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.endtime);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 158);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "续卡专区";
            // 
            // txtxkType
            // 
            this.txtxkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtxkType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtxkType.FormattingEnabled = true;
            this.txtxkType.Location = new System.Drawing.Point(113, 39);
            this.txtxkType.Name = "txtxkType";
            this.txtxkType.Size = new System.Drawing.Size(125, 22);
            this.txtxkType.TabIndex = 1;
            this.txtxkType.SelectedIndexChanged += new System.EventHandler(this.txtxkType_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(33, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 14);
            this.label15.TabIndex = 5;
            this.label15.Text = "续卡类型：";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(253, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 58);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "确认续卡";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // endtime
            // 
            this.endtime.Enabled = false;
            this.endtime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endtime.Location = new System.Drawing.Point(113, 93);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(125, 23);
            this.endtime.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(19, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 14);
            this.label13.TabIndex = 0;
            this.label13.Text = "新截止时间：";
            // 
            // MemberDatilList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 482);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberDatilList";
            this.Text = "会员详细信息表";
            this.Load += new System.EventHandler(this.MemberDatilList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbz;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtSex;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.DateTimePicker dtp3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtCId;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker endtime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox txtxkType;
        private System.Windows.Forms.Label label15;
    }
}