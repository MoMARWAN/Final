using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void butStd_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm Frm1 = new StudentForm();
            Frm1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://portal.alaqsa.edu.ps/student/login.aspx");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://alaqsa.edu.ps/ar/home/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://portal.alaqsa.edu.ps/employee/login.aspx");
        }

        private void but2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void butEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
