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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            displyData();
        }
        private void displyData()
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
            dsGrid.DataSource = dt;

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            const string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Collage\\Sem-5\\C#-NET\\GMS\\GMS\\GMS.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            String query = "INSERT INTO inventory (partNumber,partName,quantity,price) values(@partNumber,@partName,@quantity,@price) ";

            SqlCommand cmd = new SqlCommand(query, conn);


            if(lblPartName.Text == "")
            {
                lblPartName.Visible = true;
            }
            

            cmd.Parameters.AddWithValue("@partNumber", pnumber_text.Text);
            cmd.Parameters.AddWithValue("@partName", pname_text.Text);
            cmd.Parameters.AddWithValue("@quantity", quantity_text.Text);
            cmd.Parameters.AddWithValue("@price", price_text.Text);


            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Add item");
            displyData();


        }

        private void update_button_Click(object sender, EventArgs e)
        {
            const string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Collage\\Sem-5\\C#-NET\\GMS\\GMS\\GMS.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            String query = "update inventory set partName = @partName,quantity=@quantity,price=@price where partNumber = @partNumber";

            SqlCommand cmd = new SqlCommand(query, conn);



            cmd.Parameters.AddWithValue("@partNumber", pnumber_text.Text);
            cmd.Parameters.AddWithValue("@partName", pname_text.Text);
            cmd.Parameters.AddWithValue("@quantity", quantity_text.Text);
            cmd.Parameters.AddWithValue("@price", price_text.Text);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
            displyData();

            conn.Close();
        }

        private void pnumber_text_MouseLeave(object sender, EventArgs e)
        {
            if(pnumber_text.Text == "")
            {

            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            const string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Collage\\Sem-5\\C#-NET\\GMS\\GMS\\GMS.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            String query = "delete inventory where partNumber = @partNumber";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@partNumber", pnumber_text.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            displyData();
            MessageBox.Show("item deleted");

        }
    }

}
