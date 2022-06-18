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
    public partial class Form4 : Form
    {
     

        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void butClos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save4_Click(object sender, EventArgs e)
        {
            add_employee();
            /*
             * employees
            TxtName
                txtId
                textnamber
                dateTimePicker4
                */
        }
        void add_employee()
        {
            if (TxtName.Text == "")
            {
                MSG.Error("يجب إدخال اسم المؤظف");
                TxtName.Focus();
                return;
            }
            if (txtId.Text == "")
            {
                MSG.Error("يجب إدخال رقم المؤظف");
                txtId.Focus();
                return;
            }
            if (textnamber.Text == "")
            {
                MSG.Error("يجب إدخال رقم المؤظف");
                textnamber.Focus();
                return;
            }
            if (dateTimePicker4.Text == "")
            {
                MSG.Error("يجب إدخال تاريخ الميلاد");
                dateTimePicker4.Focus();
                return;
            }
         

            string sql = "insert into employees (TxtName, dateTimePicker4, txtId, textnamber)" +
                 "values ('{0}','{1}','{2}','{3}')";
            sql = string.Format(sql, TxtName.Text,
                dateTimePicker4.Text,
                txtId.Text,
                textnamber.Text
                );
            DB.Addemployees(sql);
            DB.FillDGV("select * from employees", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                txtId.Text = dataGridView1.CurrentRow.Cells["g_TxtName"].Value.ToString();
                TxtName.Text = dataGridView1.CurrentRow.Cells["g_dateTimePicker4"].Value.ToString();
                dateTimePicker4.Text = dataGridView1.CurrentRow.Cells["g_txtId"].Value.ToString();
                textnamber.Text = dataGridView1.CurrentRow.Cells["g_textnamber"].Value.ToString();

              

            }
           

        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                TxtName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dateTimePicker4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtId.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textnamber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               
                
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            DB.openDb();
            DB.FillDGV("select * from employees", dataGridView1);   
           
        }

        private void delete_Click4_Click(object sender, EventArgs e)
        {
            string deletequery = "DELETE FROM employees WHERE TxtName = '{0}'";
            deletequery = string.Format(deletequery, TxtName.Text);

            DB.Addemployees(deletequery);


            DB.FillDGV("select * from employees", dataGridView1);
        }
    }
}




