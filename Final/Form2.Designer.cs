
namespace Final
{
    partial class Form2
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
            this.butStd = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.butEnd = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkStd = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // butStd
            // 
            this.butStd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStd.Location = new System.Drawing.Point(551, 229);
            this.butStd.Name = "butStd";
            this.butStd.Size = new System.Drawing.Size(159, 55);
            this.butStd.TabIndex = 0;
            this.butStd.Text = "تسجيل طلاب";
            this.butStd.UseVisualStyleBackColor = true;
            this.butStd.Click += new System.EventHandler(this.butStd_Click);
            // 
            // but2
            // 
            this.but2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.Location = new System.Drawing.Point(72, 229);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(159, 55);
            this.but2.TabIndex = 1;
            this.but2.Text = "تسجيل موظفين";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // butEnd
            // 
            this.butEnd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEnd.Location = new System.Drawing.Point(316, 362);
            this.butEnd.Name = "butEnd";
            this.butEnd.Size = new System.Drawing.Size(159, 55);
            this.butEnd.TabIndex = 2;
            this.butEnd.Text = "خروج";
            this.butEnd.UseVisualStyleBackColor = true;
            this.butEnd.Click += new System.EventHandler(this.butEnd_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(292, 76);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(221, 23);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "صفحة الجامعة الرئسية ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkStd
            // 
            this.linkStd.AutoSize = true;
            this.linkStd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkStd.Location = new System.Drawing.Point(562, 76);
            this.linkStd.Name = "linkStd";
            this.linkStd.Size = new System.Drawing.Size(226, 23);
            this.linkStd.TabIndex = 4;
            this.linkStd.TabStop = true;
            this.linkStd.Text = "خدمات الطلبة الالكترونية";
            this.linkStd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(12, 76);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(256, 23);
            this.linkLabel3.TabIndex = 5;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "خدمات الموظفين الالكترونية";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkStd);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.butEnd);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.butStd);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butStd;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button butEnd;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkStd;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}