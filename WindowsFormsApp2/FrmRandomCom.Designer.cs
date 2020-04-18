namespace WindowsFormsApp2
{
    partial class FrmRandomCom
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
            this.btnReset1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoGreater1 = new System.Windows.Forms.RadioButton();
            this.RdoLess1 = new System.Windows.Forms.RadioButton();
            this.BtnGenerate1 = new System.Windows.Forms.Button();
            this.CmbRandom1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Label = new System.Windows.Forms.Label();
            this.RdoGreater2 = new System.Windows.Forms.RadioButton();
            this.RdoLess2 = new System.Windows.Forms.RadioButton();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.CmbRandom2 = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset1
            // 
            this.btnReset1.Location = new System.Drawing.Point(8, 151);
            this.btnReset1.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(71, 27);
            this.btnReset1.TabIndex = 4;
            this.btnReset1.Text = "Reset";
            this.btnReset1.UseVisualStyleBackColor = true;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoGreater1);
            this.groupBox1.Controls.Add(this.RdoLess1);
            this.groupBox1.Controls.Add(this.btnReset1);
            this.groupBox1.Controls.Add(this.BtnGenerate1);
            this.groupBox1.Controls.Add(this.CmbRandom1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(268, 182);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random Combo A";
            // 
            // RdoGreater1
            // 
            this.RdoGreater1.AutoSize = true;
            this.RdoGreater1.Location = new System.Drawing.Point(124, 121);
            this.RdoGreater1.Margin = new System.Windows.Forms.Padding(2);
            this.RdoGreater1.Name = "RdoGreater1";
            this.RdoGreater1.Size = new System.Drawing.Size(123, 20);
            this.RdoGreater1.TabIndex = 7;
            this.RdoGreater1.TabStop = true;
            this.RdoGreater1.Text = "Greater than 500";
            this.RdoGreater1.UseVisualStyleBackColor = true;
            // 
            // RdoLess1
            // 
            this.RdoLess1.AutoSize = true;
            this.RdoLess1.Location = new System.Drawing.Point(124, 84);
            this.RdoLess1.Margin = new System.Windows.Forms.Padding(2);
            this.RdoLess1.Name = "RdoLess1";
            this.RdoLess1.Size = new System.Drawing.Size(107, 20);
            this.RdoLess1.TabIndex = 6;
            this.RdoLess1.TabStop = true;
            this.RdoLess1.Text = "Less than 500";
            this.RdoLess1.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate1
            // 
            this.BtnGenerate1.Location = new System.Drawing.Point(163, 32);
            this.BtnGenerate1.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGenerate1.Name = "BtnGenerate1";
            this.BtnGenerate1.Size = new System.Drawing.Size(89, 29);
            this.BtnGenerate1.TabIndex = 5;
            this.BtnGenerate1.Text = "Generate";
            this.BtnGenerate1.UseVisualStyleBackColor = true;
            this.BtnGenerate1.Click += new System.EventHandler(this.BtnGenerate1_Click);
            // 
            // CmbRandom1
            // 
            this.CmbRandom1.FormattingEnabled = true;
            this.CmbRandom1.Location = new System.Drawing.Point(8, 35);
            this.CmbRandom1.Margin = new System.Windows.Forms.Padding(2);
            this.CmbRandom1.Name = "CmbRandom1";
            this.CmbRandom1.Size = new System.Drawing.Size(128, 24);
            this.CmbRandom1.TabIndex = 4;
            this.CmbRandom1.SelectedIndexChanged += new System.EventHandler(this.CmbRandom1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Label);
            this.groupBox2.Controls.Add(this.RdoGreater2);
            this.groupBox2.Controls.Add(this.RdoLess2);
            this.groupBox2.Controls.Add(this.btnReset2);
            this.groupBox2.Controls.Add(this.BtnGenerate2);
            this.groupBox2.Controls.Add(this.CmbRandom2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(306, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(268, 182);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Random Combo B";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(4, 68);
            this.Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(45, 16);
            this.Label.TabIndex = 8;
            this.Label.Text = "Count:";
            // 
            // RdoGreater2
            // 
            this.RdoGreater2.AutoSize = true;
            this.RdoGreater2.Location = new System.Drawing.Point(130, 121);
            this.RdoGreater2.Margin = new System.Windows.Forms.Padding(2);
            this.RdoGreater2.Name = "RdoGreater2";
            this.RdoGreater2.Size = new System.Drawing.Size(116, 20);
            this.RdoGreater2.TabIndex = 7;
            this.RdoGreater2.TabStop = true;
            this.RdoGreater2.Text = "Greater than 50";
            this.RdoGreater2.UseVisualStyleBackColor = true;
            // 
            // RdoLess2
            // 
            this.RdoLess2.AutoSize = true;
            this.RdoLess2.Location = new System.Drawing.Point(130, 84);
            this.RdoLess2.Margin = new System.Windows.Forms.Padding(2);
            this.RdoLess2.Name = "RdoLess2";
            this.RdoLess2.Size = new System.Drawing.Size(100, 20);
            this.RdoLess2.TabIndex = 6;
            this.RdoLess2.TabStop = true;
            this.RdoLess2.Text = "Less than 50";
            this.RdoLess2.UseVisualStyleBackColor = true;
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(11, 151);
            this.btnReset2.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(71, 27);
            this.btnReset2.TabIndex = 4;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.Location = new System.Drawing.Point(166, 32);
            this.BtnGenerate2.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(89, 29);
            this.BtnGenerate2.TabIndex = 5;
            this.BtnGenerate2.Text = "Generate";
            this.BtnGenerate2.UseVisualStyleBackColor = true;
            this.BtnGenerate2.Click += new System.EventHandler(this.BtnGenerate2_Click);
            // 
            // CmbRandom2
            // 
            this.CmbRandom2.FormattingEnabled = true;
            this.CmbRandom2.Location = new System.Drawing.Point(11, 35);
            this.CmbRandom2.Margin = new System.Windows.Forms.Padding(2);
            this.CmbRandom2.Name = "CmbRandom2";
            this.CmbRandom2.Size = new System.Drawing.Size(128, 24);
            this.CmbRandom2.TabIndex = 4;
            this.CmbRandom2.SelectedIndexChanged += new System.EventHandler(this.CmbRandom2_SelectedIndexChanged);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(462, 280);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(112, 35);
            this.BtnBack.TabIndex = 11;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmRandomCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 330);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmRandomCom";
            this.Text = "Random Combo Form";
            this.Load += new System.EventHandler(this.FrmRandomCom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoGreater1;
        private System.Windows.Forms.RadioButton RdoLess1;
        private System.Windows.Forms.Button BtnGenerate1;
        private System.Windows.Forms.ComboBox CmbRandom1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.RadioButton RdoGreater2;
        private System.Windows.Forms.RadioButton RdoLess2;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.ComboBox CmbRandom2;
        private System.Windows.Forms.Button BtnBack;
    }
}