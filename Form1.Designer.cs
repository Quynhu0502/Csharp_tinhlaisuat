namespace Csharp_tinhlaisuat
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
            this.lblsotien = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.lblnam = new System.Windows.Forms.Label();
            this.lbllaisuat = new System.Windows.Forms.Label();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.lbltienlai = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsotien
            // 
            this.lblsotien.AutoSize = true;
            this.lblsotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblsotien.Location = new System.Drawing.Point(56, 90);
            this.lblsotien.Name = "lblsotien";
            this.lblsotien.Size = new System.Drawing.Size(98, 31);
            this.lblsotien.TabIndex = 0;
            this.lblsotien.Text = "Số tiền";
            // 
            // txb1
            // 
            this.txb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txb1.Location = new System.Drawing.Point(258, 87);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(145, 38);
            this.txb1.TabIndex = 1;
            this.txb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblnam
            // 
            this.lblnam.AutoSize = true;
            this.lblnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblnam.Location = new System.Drawing.Point(56, 156);
            this.lblnam.Name = "lblnam";
            this.lblnam.Size = new System.Drawing.Size(106, 31);
            this.lblnam.TabIndex = 0;
            this.lblnam.Text = "Số năm";
            // 
            // lbllaisuat
            // 
            this.lbllaisuat.AutoSize = true;
            this.lbllaisuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbllaisuat.Location = new System.Drawing.Point(56, 228);
            this.lbllaisuat.Name = "lbllaisuat";
            this.lbllaisuat.Size = new System.Drawing.Size(109, 31);
            this.lbllaisuat.TabIndex = 0;
            this.lbllaisuat.Text = "Lãi suất";
            // 
            // txb2
            // 
            this.txb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txb2.Location = new System.Drawing.Point(258, 156);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(145, 38);
            this.txb2.TabIndex = 1;
            // 
            // txb3
            // 
            this.txb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txb3.Location = new System.Drawing.Point(258, 228);
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(145, 38);
            this.txb3.TabIndex = 1;
            this.txb3.TextChanged += new System.EventHandler(this.txb3_TextChanged);
            // 
            // lbltienlai
            // 
            this.lbltienlai.AutoSize = true;
            this.lbltienlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbltienlai.Location = new System.Drawing.Point(262, 331);
            this.lbltienlai.Name = "lbltienlai";
            this.lbltienlai.Size = new System.Drawing.Size(101, 31);
            this.lbltienlai.TabIndex = 0;
            this.lbltienlai.Text = "Tiền lãi";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblKQ.Location = new System.Drawing.Point(445, 331);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(127, 31);
            this.lblKQ.TabIndex = 0;
            this.lblKQ.Text = "Tổng tiền";
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnTinh.Location = new System.Drawing.Point(59, 328);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(118, 37);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txb3);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.lbllaisuat);
            this.Controls.Add(this.lblnam);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.lbltienlai);
            this.Controls.Add(this.lblsotien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsotien;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Label lblnam;
        private System.Windows.Forms.Label lbllaisuat;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.TextBox txb3;
        private System.Windows.Forms.Label lbltienlai;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnTinh;
    }
}

