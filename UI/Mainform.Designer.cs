namespace UI
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuManager = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMember = new System.Windows.Forms.ToolStripMenuItem();
            this.menuboss = new System.Windows.Forms.ToolStripMenuItem();
            this.qtmanager = new System.Windows.Forms.ToolStripMenuItem();
            this.mtype = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.gbf = new System.Windows.Forms.Panel();
            this.gbmember = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblred = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtCId = new System.Windows.Forms.TextBox();
            this.txtCBZ = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.dtp3 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.gbf.SuspendLayout();
            this.gbmember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManager,
            this.menuMember,
            this.menuboss,
            this.menuQuit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 108);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuManager
            // 
            this.menuManager.Image = global::UI.Properties.Resources._1;
            this.menuManager.Name = "menuManager";
            this.menuManager.Size = new System.Drawing.Size(92, 104);
            this.menuManager.Text = "业务办理";
            this.menuManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuManager.Click += new System.EventHandler(this.menuManager_Click);
            // 
            // menuMember
            // 
            this.menuMember.Image = global::UI.Properties.Resources._2;
            this.menuMember.Name = "menuMember";
            this.menuMember.Size = new System.Drawing.Size(92, 104);
            this.menuMember.Text = "会员管理";
            this.menuMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuMember.Click += new System.EventHandler(this.menuMember_Click);
            // 
            // menuboss
            // 
            this.menuboss.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qtmanager,
            this.mtype});
            this.menuboss.Image = global::UI.Properties.Resources._3;
            this.menuboss.Name = "menuboss";
            this.menuboss.Size = new System.Drawing.Size(92, 104);
            this.menuboss.Text = "店长管理";
            this.menuboss.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // qtmanager
            // 
            this.qtmanager.Name = "qtmanager";
            this.qtmanager.Size = new System.Drawing.Size(162, 24);
            this.qtmanager.Text = "前台管理";
            this.qtmanager.Click += new System.EventHandler(this.qtmanager_Click);
            // 
            // mtype
            // 
            this.mtype.Name = "mtype";
            this.mtype.Size = new System.Drawing.Size(162, 24);
            this.mtype.Text = "会员类型管理";
            this.mtype.Click += new System.EventHandler(this.mtype_Click);
            // 
            // menuQuit
            // 
            this.menuQuit.Image = global::UI.Properties.Resources._4;
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(92, 104);
            this.menuQuit.Text = "退出系统";
            this.menuQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
            // 
            // gbf
            // 
            this.gbf.BackgroundImage = global::UI.Properties.Resources.bgf;
            this.gbf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbf.Controls.Add(this.gbmember);
            this.gbf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbf.Location = new System.Drawing.Point(0, 108);
            this.gbf.Name = "gbf";
            this.gbf.Size = new System.Drawing.Size(1048, 632);
            this.gbf.TabIndex = 100;
            // 
            // gbmember
            // 
            this.gbmember.BackColor = System.Drawing.Color.Transparent;
            this.gbmember.BackgroundImage = global::UI.Properties.Resources.bgme;
            this.gbmember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbmember.Controls.Add(this.pictureBox1);
            this.gbmember.Controls.Add(this.lblred);
            this.gbmember.Controls.Add(this.button1);
            this.gbmember.Controls.Add(this.txtType);
            this.gbmember.Controls.Add(this.txtCId);
            this.gbmember.Controls.Add(this.txtCBZ);
            this.gbmember.Controls.Add(this.txtName);
            this.gbmember.Controls.Add(this.dtp2);
            this.gbmember.Controls.Add(this.txtPhone);
            this.gbmember.Controls.Add(this.txtCount);
            this.gbmember.Controls.Add(this.dtp3);
            this.gbmember.Location = new System.Drawing.Point(43, 19);
            this.gbmember.Name = "gbmember";
            this.gbmember.Size = new System.Drawing.Size(919, 579);
            this.gbmember.TabIndex = 99;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.psb;
            this.pictureBox1.Location = new System.Drawing.Point(66, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // lblred
            // 
            this.lblred.AutoSize = true;
            this.lblred.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblred.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblred.Location = new System.Drawing.Point(84, 447);
            this.lblred.Name = "lblred";
            this.lblred.Size = new System.Drawing.Size(90, 22);
            this.lblred.TabIndex = 97;
            this.lblred.Text = "等待检测中";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(581, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "确认通过";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtType.Location = new System.Drawing.Point(646, 204);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(140, 26);
            this.txtType.TabIndex = 96;
            // 
            // txtCId
            // 
            this.txtCId.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCId.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCId.Location = new System.Drawing.Point(646, 116);
            this.txtCId.Name = "txtCId";
            this.txtCId.Size = new System.Drawing.Size(140, 23);
            this.txtCId.TabIndex = 0;
            this.txtCId.TextChanged += new System.EventHandler(this.txtCId_TextChanged);
            this.txtCId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCId_KeyDown);
            // 
            // txtCBZ
            // 
            this.txtCBZ.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCBZ.Location = new System.Drawing.Point(646, 249);
            this.txtCBZ.Multiline = true;
            this.txtCBZ.Name = "txtCBZ";
            this.txtCBZ.ReadOnly = true;
            this.txtCBZ.Size = new System.Drawing.Size(140, 26);
            this.txtCBZ.TabIndex = 98;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(646, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // dtp2
            // 
            this.dtp2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp2.Location = new System.Drawing.Point(646, 382);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(140, 23);
            this.dtp2.TabIndex = 89;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhone.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPhone.Location = new System.Drawing.Point(646, 160);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(140, 23);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCount.Location = new System.Drawing.Point(646, 293);
            this.txtCount.Multiline = true;
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(140, 29);
            this.txtCount.TabIndex = 80;
            // 
            // dtp3
            // 
            this.dtp3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp3.Location = new System.Drawing.Point(646, 339);
            this.dtp3.Name = "dtp3";
            this.dtp3.Size = new System.Drawing.Size(140, 23);
            this.dtp3.TabIndex = 92;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 740);
            this.Controls.Add(this.gbf);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "管理界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.SizeChanged += new System.EventHandler(this.Mainform_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbf.ResumeLayout(false);
            this.gbmember.ResumeLayout(false);
            this.gbmember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuManager;
        private System.Windows.Forms.ToolStripMenuItem menuMember;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.ToolStripMenuItem menuboss;
        private System.Windows.Forms.ToolStripMenuItem qtmanager;
        private System.Windows.Forms.ToolStripMenuItem mtype;
        private System.Windows.Forms.Panel gbf;
        private System.Windows.Forms.Panel gbmember;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblred;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtCId;
        private System.Windows.Forms.TextBox txtCBZ;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.DateTimePicker dtp3;
    }
}