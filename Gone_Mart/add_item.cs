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
    public partial class add_item : Form
    {
        Database_connect db_con = new Database_connect();

        public add_item()
        {
            InitializeComponent();
        }

        private void age_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_item_Load(object sender, EventArgs e)
        {
            a_Id.Visible = false;
            btn_del.Visible = false;
            btn_upd.Visible = false;
            btn_add.Visible = true;
            Bind_catogory();
            Bind_product_list();
            Bind_search_product();
        }

        private void Bind_search_product()
        {
            SqlCommand cmd = new SqlCommand("get_cat", db_con.GetCon());
            cmd.CommandType = CommandType.StoredProcedure;
            db_con.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            search.DataSource = dt;
            search.DisplayMember = "c_name";
            search.ValueMember = "cat_id";
            db_con.CloseCon();
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
        private void text_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Your code here (handle what happens when the selection changes)
            MessageBox.Show("Category selection changed!");
        }
        private void txt_clr()
        {
            text_name.Clear();
            text_price.Clear();
            text_quantity.Clear();


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_name.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your Product name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_name.Focus();
                    txt_clr();

                    return;
                }
                else if (text_price.Text == String.Empty && Convert.ToInt32(text_price.Text) < 0)
                {
                    MessageBox.Show("Please enter the correct price ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_clr();
                    text_price.Focus();
                    return;
                }
                else if (text_quantity.Text == String.Empty)
                {
                    MessageBox.Show("Please enter the quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_clr();

                    text_quantity.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_check_porduct", db_con.GetCon());
                    cmd.Parameters.AddWithValue("@pro_name", text_name.Text);
                    cmd.Parameters.AddWithValue("@pro_catid", comboBox2.SelectedValue);
                    cmd.CommandType = CommandType.StoredProcedure;
                    db_con.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Product already exist in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_clr();
                    }
                    else
                    {
                        cmd = new SqlCommand("sp_insert_porduct", db_con.GetCon());
                        cmd.Parameters.AddWithValue("@pro_name", text_name.Text);
                        cmd.Parameters.AddWithValue("@pro_catid", comboBox2.SelectedValue);
                        cmd.Parameters.AddWithValue("@pro_price", Convert.ToDecimal(text_price.Text));
                        cmd.Parameters.AddWithValue("@pro_qty", Convert.ToInt32(text_quantity.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();

                        // Console.WriteLine($"Rows affected: {i}");


                        MessageBox.Show("Product Inserted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_clr();
                        Bind_product_list();

                    }
                    db_con.CloseCon();



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_upd.Visible = true;
                btn_del.Visible = true;
                a_Id.Visible = true;
                btn_add.Visible = false;

                a_Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                text_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox2.SelectedValue = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                text_price.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                text_quantity.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Bind_product_list()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_all_product", db_con.GetCon());
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

        private void btn_upd_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_name.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your Product name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_name.Focus();
                    return;
                }
                else if (text_price.Text == String.Empty)
                {
                    MessageBox.Show("Please enter the correct price ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    text_price.Focus();
                    return;
                }
                else if (text_quantity.Text == String.Empty)
                {
                    MessageBox.Show("Please enter the quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    text_quantity.Focus();
                    return;
                }
                else
                {
                    //SqlCommand cmd = new SqlCommand("sp_check_porduct", db_con.GetCon());
                    // cmd.Parameters.AddWithValue("@pro_name", text_name.Text);
                    //cmd.Parameters.AddWithValue("@pro_catid", comboBox2.SelectedValue);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    db_con.OpenCon();
                    //  var result = cmd.ExecuteScalar();
                    /* if (result != null)
                     {
                         MessageBox.Show("Product already exist in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         txt_clr();
                     }*/
                    /* else
                    {
                       /* cmd = new SqlCommand("update_product", db_con.GetCon());
                        cmd.Parameters.AddWithValue("@pro_name", text_name.Text);
                        cmd.Parameters.AddWithValue("@pro_catid", comboBox2.SelectedValue);
                        cmd.Parameters.AddWithValue("@pro_price", Convert.ToDecimal(text_price.Text));
                        cmd.Parameters.AddWithValue("@pro_qty", Convert.ToInt32(text_quantity.Text));
                        cmd.Parameters.AddWithValue("@pro_id", Convert.ToInt32(a_Id.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();

                        // Console.WriteLine($"Rows affected: {i}");


                        MessageBox.Show("Product Updated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_clr();
                        Bind_product_list();
                        a_Id.Visible = false;
                        btn_add.Visible = true;
                        btn_upd.Visible = false;
                        btn_del.Visible = false;} */

                    SqlCommand cmd = new SqlCommand("update_product", db_con.GetCon());
                    cmd.Parameters.AddWithValue("@pro_name", text_name.Text);
                    cmd.Parameters.AddWithValue("@pro_catid", comboBox2.SelectedValue);
                    cmd.Parameters.AddWithValue("@pro_price", Convert.ToDecimal(text_price.Text));
                    cmd.Parameters.AddWithValue("@pro_qty", Convert.ToInt32(text_quantity.Text));
                    cmd.Parameters.AddWithValue("@pro_id", Convert.ToInt32(a_Id.Text));
                    cmd.CommandType = CommandType.StoredProcedure;
                    int i = cmd.ExecuteNonQuery();

                    // Console.WriteLine($"Rows affected: {i}");


                    MessageBox.Show("Product Updated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_clr();
                    Bind_product_list();
                    a_Id.Visible = false;
                    btn_add.Visible = true;
                    btn_upd.Visible = false;
                    btn_del.Visible = false;
                    db_con.CloseCon();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void a_Id_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            btn_upd.Visible = true;
            btn_del.Visible = true;
            a_Id.Visible = true;
            btn_add.Visible = false;

            a_Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            text_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox2.SelectedValue = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            text_price.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            text_quantity.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (a_Id.Text == String.Empty)
                {
                    MessageBox.Show("Please enter the product ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (a_Id.Text != String.Empty)
                {
                    if (DialogResult.Yes == MessageBox.Show("Do you want to delete the record permanantly?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("delete_product", db_con.GetCon());
                        cmd.Parameters.AddWithValue("@pro_id", Convert.ToInt32(a_Id.Text));
                        db_con.OpenCon();
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Category Deleted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_clr();
                            Bind_product_list();
                            btn_del.Visible = false;
                            btn_add.Visible = true;
                            btn_del.Visible = false;
                            a_Id.Visible = false;

                        }
                        else
                        {
                            MessageBox.Show("Category Deletion failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_clr();
                        }
                        db_con.CloseCon();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void search_productlist()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_all_product_search", db_con.GetCon());
                cmd.Parameters.AddWithValue("@pro_catid", search.SelectedValue);
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

        private void srch_btn_Click(object sender, EventArgs e)
        {
            search_productlist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bind_product_list();

        }
    }
}
