using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gone_Mart
{
    public partial class selling_form : Form
    {
        Database_connect db_con = new Database_connect();

        public selling_form()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

        }
        private void Bind_catogory()
        {
            SqlCommand cmd = new SqlCommand("get_cat", db_con.GetCon());
            cmd.CommandType = CommandType.StoredProcedure;
            db_con.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "c_name";
            comboBox2.ValueMember = "cat_id";
            db_con.CloseCon();
        }
        private void search_productlist()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_all_product_search", db_con.GetCon());
                cmd.Parameters.AddWithValue("@pro_catid", comboBox2.SelectedValue);
                cmd.CommandType = CommandType.StoredProcedure;
                db_con.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView4.DataSource = dt;
                db_con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {

            

            id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            pro_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
           // comboBox2.SelectedValue = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            price.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            qty.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void selling_form_Load(object sender, EventArgs e)
        {
            Bind_catogory();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            search_productlist();
        }

        private void dataGridView4_DoubleClick(object sender, EventArgs e)
        {
            id.Text = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
            pro_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            // comboBox2.SelectedValue = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            price.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            qty.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void dataGridView4_Click(object sender, EventArgs e)
        {
            id.Text = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
            pro_name.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
            // comboBox2.SelectedValue = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            price.Text = dataGridView4.SelectedRows[0].Cells[4].Value.ToString();
            qty.Text = dataGridView4.SelectedRows[0].Cells[5].Value.ToString();
        }
        double gran_tot = 0.0;
        int n = 0;


        private void add1_Click(object sender, EventArgs e)
        {
            try
            {
                double Total = Convert.ToDouble(price.Text)*Convert.ToInt32(qty.Text);
                DataGridViewRow ds = new DataGridViewRow();
                ds.CreateCells(dataGridView1_ord);
                ds.Cells[0].Value = ++n;
                ds.Cells[1].Value=pro_name.Text;
                ds.Cells[2].Value = price.Text;
                ds.Cells[3].Value = qty.Text;
                ds.Cells[4].Value = Total;
                dataGridView1_ord.Rows.Add(ds);
                gran_tot += Total;
                GrandTotal.Text = "Rs." + gran_tot;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bin_bill()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_get", db_con.GetCon());
                cmd.CommandType = CommandType.StoredProcedure;
                db_con.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                db_con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spsee__insert", db_con.GetCon());
                cmd.Parameters.AddWithValue("@bill_id", billnumber.Text);
                cmd.Parameters.AddWithValue("@seller_id", Form1.login_name);
                cmd.Parameters.AddWithValue("@sell_Date", Convert.ToDecimal(lblDate.Text));
                cmd.Parameters.AddWithValue("@totamt", Convert.ToDouble(price.Text));
                

                cmd.CommandType = CommandType.StoredProcedure;
                db_con.OpenCon();
                int i = cmd.ExecuteNonQuery();

                // Console.WriteLine($"Rows affected: {i}");

                bin_bill();
                MessageBox.Show("Product Added Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db_con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
