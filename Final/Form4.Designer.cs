
namespace Final
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.butBak = new System.Windows.Forms.Button();
            this.textnamber = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.G_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_Dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_pho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butClos = new System.Windows.Forms.Button();
            this.save4 = new System.Windows.Forms.Button();
            this.delete_Click4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الموظف :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "رقم الموظف:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "تاريخ الميلاد:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "رقم الجوال:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(137, 17);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(234, 27);
            this.TxtName.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(137, 64);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(234, 27);
            this.txtId.TabIndex = 7;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(137, 153);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(127, 27);
            this.dateTimePicker4.TabIndex = 8;
            // 
            // butBak
            // 
            this.butBak.Location = new System.Drawing.Point(10, 352);
            this.butBak.Margin = new System.Windows.Forms.Padding(2);
            this.butBak.Name = "butBak";
            this.butBak.Size = new System.Drawing.Size(88, 38);
            this.butBak.TabIndex = 9;
            this.butBak.Text = "رجوع";
            this.butBak.UseVisualStyleBackColor = true;
            this.butBak.Click += new System.EventHandler(this.button1_Click);
            // 
            // textnamber
            // 
            this.textnamber.Location = new System.Drawing.Point(137, 107);
            this.textnamber.Margin = new System.Windows.Forms.Padding(2);
            this.textnamber.Name = "textnamber";
            this.textnamber.Size = new System.Drawing.Size(215, 27);
            this.textnamber.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.G_name,
            this.G_Dat,
            this.G_Id,
            this.G_pho});
            this.dataGridView1.Location = new System.Drawing.Point(397, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 451);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // G_name
            // 
            this.G_name.HeaderText = "اسم الموظف";
            this.G_name.Name = "G_name";
            // 
            // G_Dat
            // 
            this.G_Dat.HeaderText = "تاريخ الميلاد";
            this.G_Dat.Name = "G_Dat";
            // 
            // G_Id
            // 
            this.G_Id.HeaderText = "رقم الموظف";
            this.G_Id.Name = "G_Id";
            // 
            // G_pho
            // 
            this.G_pho.HeaderText = "رقم الجوال";
            this.G_pho.Name = "G_pho";
            // 
            // butClos
            // 
            this.butClos.Location = new System.Drawing.Point(294, 352);
            this.butClos.Margin = new System.Windows.Forms.Padding(2);
            this.butClos.Name = "butClos";
            this.butClos.Size = new System.Drawing.Size(76, 38);
            this.butClos.TabIndex = 12;
            this.butClos.Text = "اغلاق";
            this.butClos.UseVisualStyleBackColor = true;
            this.butClos.Click += new System.EventHandler(this.butClos_Click);
            // 
            // save4
            // 
            this.save4.Location = new System.Drawing.Point(159, 352);
            this.save4.Name = "save4";
            this.save4.Size = new System.Drawing.Size(75, 38);
            this.save4.TabIndex = 13;
            this.save4.Text = "احفظ";
            this.save4.UseVisualStyleBackColor = true;
            this.save4.Click += new System.EventHandler(this.save4_Click);
            // 
            // delete_Click4
            // 
            this.delete_Click4.Location = new System.Drawing.Point(159, 403);
            this.delete_Click4.Name = "delete_Click4";
            this.delete_Click4.Size = new System.Drawing.Size(75, 41);
            this.delete_Click4.TabIndex = 14;
            this.delete_Click4.Text = "احذف";
            this.delete_Click4.UseVisualStyleBackColor = true;
            this.delete_Click4.Click += new System.EventHandler(this.delete_Click4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 456);
            this.Controls.Add(this.delete_Click4);
            this.Controls.Add(this.save4);
            this.Controls.Add(this.butClos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textnamber);
            this.Controls.Add(this.butBak);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form4";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة موظفين";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Button butBak;
        private System.Windows.Forms.TextBox textnamber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butClos;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_Dat;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_pho;
        private System.Windows.Forms.Button save4;
        private System.Windows.Forms.Button delete_Click4;
    }
}