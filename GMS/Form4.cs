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
    public partial class Form4 : Form
    {
        private int total = 0;
        private string name;
        public Form4()
        {
            InitializeComponent();
            dgBill.Columns.Add("Name", "Name");
            dgBill.Columns.Add("Quantity", "Quantity");
            dgBill.Columns.Add("Price", "Price");

            displayParts();
        }

        private void displayParts()
        {
            const string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Collage\\Sem-5\\C#-NET\\GMS\\GMS\\GMS.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string query = "select * from inventory";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void addpart_button_Click(object sender, EventArgs e)
        {
            const string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Collage\\Sem-5\\C#-NET\\GMS\\GMS\\GMS.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            int i = dg.SelectedCells[0].RowIndex;
            string id =  dg.Rows[i].Cells[0].Value.ToString();

            string query = "select * from inventory where partNumber = " + id;

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() && partquan_text != null)
            {
                DataGridViewRow drgb = new DataGridViewRow();

                int index = dgBill.Rows.Count - 2;
                if(index < 0)
                {
                    index = 0;
                }
                
                dgBill.Rows.Insert(index,dr[1].ToString(), partquan_text.Text, int.Parse(partquan_text.Text) * int.Parse(dr["price"].ToString()));
                total += int.Parse(partquan_text.Text) * int.Parse(dr["price"].ToString());
                txtTotal.Text = total.ToString();
                
            }


            query = "update inventory set quantity = " + (int.Parse(dr["quantity"].ToString()) - int.Parse(partquan_text.Text)) + "where partNumber = " + id;
            SqlCommand cmd2 = new SqlCommand(query,conn);
            dr.Close();
            cmd2.ExecuteNonQuery();
            conn.Close();
            displayParts();
        }

        private void addbill_button_Click(object sender, EventArgs e)
        {
            DataGridViewRow drgb = new DataGridViewRow();
            int index = dgBill.Rows.Count-1;
            dgBill.Rows.Insert(index, "Service charge", "0", servicecharge_text.Text);
            total += int.Parse(servicecharge_text.Text);
            txtTotal.Text = total.ToString();
            addbill_button.Enabled = false;
        }

        private void savebill_button_Click(object sender, EventArgs e)
        {
            if (cnumber_text.Text == "")
            {
                lblCN.Visible = true;
            }
            else
            {
                lblCN.Visible = false;
                const string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Collage\\Sem-5\\C#-NET\\GMS\\GMS\\GMS.mdf;Integrated Security=True";

                SqlConnection conn = new SqlConnection(str);
                conn.Open();

                string query = "select * from Vehical where carNumber = @carNumber";
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.Parameters.AddWithValue("@carNumber",cnumber_text.Text);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    name = dr["ownerName"].ToString();
                }

                dr.Close();

               query = "insert into history (carNumber,ownerName,cost,date) values(@carNumber2,@ownerName,@cost,@date)";
                cmd = new SqlCommand(query,conn);
                cmd.Parameters.AddWithValue("@carNumber2", cnumber_text.Text);
                cmd.Parameters.AddWithValue("@ownerName",name);
                cmd.Parameters.AddWithValue("@cost",total);
                cmd.Parameters.AddWithValue("@date", entery_date.Text);

               cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("bill genrated");
                dgBill.Rows.Clear();
                total = 0;
                txtTotal.Text = total.ToString();

            }
        }
    }
}
