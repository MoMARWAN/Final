using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Final
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_student();

        }

        void add_student()
        {
            if (txt_id.Text == "") {
                MSG.Error("يجب إدخال رقم الطالب");
                txt_id.Focus();
                return;
            }

            if (dateTimePicker1.Text == "")
            {
                MSG.Error("يجب إدخال تاريخ الميلاد");
                dateTimePicker1.Focus();
                return;
            }

          
            if (txt_name.Text == "")
            {
                MSG.Error("يجب إدخال اسم الطالب");
                txt_name.Focus();
                return;
            }



            if (cty_cb.Text == "")
            {
                MSG.Error("يجب إدخال المحافظة");
                cty_cb.Focus();
                return;
            }

            if (!maskedTextBox1.MaskCompleted)
            {
                MSG.Error("يجب إدخال تاريخ شهادة الثانوية");
                maskedTextBox1.Focus();
                return;
            }
            string gender;
            if (male_r.Checked)
            { gender = "ذكر"; }
            else
            { gender = "أنثى"; }
            string sql = "insert into student (stu_id, stu_name, stu_DOB, stu_city, stu_tawgihy, stu_average, stu_gender, stu_lan_AR, stu_lan_EN)" +
                "values ('{0}','{1}','{2}','{3}','{4}',{5},'{6}',{7},{8})";
            sql = string.Format(sql, txt_id.Text,
                txt_name.Text,
                dateTimePicker1.Text,
                cty_cb.Text,
                maskedTextBox1.Text,
                numericUpDown1.Value,
                gender,
                chk_lan_arabic.Checked,
                chk_lan_en.Checked);
            DB.AddStudennt(sql);
            DB.FillDGV("select * from student", dataGridView1);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            dateTimePicker1.Text = "";
            numericUpDown1.Value = 60;
         
            male_r.Select();
            cty_cb.Text = "";
            chk_lan_arabic.Checked = true;
            chk_lan_en.Checked = false;

        }

        private void StudentForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                add_student();
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                clear();
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            DB.openDb();
            DB.FillDGV("select * from student", dataGridView1);
            DB.FillCompBox("select * from gov", cty_cb, "gname", "gid");
            DB.FillCompBox("select * from meg", co_mejor, "mname", "mid");
            b_delt.Visible = false;
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                txt_id.Text = dataGridView1.CurrentRow.Cells["g_std_id"].Value.ToString();
                txt_name.Text = dataGridView1.CurrentRow.Cells["g_std_name"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["g_birth"].Value.ToString();
                string gender = dataGridView1.CurrentRow.Cells["g_std_gender"].Value.ToString();
                if (gender == male_r.Text)
                {
                    male_r.Select();
                }
                else if (gender == female_r.Text)
                {
                    female_r.Select();
                }
                chk_lan_arabic .Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[g_arabic.Name].Value);
                chk_lan_en.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[g_english.Name].Value);
            }
            b_delt.Visible = true;
        }
        private void btn_delete_Click(object sender, EventArgs e){    

         //  string provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/Final/mm/stuDataBase.mdb";
          //  using (OleDbConnection thisConnection = new OleDbConnection(provider))
            {
               string deletequery = "DELETE FROM student WHERE stu_id = '{0}'";
                deletequery = string.Format(deletequery, txt_id.Text);
             
                DB.AddStudennt(deletequery);


                DB.FillDGV("select * from student", dataGridView1);
               
            }
        }

        private void format(string sql, string text)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                if (dataGridView1.Rows.Count > 1)
                {
                    txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    numericUpDown1.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    string gender = dataGridView1.CurrentRow.Cells["g_std_gender"].Value.ToString();
                    if (gender == male_r.Text)
                    {
                        male_r.Select();
                    }
                    else if (gender == female_r.Text)
                    {
                        female_r.Select();
                    }
                    chk_lan_arabic.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[g_arabic.Name].Value);
                    chk_lan_en.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[g_english.Name].Value);
                }
            }

        private void chk_lan_arabic_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cty_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void coB_me_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string sql = "select * from student where stu_name like '%{0}%'";
            sql = string.Format(sql, TB_SH.Text);
            DB.FillDGV(sql, dataGridView1);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Lab_Search_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void TB_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void female_r_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentForm_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    } 
    }

    