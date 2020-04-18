namespace WindowsFormsApp2
{
    partial class FrmCombo
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
            this.BtnRemove2ndLast = new System.Windows.Forms.Button();
            this.BtnRemoveLast = new System.Windows.Forms.Button();
            this.BtnRemoveName = new System.Windows.Forms.Button();
            this.BtnRemoveIndex = new System.Windows.Forms.Button();
            this.BtnMethod3 = new System.Windows.Forms.Button();
            this.BtnMethod2 = new System.Windows.Forms.Button();
            this.BtnMethod1 = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRemove2ndLast
            // 
            this.BtnRemove2ndLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove2ndLast.Location = new System.Drawing.Point(333, 160);
            this.BtnRemove2ndLast.Name = "BtnRemove2ndLast";
            this.BtnRemove2ndLast.Size = new System.Drawing.Size(77, 65);
            this.BtnRemove2ndLast.TabIndex = 18;
            this.BtnRemove2ndLast.Text = "Remove 2nd last item";
            this.BtnRemove2ndLast.UseVisualStyleBackColor = true;
            this.BtnRemove2ndLast.Click += new System.EventHandler(this.BtnRemove2ndLast_Click);
            // 
            // BtnRemoveLast
            // 
            this.BtnRemoveLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveLast.Location = new System.Drawing.Point(333, 89);
            this.BtnRemoveLast.Name = "BtnRemoveLast";
            this.BtnRemoveLast.Size = new System.Drawing.Size(77, 65);
            this.BtnRemoveLast.TabIndex = 17;
            this.BtnRemoveLast.Text = "Remove last item";
            this.BtnRemoveLast.UseVisualStyleBackColor = true;
            this.BtnRemoveLast.Click += new System.EventHandler(this.BtnRemoveLast_Click);
            // 
            // BtnRemoveName
            // 
            this.BtnRemoveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveName.Location = new System.Drawing.Point(182, 185);
            this.BtnRemoveName.Name = "BtnRemoveName";
            this.BtnRemoveName.Size = new System.Drawing.Size(135, 40);
            this.BtnRemoveName.TabIndex = 16;
            this.BtnRemoveName.Text = "Remove Wednesday";
            this.BtnRemoveName.UseVisualStyleBackColor = true;
            this.BtnRemoveName.Click += new System.EventHandler(this.BtnRemoveName_Click);
            // 
            // BtnRemoveIndex
            // 
            this.BtnRemoveIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveIndex.Location = new System.Drawing.Point(29, 185);
            this.BtnRemoveIndex.Name = "BtnRemoveIndex";
            this.BtnRemoveIndex.Size = new System.Drawing.Size(147, 40);
            this.BtnRemoveIndex.TabIndex = 15;
            this.BtnRemoveIndex.Text = "Remove First Index";
            this.BtnRemoveIndex.UseVisualStyleBackColor = true;
            this.BtnRemoveIndex.Click += new System.EventHandler(this.BtnRemoveIndex_Click);
            // 
            // BtnMethod3
            // 
            this.BtnMethod3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMethod3.Location = new System.Drawing.Point(287, 28);
            this.BtnMethod3.Name = "BtnMethod3";
            this.BtnMethod3.Size = new System.Drawing.Size(123, 38);
            this.BtnMethod3.TabIndex = 13;
            this.BtnMethod3.Text = "Show Method3";
            this.BtnMethod3.UseVisualStyleBackColor = true;
            this.BtnMethod3.Click += new System.EventHandler(this.BtnMethod3_Click);
            // 
            // BtnMethod2
            // 
            this.BtnMethod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMethod2.Location = new System.Drawing.Point(158, 28);
            this.BtnMethod2.Name = "BtnMethod2";
            this.BtnMethod2.Size = new System.Drawing.Size(123, 38);
            this.BtnMethod2.TabIndex = 14;
            this.BtnMethod2.Text = "Show Method2";
            this.BtnMethod2.UseVisualStyleBackColor = true;
            this.BtnMethod2.Click += new System.EventHandler(this.BtnMethod2_Click);
            // 
            // BtnMethod1
            // 
            this.BtnMethod1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMethod1.Location = new System.Drawing.Point(29, 28);
            this.BtnMethod1.Name = "BtnMethod1";
            this.BtnMethod1.Size = new System.Drawing.Size(123, 38);
            this.BtnMethod1.TabIndex = 11;
            this.BtnMethod1.Text = "Show Method1";
            this.BtnMethod1.UseVisualStyleBackColor = true;
            this.BtnMethod1.Click += new System.EventHandler(this.BtnMethod1_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(29, 89);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(173, 28);
            this.CmbDays.TabIndex = 10;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.Control;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(283, 266);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(127, 32);
            this.BtnBack.TabIndex = 19;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 310);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRemove2ndLast);
            this.Controls.Add(this.BtnRemoveLast);
            this.Controls.Add(this.BtnRemoveName);
            this.Controls.Add(this.BtnRemoveIndex);
            this.Controls.Add(this.BtnMethod3);
            this.Controls.Add(this.BtnMethod2);
            this.Controls.Add(this.BtnMethod1);
            this.Controls.Add(this.CmbDays);
            this.Name = "FrmCombo";
            this.Text = "Combo Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRemove2ndLast;
        private System.Windows.Forms.Button BtnRemoveLast;
        private System.Windows.Forms.Button BtnRemoveName;
        private System.Windows.Forms.Button BtnRemoveIndex;
        private System.Windows.Forms.Button BtnMethod3;
        private System.Windows.Forms.Button BtnMethod2;
        private System.Windows.Forms.Button BtnMethod1;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button BtnBack;
    }
}