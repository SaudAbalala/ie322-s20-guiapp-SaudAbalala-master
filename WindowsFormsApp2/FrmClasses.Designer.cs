namespace WindowsFormsApp2
{
    partial class FrmClasses
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnStopMyCar = new System.Windows.Forms.Button();
            this.BtnAccMyCar = new System.Windows.Forms.Button();
            this.BtnStartMyCar = new System.Windows.Forms.Button();
            this.BtnStartMyTruck = new System.Windows.Forms.Button();
            this.BtnStopHisCar = new System.Windows.Forms.Button();
            this.BtnAccHisCar = new System.Windows.Forms.Button();
            this.BtnStartHisCar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(388, 307);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(127, 32);
            this.BtnBack.TabIndex = 20;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnStopMyCar);
            this.groupBox1.Controls.Add(this.BtnAccMyCar);
            this.groupBox1.Controls.Add(this.BtnStartMyCar);
            this.groupBox1.Controls.Add(this.BtnStartMyTruck);
            this.groupBox1.Controls.Add(this.BtnStopHisCar);
            this.groupBox1.Controls.Add(this.BtnAccHisCar);
            this.groupBox1.Controls.Add(this.BtnStartHisCar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 249);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classes";
            // 
            // BtnStopMyCar
            // 
            this.BtnStopMyCar.AutoSize = true;
            this.BtnStopMyCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnStopMyCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnStopMyCar.Location = new System.Drawing.Point(314, 19);
            this.BtnStopMyCar.Name = "BtnStopMyCar";
            this.BtnStopMyCar.Size = new System.Drawing.Size(135, 34);
            this.BtnStopMyCar.TabIndex = 0;
            this.BtnStopMyCar.Text = "Stop My Car";
            this.BtnStopMyCar.UseVisualStyleBackColor = false;
            this.BtnStopMyCar.Click += new System.EventHandler(this.BtnStopMyCar_Click);
            // 
            // BtnAccMyCar
            // 
            this.BtnAccMyCar.AutoSize = true;
            this.BtnAccMyCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnAccMyCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAccMyCar.Location = new System.Drawing.Point(162, 19);
            this.BtnAccMyCar.Name = "BtnAccMyCar";
            this.BtnAccMyCar.Size = new System.Drawing.Size(146, 34);
            this.BtnAccMyCar.TabIndex = 0;
            this.BtnAccMyCar.Text = "Accelerate My Car";
            this.BtnAccMyCar.UseVisualStyleBackColor = false;
            this.BtnAccMyCar.Click += new System.EventHandler(this.BtnAccMyCar_Click);
            // 
            // BtnStartMyCar
            // 
            this.BtnStartMyCar.AutoSize = true;
            this.BtnStartMyCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnStartMyCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnStartMyCar.Location = new System.Drawing.Point(19, 19);
            this.BtnStartMyCar.Name = "BtnStartMyCar";
            this.BtnStartMyCar.Size = new System.Drawing.Size(137, 34);
            this.BtnStartMyCar.TabIndex = 0;
            this.BtnStartMyCar.Text = "Start My Car";
            this.BtnStartMyCar.UseVisualStyleBackColor = false;
            this.BtnStartMyCar.Click += new System.EventHandler(this.BtnStartMyCar_Click);
            // 
            // BtnStartMyTruck
            // 
            this.BtnStartMyTruck.AutoSize = true;
            this.BtnStartMyTruck.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnStartMyTruck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnStartMyTruck.Location = new System.Drawing.Point(162, 158);
            this.BtnStartMyTruck.Name = "BtnStartMyTruck";
            this.BtnStartMyTruck.Size = new System.Drawing.Size(146, 34);
            this.BtnStartMyTruck.TabIndex = 0;
            this.BtnStartMyTruck.Text = "Start My Truck";
            this.BtnStartMyTruck.UseVisualStyleBackColor = false;
            this.BtnStartMyTruck.Click += new System.EventHandler(this.BtnStartMyTruck_Click);
            // 
            // BtnStopHisCar
            // 
            this.BtnStopHisCar.AutoSize = true;
            this.BtnStopHisCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnStopHisCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnStopHisCar.Location = new System.Drawing.Point(314, 70);
            this.BtnStopHisCar.Name = "BtnStopHisCar";
            this.BtnStopHisCar.Size = new System.Drawing.Size(135, 34);
            this.BtnStopHisCar.TabIndex = 0;
            this.BtnStopHisCar.Text = "Stop His Car";
            this.BtnStopHisCar.UseVisualStyleBackColor = false;
            this.BtnStopHisCar.Click += new System.EventHandler(this.BtnStopHisCar_Click);
            // 
            // BtnAccHisCar
            // 
            this.BtnAccHisCar.AutoSize = true;
            this.BtnAccHisCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnAccHisCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAccHisCar.Location = new System.Drawing.Point(161, 70);
            this.BtnAccHisCar.Name = "BtnAccHisCar";
            this.BtnAccHisCar.Size = new System.Drawing.Size(147, 34);
            this.BtnAccHisCar.TabIndex = 0;
            this.BtnAccHisCar.Text = "Accelerate His Car";
            this.BtnAccHisCar.UseVisualStyleBackColor = false;
            this.BtnAccHisCar.Click += new System.EventHandler(this.BtnAccHisCar_Click);
            // 
            // BtnStartHisCar
            // 
            this.BtnStartHisCar.AutoSize = true;
            this.BtnStartHisCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnStartHisCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnStartHisCar.Location = new System.Drawing.Point(19, 70);
            this.BtnStartHisCar.Name = "BtnStartHisCar";
            this.BtnStartHisCar.Size = new System.Drawing.Size(137, 34);
            this.BtnStartHisCar.TabIndex = 0;
            this.BtnStartHisCar.Text = "Start His Car";
            this.BtnStartHisCar.UseVisualStyleBackColor = false;
            this.BtnStartHisCar.Click += new System.EventHandler(this.BtnStartHisCar_Click);
            // 
            // FrmClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBack);
            this.Name = "FrmClasses";
            this.Text = "Classes Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnStopMyCar;
        private System.Windows.Forms.Button BtnAccMyCar;
        private System.Windows.Forms.Button BtnStartMyCar;
        private System.Windows.Forms.Button BtnStartMyTruck;
        private System.Windows.Forms.Button BtnStopHisCar;
        private System.Windows.Forms.Button BtnAccHisCar;
        private System.Windows.Forms.Button BtnStartHisCar;
    }
}