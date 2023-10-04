using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS
{
    public partial class Form5 : Form
    {
        private void display()
        {
            const string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Collage\\Sem-5\\C#-NET\\GMS\\GMS\\GMS.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string query = "select * from history";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
        }
        public Form5()
        {
            InitializeComponent();
            display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
