namespace WindowsFormsApp2
{
    partial class FrmMethods
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCheckBalance = new System.Windows.Forms.Button();
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(320, 287);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(127, 32);
            this.BtnBack.TabIndex = 20;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCheckBalance);
            this.groupBox2.Controls.Add(this.BtnWithdraw);
            this.groupBox2.Controls.Add(this.BtnDeposit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(273, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 215);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IE Bank";
            // 
            // BtnCheckBalance
            // 
            this.BtnCheckBalance.AutoSize = true;
            this.BtnCheckBalance.Location = new System.Drawing.Point(32, 149);
            this.BtnCheckBalance.Name = "BtnCheckBalance";
            this.BtnCheckBalance.Size = new System.Drawing.Size(109, 26);
            this.BtnCheckBalance.TabIndex = 0;
            this.BtnCheckBalance.Text = "Check Balance";
            this.BtnCheckBalance.UseVisualStyleBackColor = true;
            this.BtnCheckBalance.Click += new System.EventHandler(this.BtnCheckBalance_Click);
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.AutoSize = true;
            this.BtnWithdraw.Location = new System.Drawing.Point(32, 95);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(109, 26);
            this.BtnWithdraw.TabIndex = 0;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.UseVisualStyleBackColor = true;
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.AutoSize = true;
            this.BtnDeposit.Location = new System.Drawing.Point(32, 44);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(109, 26);
            this.BtnDeposit.TabIndex = 0;
            this.BtnDeposit.Text = "Deposit";
            this.BtnDeposit.UseVisualStyleBackColor = true;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.TxtB);
            this.groupBox1.Controls.Add(this.BtnCalculate);
            this.groupBox1.Controls.Add(this.TxtA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 215);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator using Methods";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(16, 75);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(16, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "b";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(16, 16);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "a";
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(57, 72);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(100, 22);
            this.TxtB.TabIndex = 0;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.AutoSize = true;
            this.BtnCalculate.Location = new System.Drawing.Point(62, 128);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(95, 28);
            this.BtnCalculate.TabIndex = 0;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(57, 28);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(100, 22);
            this.TxtA.TabIndex = 0;
            // 
            // FrmMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBack);
            this.Name = "FrmMethods";
            this.Text = "Methods Form";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCheckBalance;
        private System.Windows.Forms.Button BtnWithdraw;
        private System.Windows.Forms.Button BtnDeposit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox TxtA;
    }
}