using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void displyData()
        {
            const string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Collage\\Sem-5\\C#-NET\\GMS\\GMS\\GMS.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string query = "select * from Vehical";
            SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dsGrid.DataSource = dt;

        }

        private void clearForm()
        {

            cnumber_text.Text = "";
            cmodel_text.Text = "";
            ccolor_text.Text = "";
            entery_date.Text = "";
            delivery_date.Text = "";
            oname_text.Text = "";
            mono_text.Text = "";


        }
        private void add_button_Click(object sender, EventArgs e)
        {
            const string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Collage\\Sem-5\\C#-NET\\GMS\\GMS\\GMS.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            String query = "INSERT INTO Vehical (carNumber,ownerName,mobileNo,carModel,carColor,enteryDate,deliveryDate)" + 
                                      " VALUES (@carNumber,@ownerName,@mobileNo,@carModel,@carColor,@enteryDate,@deliveryDate)";

            SqlCommand cmd = new SqlCommand(query, conn);

            if(cnumber_text.Text == "")
            {
                cnErrorText.Visible = true;
                
            }
            else
            {
                cnErrorText.Visible=false;
                
                cmd.Parameters.AddWithValue("@carNumber",cnumber_text.Text);
                cmd.Parameters.AddWithValue("@ownerName",oname_text.Text);
                cmd.Parameters.AddWithValue("@mobileNo",mono_text.Text);
                cmd.Parameters.AddWithValue("@carModel",cmodel_text.Text);
                cmd.Parameters.AddWithValue("@carColor",ccolor_text.Text);
                cmd.Parameters.AddWithValue("@enteryDate",entery_date.Text);
                cmd.Parameters.AddWithValue("@deliveryDate",delivery_date.Text);

                cmd.ExecuteNonQuery();

                conn.Close();
                clearForm();

               MessageBox.Show("Car added sucefully");
            }

            displyData();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            displyData();

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            const string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Collage\\Sem-5\\C#-NET\\GMS\\GMS\\GMS.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string query = "update Vehical set ownerName = @ownerName,mobileNo=@mobileNO,carModel=@carModel,carColor=@carColor,enteryDate=@enteryDate,deliveryDate=@deliveryDate where carNumber = @carNumber";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@carNumber", cnumber_text.Text);
            cmd.Parameters.AddWithValue("@ownerName", oname_text.Text);
            cmd.Parameters.AddWithValue("@mobileNo", mono_text.Text);
            cmd.Parameters.AddWithValue("@carModel", cmodel_text.Text);
            cmd.Parameters.AddWithValue("@carColor", ccolor_text.Text);
            cmd.Parameters.AddWithValue("@enteryDate", entery_date.Text);
            cmd.Parameters.AddWithValue("@deliveryDate", delivery_date.Text);


            cmd.ExecuteNonQuery();

            conn.Close();
            clearForm();

            MessageBox.Show("updated");
            displyData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            const string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Collage\\Sem-5\\C#-NET\\GMS\\GMS\\GMS.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string query = "delete Vehical where carNumber = @carNumber";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@carNumber", cnumber_text.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Record Delete");
            displyData();
            clearForm();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            const string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Collage\\Sem-5\\C#-NET\\GMS\\GMS\\GMS.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string query = "select * from Vehical where carNumber = @carNumber";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@carNumber",cnumber_text.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                oname_text.Text = dr["ownerName"].ToString();
                mono_text.Text = dr["mobileNo"].ToString();
                cmodel_text.Text = dr["carModel"].ToString();
                ccolor_text.Text = dr["carColor"].ToString();
                entery_date.Text = dr["enteryDate"].ToString();
                delivery_date.Text = dr["deliveryDate"].ToString();
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cnErrorText_Click(object sender, EventArgs e)
        {

        }
    }
}
