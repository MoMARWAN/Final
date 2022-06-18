using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    static class DB
    {

        private static string provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/moh/Desktop/dddd/stuDataBase.mdb";
        private static OleDbConnection conn = new OleDbConnection(provider);

        public static void openDb() { conn.Open(); }
        public static void FillDGV(string sql, DataGridView dgv) {
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }


        public static void FillCompBox(string sql, ComboBox cb, string display_item, string val_item)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cb.DataSource = ds.Tables[0];
            cb.DisplayMember = display_item;
            cb.ValueMember = val_item;
            cb.SelectedIndex = -1;

        }
        public static void AddStudennt(string sql) {
            OleDbCommand dbc = new OleDbCommand(sql, conn);
            dbc.ExecuteNonQuery();
        }
        public static void Addemployees(string sql)
        {
            OleDbCommand dbc = new OleDbCommand(sql, conn);
            dbc.ExecuteNonQuery();
        }

        public static void DelStudennt(string sql)
        {
            OleDbCommand dbc = new OleDbCommand(sql, conn);
            dbc.ExecuteNonQuery();



            
            OleDbConnection My_Connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/moh/Desktop/dddd/stuDataBase.mdb");

            My_Connection.Open();

            OleDbCommand My_Command = new OleDbCommand(sql, My_Connection);
            My_Command.ExecuteNonQuery();
        }
        public static void Delemployees(string sql)
        {
            OleDbCommand dbc = new OleDbCommand(sql, conn);
            dbc.ExecuteNonQuery();




            OleDbConnection My_Connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/moh/Desktop/dddd/stuDataBase.mdb");

            My_Connection.Open();

            OleDbCommand My_Command = new OleDbCommand(sql, My_Connection);
            My_Command.ExecuteNonQuery();
        }


    }
}
