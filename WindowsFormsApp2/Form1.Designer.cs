namespace WindowsFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnExit = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.ObjectOriented = new System.Windows.Forms.GroupBox();
            this.BtnClasses = new System.Windows.Forms.Button();
            this.BtnMethods = new System.Windows.Forms.Button();
            this.MoreControls = new System.Windows.Forms.GroupBox();
            this.BtnRandomCom = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.Graphical = new System.Windows.Forms.GroupBox();
            this.BtnPic2 = new System.Windows.Forms.Button();
            this.BtnPic = new System.Windows.Forms.Button();
            this.BasicControls = new System.Windows.Forms.GroupBox();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.LoginForm = new System.Windows.Forms.GroupBox();
            this.LnkForgot = new System.Windows.Forms.LinkLabel();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LabelPass = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.ObjectOriented.SuspendLayout();
            this.MoreControls.SuspendLayout();
            this.Graphical.SuspendLayout();
            this.BasicControls.SuspendLayout();
            this.LoginForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Gold;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(36, 480);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(283, 71);
            this.BtnExit.TabIndex = 20;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.White;
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(77, 246);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(201, 214);
            this.PicLogo.TabIndex = 27;
            this.PicLogo.TabStop = false;
            this.PicLogo.Click += new System.EventHandler(this.PicLogo_Click);
            // 
            // ObjectOriented
            // 
            this.ObjectOriented.Controls.Add(this.BtnClasses);
            this.ObjectOriented.Controls.Add(this.BtnMethods);
            this.ObjectOriented.Location = new System.Drawing.Point(12, 385);
            this.ObjectOriented.Name = "ObjectOriented";
            this.ObjectOriented.Size = new System.Drawing.Size(321, 75);
            this.ObjectOriented.TabIndex = 24;
            this.ObjectOriented.TabStop = false;
            this.ObjectOriented.Text = "Object Oriented";
            // 
            // BtnClasses
            // 
            this.BtnClasses.BackColor = System.Drawing.SystemColors.Control;
            this.BtnClasses.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClasses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClasses.Location = new System.Drawing.Point(179, 19);
            this.BtnClasses.Name = "BtnClasses";
            this.BtnClasses.Size = new System.Drawing.Size(128, 45);
            this.BtnClasses.TabIndex = 11;
            this.BtnClasses.Text = "Classes";
            this.BtnClasses.UseVisualStyleBackColor = false;
            this.BtnClasses.Click += new System.EventHandler(this.BtnClasses_Click);
            // 
            // BtnMethods
            // 
            this.BtnMethods.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMethods.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMethods.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMethods.Location = new System.Drawing.Point(21, 19);
            this.BtnMethods.Name = "BtnMethods";
            this.BtnMethods.Size = new System.Drawing.Size(128, 45);
            this.BtnMethods.TabIndex = 10;
            this.BtnMethods.Text = "Methods";
            this.BtnMethods.UseVisualStyleBackColor = false;
            this.BtnMethods.Click += new System.EventHandler(this.BtnMethods_Click);
            // 
            // MoreControls
            // 
            this.MoreControls.Controls.Add(this.BtnRandomCom);
            this.MoreControls.Controls.Add(this.BtnRandom);
            this.MoreControls.Location = new System.Drawing.Point(12, 267);
            this.MoreControls.Name = "MoreControls";
            this.MoreControls.Size = new System.Drawing.Size(320, 129);
            this.MoreControls.TabIndex = 25;
            this.MoreControls.TabStop = false;
            this.MoreControls.Text = "More Controls";
            // 
            // BtnRandomCom
            // 
            this.BtnRandomCom.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRandomCom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnRandomCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRandomCom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRandomCom.Location = new System.Drawing.Point(179, 19);
            this.BtnRandomCom.Name = "BtnRandomCom";
            this.BtnRandomCom.Size = new System.Drawing.Size(128, 45);
            this.BtnRandomCom.TabIndex = 13;
            this.BtnRandomCom.Text = "RandomCom";
            this.BtnRandomCom.UseVisualStyleBackColor = false;
            this.BtnRandomCom.Click += new System.EventHandler(this.BtnRandomCom_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRandom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRandom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRandom.Location = new System.Drawing.Point(21, 19);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(128, 45);
            this.BtnRandom.TabIndex = 12;
            this.BtnRandom.Text = "Random";
            this.BtnRandom.UseVisualStyleBackColor = false;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // Graphical
            // 
            this.Graphical.Controls.Add(this.BtnPic2);
            this.Graphical.Controls.Add(this.BtnPic);
            this.Graphical.Location = new System.Drawing.Point(12, 162);
            this.Graphical.Name = "Graphical";
            this.Graphical.Size = new System.Drawing.Size(321, 129);
            this.Graphical.TabIndex = 23;
            this.Graphical.TabStop = false;
            this.Graphical.Text = "Graphical";
            // 
            // BtnPic2
            // 
            this.BtnPic2.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPic2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnPic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPic2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPic2.Location = new System.Drawing.Point(179, 19);
            this.BtnPic2.Name = "BtnPic2";
            this.BtnPic2.Size = new System.Drawing.Size(128, 45);
            this.BtnPic2.TabIndex = 11;
            this.BtnPic2.Text = "Picture Box v2";
            this.BtnPic2.UseVisualStyleBackColor = false;
            this.BtnPic2.Click += new System.EventHandler(this.BtnPic2_Click);
            // 
            // BtnPic
            // 
            this.BtnPic.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPic.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPic.Location = new System.Drawing.Point(21, 19);
            this.BtnPic.Name = "BtnPic";
            this.BtnPic.Size = new System.Drawing.Size(128, 45);
            this.BtnPic.TabIndex = 10;
            this.BtnPic.Text = "Picture Box";
            this.BtnPic.UseVisualStyleBackColor = false;
            this.BtnPic.Click += new System.EventHandler(this.BtnPic_Click);
            // 
            // BasicControls
            // 
            this.BasicControls.Controls.Add(this.BtnCombo);
            this.BasicControls.Controls.Add(this.BtnCheck);
            this.BasicControls.Controls.Add(this.BtnRadio);
            this.BasicControls.Location = new System.Drawing.Point(11, 7);
            this.BasicControls.Name = "BasicControls";
            this.BasicControls.Size = new System.Drawing.Size(322, 129);
            this.BasicControls.TabIndex = 22;
            this.BasicControls.TabStop = false;
            this.BasicControls.Text = "Basic Controls";
            // 
            // BtnCombo
            // 
            this.BtnCombo.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCombo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCombo.Location = new System.Drawing.Point(101, 74);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(128, 45);
            this.BtnCombo.TabIndex = 9;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = false;
            this.BtnCombo.Click += new System.EventHandler(this.BtnCombo_Click);
            // 
            // BtnCheck
            // 
            this.BtnCheck.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCheck.Location = new System.Drawing.Point(179, 19);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(128, 45);
            this.BtnCheck.TabIndex = 8;
            this.BtnCheck.Text = "Check Box";
            this.BtnCheck.UseVisualStyleBackColor = false;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnRadio
            // 
            this.BtnRadio.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRadio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRadio.Location = new System.Drawing.Point(21, 19);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(128, 45);
            this.BtnRadio.TabIndex = 7;
            this.BtnRadio.Text = "Radio";
            this.BtnRadio.UseVisualStyleBackColor = false;
            this.BtnRadio.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // LoginForm
            // 
            this.LoginForm.Controls.Add(this.LnkForgot);
            this.LoginForm.Controls.Add(this.BtnAbout);
            this.LoginForm.Controls.Add(this.BtnLogin);
            this.LoginForm.Controls.Add(this.LabelPass);
            this.LoginForm.Controls.Add(this.LabelUser);
            this.LoginForm.Controls.Add(this.TxtPass);
            this.LoginForm.Controls.Add(this.TxtUser);
            this.LoginForm.Location = new System.Drawing.Point(12, 12);
            this.LoginForm.Name = "LoginForm";
            this.LoginForm.Size = new System.Drawing.Size(330, 216);
            this.LoginForm.TabIndex = 21;
            this.LoginForm.TabStop = false;
            this.LoginForm.Text = "Login Form";
            // 
            // LnkForgot
            // 
            this.LnkForgot.AutoSize = true;
            this.LnkForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkForgot.Location = new System.Drawing.Point(13, 186);
            this.LnkForgot.Name = "LnkForgot";
            this.LnkForgot.Size = new System.Drawing.Size(180, 13);
            this.LnkForgot.TabIndex = 6;
            this.LnkForgot.TabStop = true;
            this.LnkForgot.Text = "You Don\'t Remeber Your Password?";
            this.LnkForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkForgot_LinkClicked);
            // 
            // BtnAbout
            // 
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.Location = new System.Drawing.Point(16, 128);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(128, 45);
            this.BtnAbout.TabIndex = 5;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnLogin.Location = new System.Drawing.Point(171, 128);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(128, 45);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LabelPass
            // 
            this.LabelPass.AutoSize = true;
            this.LabelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPass.Location = new System.Drawing.Point(12, 83);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(78, 20);
            this.LabelPass.TabIndex = 3;
            this.LabelPass.Text = "Password";
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser.Location = new System.Drawing.Point(12, 28);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(83, 20);
            this.LabelUser.TabIndex = 2;
            this.LabelUser.Text = "Username";
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(123, 80);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(176, 26);
            this.TxtPass.TabIndex = 1;
            // 
            // TxtUser
            // 
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.Location = new System.Drawing.Point(123, 25);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(176, 26);
            this.TxtUser.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ObjectOriented);
            this.groupBox1.Controls.Add(this.MoreControls);
            this.groupBox1.Controls.Add(this.Graphical);
            this.groupBox1.Controls.Add(this.BasicControls);
            this.groupBox1.Location = new System.Drawing.Point(395, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 564);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.LoginForm);
            this.Name = "Form1";
            this.Text = "IE Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ObjectOriented.ResumeLayout(false);
            this.MoreControls.ResumeLayout(false);
            this.Graphical.ResumeLayout(false);
            this.BasicControls.ResumeLayout(false);
            this.LoginForm.ResumeLayout(false);
            this.LoginForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.GroupBox ObjectOriented;
        private System.Windows.Forms.Button BtnClasses;
        private System.Windows.Forms.Button BtnMethods;
        private System.Windows.Forms.GroupBox MoreControls;
        private System.Windows.Forms.Button BtnRandomCom;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.GroupBox Graphical;
        private System.Windows.Forms.Button BtnPic2;
        private System.Windows.Forms.Button BtnPic;
        private System.Windows.Forms.GroupBox BasicControls;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnRadio;
        private System.Windows.Forms.GroupBox LoginForm;
        private System.Windows.Forms.LinkLabel LnkForgot;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

