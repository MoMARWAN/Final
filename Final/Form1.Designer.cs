namespace Final
{
    partial class StudentForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.male_r = new System.Windows.Forms.RadioButton();
            this.female_r = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.g_std_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_std_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_txt_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_dog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_std_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_arabic = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.g_english = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.b_save = new System.Windows.Forms.Button();
            this.b_delt = new System.Windows.Forms.Button();
            this.b_rem = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_lan_en = new System.Windows.Forms.CheckBox();
            this.chk_lan_arabic = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cty_cb = new System.Windows.Forms.ComboBox();
            this.Lab_Search = new System.Windows.Forms.Label();
            this.TB_SH = new System.Windows.Forms.TextBox();
            this.co_mejor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الطالب:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم الطالب:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "تاريخ الميلاد:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "المحافظة:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(712, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "تاريخ شهادة الثانوية:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "المعدل التراكمي:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "التخصص:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(140, 42);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(247, 24);
            this.txt_id.TabIndex = 1;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(677, 45);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(390, 24);
            this.txt_name.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 24);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(196, 147);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            65536});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 24);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            550,
            0,
            0,
            65536});
            // 
            // male_r
            // 
            this.male_r.AutoSize = true;
            this.male_r.Checked = true;
            this.male_r.Location = new System.Drawing.Point(752, 236);
            this.male_r.Name = "male_r";
            this.male_r.Size = new System.Drawing.Size(49, 21);
            this.male_r.TabIndex = 5;
            this.male_r.TabStop = true;
            this.male_r.Text = "ذكر";
            this.male_r.UseVisualStyleBackColor = true;
            // 
            // female_r
            // 
            this.female_r.AutoSize = true;
            this.female_r.Location = new System.Drawing.Point(752, 209);
            this.female_r.Name = "female_r";
            this.female_r.Size = new System.Drawing.Size(55, 21);
            this.female_r.TabIndex = 5;
            this.female_r.Text = "أنثى";
            this.female_r.UseVisualStyleBackColor = true;
            this.female_r.CheckedChanged += new System.EventHandler(this.female_r_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.g_std_id,
            this.g_std_name,
            this.g_txt_city,
            this.g_birth,
            this.g_grade,
            this.g_dog,
            this.g_std_gender,
            this.g_arabic,
            this.g_english});
            this.dataGridView1.Location = new System.Drawing.Point(27, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 227);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // g_std_id
            // 
            this.g_std_id.DataPropertyName = "stu_id";
            this.g_std_id.HeaderText = "رقم الطالب";
            this.g_std_id.MinimumWidth = 6;
            this.g_std_id.Name = "g_std_id";
            // 
            // g_std_name
            // 
            this.g_std_name.DataPropertyName = "stu_name";
            this.g_std_name.HeaderText = "اسم الطالب";
            this.g_std_name.MinimumWidth = 6;
            this.g_std_name.Name = "g_std_name";
            this.g_std_name.Width = 180;
            // 
            // g_txt_city
            // 
            this.g_txt_city.DataPropertyName = "stu_city";
            this.g_txt_city.HeaderText = "المحافظة";
            this.g_txt_city.Name = "g_txt_city";
            // 
            // g_birth
            // 
            this.g_birth.DataPropertyName = "stu_DOB";
            this.g_birth.HeaderText = "تاريخ الميلاد";
            this.g_birth.MinimumWidth = 20;
            this.g_birth.Name = "g_birth";
            // 
            // g_grade
            // 
            this.g_grade.DataPropertyName = "stu_average";
            this.g_grade.HeaderText = "المعدل التراكمي";
            this.g_grade.MinimumWidth = 6;
            this.g_grade.Name = "g_grade";
            // 
            // g_dog
            // 
            this.g_dog.DataPropertyName = "stu_tawgihy";
            this.g_dog.HeaderText = "تاريخ شهادة الثانوية";
            this.g_dog.MinimumWidth = 6;
            this.g_dog.Name = "g_dog";
            this.g_dog.Width = 120;
            // 
            // g_std_gender
            // 
            this.g_std_gender.DataPropertyName = "stu_gender";
            this.g_std_gender.HeaderText = "جنس الطالب";
            this.g_std_gender.MinimumWidth = 6;
            this.g_std_gender.Name = "g_std_gender";
            // 
            // g_arabic
            // 
            this.g_arabic.DataPropertyName = "stu_lan_AR";
            this.g_arabic.HeaderText = "لغة عربية";
            this.g_arabic.MinimumWidth = 6;
            this.g_arabic.Name = "g_arabic";
            this.g_arabic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.g_arabic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // g_english
            // 
            this.g_english.DataPropertyName = "stu_lan_EN";
            this.g_english.HeaderText = "لغة انجليزية";
            this.g_english.MinimumWidth = 6;
            this.g_english.Name = "g_english";
            this.g_english.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.g_english.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(27, 321);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(204, 49);
            this.b_save.TabIndex = 7;
            this.b_save.Text = "حفظ CTRL+A";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // b_delt
            // 
            this.b_delt.Location = new System.Drawing.Point(271, 321);
            this.b_delt.Name = "b_delt";
            this.b_delt.Size = new System.Drawing.Size(204, 49);
            this.b_delt.TabIndex = 8;
            this.b_delt.Text = "حذف";
            this.b_delt.UseVisualStyleBackColor = true;
            this.b_delt.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // b_rem
            // 
            this.b_rem.Location = new System.Drawing.Point(578, 321);
            this.b_rem.Name = "b_rem";
            this.b_rem.Size = new System.Drawing.Size(204, 49);
            this.b_rem.TabIndex = 9;
            this.b_rem.Text = "مسح CTRL+N";
            this.b_rem.UseVisualStyleBackColor = true;
            this.b_rem.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(891, 144);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox1.Size = new System.Drawing.Size(113, 24);
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.chk_lan_en);
            this.groupBox1.Controls.Add(this.chk_lan_arabic);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(909, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اللغات";
            // 
            // chk_lan_en
            // 
            this.chk_lan_en.AutoSize = true;
            this.chk_lan_en.Location = new System.Drawing.Point(68, 48);
            this.chk_lan_en.Name = "chk_lan_en";
            this.chk_lan_en.Size = new System.Drawing.Size(113, 21);
            this.chk_lan_en.TabIndex = 1;
            this.chk_lan_en.Text = "اللغة انجليزية";
            this.chk_lan_en.UseVisualStyleBackColor = true;
            // 
            // chk_lan_arabic
            // 
            this.chk_lan_arabic.AutoSize = true;
            this.chk_lan_arabic.Checked = true;
            this.chk_lan_arabic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_lan_arabic.Location = new System.Drawing.Point(83, 21);
            this.chk_lan_arabic.Name = "chk_lan_arabic";
            this.chk_lan_arabic.Size = new System.Drawing.Size(98, 21);
            this.chk_lan_arabic.TabIndex = 0;
            this.chk_lan_arabic.Text = "اللغة عربية";
            this.chk_lan_arabic.UseVisualStyleBackColor = true;
            this.chk_lan_arabic.CheckedChanged += new System.EventHandler(this.chk_lan_arabic_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(410, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(137, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(1073, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(1019, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "*";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(1019, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "*";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cty_cb
            // 
            this.cty_cb.FormattingEnabled = true;
            this.cty_cb.Location = new System.Drawing.Point(677, 100);
            this.cty_cb.Name = "cty_cb";
            this.cty_cb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cty_cb.Size = new System.Drawing.Size(336, 25);
            this.cty_cb.TabIndex = 14;
            this.cty_cb.SelectedIndexChanged += new System.EventHandler(this.cty_cb_SelectedIndexChanged);
            // 
            // Lab_Search
            // 
            this.Lab_Search.AutoSize = true;
            this.Lab_Search.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Search.Location = new System.Drawing.Point(54, 268);
            this.Lab_Search.Name = "Lab_Search";
            this.Lab_Search.Size = new System.Drawing.Size(48, 18);
            this.Lab_Search.TabIndex = 15;
            this.Lab_Search.Text = "بحث :";
            this.Lab_Search.Click += new System.EventHandler(this.Lab_Search_Click);
            // 
            // TB_SH
            // 
            this.TB_SH.Location = new System.Drawing.Point(108, 266);
            this.TB_SH.Name = "TB_SH";
            this.TB_SH.Size = new System.Drawing.Size(367, 24);
            this.TB_SH.TabIndex = 16;
            this.TB_SH.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
            this.TB_SH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // co_mejor
            // 
            this.co_mejor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.co_mejor.FormattingEnabled = true;
            this.co_mejor.Location = new System.Drawing.Point(140, 209);
            this.co_mejor.Name = "co_mejor";
            this.co_mejor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.co_mejor.Size = new System.Drawing.Size(234, 25);
            this.co_mejor.TabIndex = 17;
            this.co_mejor.SelectedIndexChanged += new System.EventHandler(this.coB_me_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(879, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "القائمة السابقة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1111, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.co_mejor);
            this.Controls.Add(this.TB_SH);
            this.Controls.Add(this.Lab_Search);
            this.Controls.Add(this.cty_cb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.b_rem);
            this.Controls.Add(this.b_delt);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.female_r);
            this.Controls.Add(this.male_r);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "StudentForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Ad";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.DoubleClick += new System.EventHandler(this.StudentForm_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StudentForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton male_r;
        private System.Windows.Forms.RadioButton female_r;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_delt;
        private System.Windows.Forms.Button b_rem;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_lan_en;
        private System.Windows.Forms.CheckBox chk_lan_arabic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cty_cb;
        private System.Windows.Forms.Label Lab_Search;
        private System.Windows.Forms.TextBox TB_SH;
        private System.Windows.Forms.ComboBox co_mejor;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_std_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_std_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_txt_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_dog;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_std_gender;
        private System.Windows.Forms.DataGridViewCheckBoxColumn g_arabic;
        private System.Windows.Forms.DataGridViewCheckBoxColumn g_english;
        private System.Windows.Forms.Button button1;
    }
}

