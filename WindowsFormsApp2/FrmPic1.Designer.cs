namespace WindowsFormsApp2
{
    partial class FrmPic1
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
            this.BtnImageFromRes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Picture2 = new System.Windows.Forms.PictureBox();
            this.Picture1 = new System.Windows.Forms.PictureBox();
            this.BtnImageFromFile = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnImageFromRes
            // 
            this.BtnImageFromRes.AutoSize = true;
            this.BtnImageFromRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImageFromRes.Location = new System.Drawing.Point(12, 141);
            this.BtnImageFromRes.Name = "BtnImageFromRes";
            this.BtnImageFromRes.Size = new System.Drawing.Size(173, 45);
            this.BtnImageFromRes.TabIndex = 12;
            this.BtnImageFromRes.Text = "Image from Resource";
            this.BtnImageFromRes.UseVisualStyleBackColor = true;
            this.BtnImageFromRes.Click += new System.EventHandler(this.BtnImageFromRes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Picture2);
            this.groupBox1.Controls.Add(this.Picture1);
            this.groupBox1.Location = new System.Drawing.Point(205, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(513, 289);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture Boxes";
            // 
            // Picture2
            // 
            this.Picture2.Location = new System.Drawing.Point(267, 23);
            this.Picture2.Name = "Picture2";
            this.Picture2.Size = new System.Drawing.Size(224, 252);
            this.Picture2.TabIndex = 1;
            this.Picture2.TabStop = false;
            // 
            // Picture1
            // 
            this.Picture1.Location = new System.Drawing.Point(13, 23);
            this.Picture1.Name = "Picture1";
            this.Picture1.Size = new System.Drawing.Size(224, 252);
            this.Picture1.TabIndex = 0;
            this.Picture1.TabStop = false;
            // 
            // BtnImageFromFile
            // 
            this.BtnImageFromFile.AutoSize = true;
            this.BtnImageFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImageFromFile.Location = new System.Drawing.Point(12, 75);
            this.BtnImageFromFile.Name = "BtnImageFromFile";
            this.BtnImageFromFile.Size = new System.Drawing.Size(173, 45);
            this.BtnImageFromFile.TabIndex = 10;
            this.BtnImageFromFile.Text = "Image from File";
            this.BtnImageFromFile.UseVisualStyleBackColor = true;
            this.BtnImageFromFile.Click += new System.EventHandler(this.BtnImageFromFile_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(591, 378);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(127, 32);
            this.BtnBack.TabIndex = 20;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmPic1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 422);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnImageFromRes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnImageFromFile);
            this.Name = "FrmPic1";
            this.Text = "FrmPic1";
            this.Load += new System.EventHandler(this.FrmPic1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnImageFromRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnImageFromFile;
        private System.Windows.Forms.PictureBox Picture2;
        private System.Windows.Forms.PictureBox Picture1;
        private System.Windows.Forms.Button BtnBack;
    }
}