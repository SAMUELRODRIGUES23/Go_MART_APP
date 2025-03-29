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
namespace Gone_Mart
{
    public partial class Form_cat : Form
    {
        Database_connect db_con = new Database_connect();
        public Form_cat()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (catId.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your category ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_cat1.Focus();
                    return;
                }
                if (text_cat1.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your category ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_cat1.Focus();
                    return;
                }
                else if (text_cat2.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your Category description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    text_cat2.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select c_name from category where c_name = @c_name", db_con.GetCon());
                    cmd.Parameters.AddWithValue("@c_name", text_cat1.Text);
                    db_con.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                   
                    
                        cmd = new SqlCommand("sp_update", db_con.GetCon());
                        cmd.Parameters.AddWithValue("@cat_id", Convert.ToInt32(catId.Text));
                        cmd.Parameters.AddWithValue("@c_name", text_cat1.Text);
                        cmd.Parameters.AddWithValue("@c_desc", text_cat2.Text);
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Category Updated Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_clr();
                            Bind_category();
                            btn_upd.Visible = false;
                            btn_add_cat.Visible = false;
                            btn_del.Visible= true;
                        }
                        else
                        {
                            MessageBox.Show("Category Updated failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_clr();
                        }
                    }
                    db_con.CloseCon();



                }

            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form_cat_Load(object sender, EventArgs e)
        {
            btn_upd.Visible = false;
            btn_del.Visible = false;
            catId.Visible = false;
            Bind_category();
        }

        private void btn_add_cat_Click(object sender, EventArgs e)
        {
            if (text_cat1.Text == String.Empty)
            {
                MessageBox.Show("Please enter your category ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_cat1.Focus();
                return;
            }
           else if (text_cat2.Text == String.Empty)
            {
                MessageBox.Show("Please enter your Category description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                text_cat2.Focus();
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select c_name from category where c_name = @c_name", db_con.GetCon());
                cmd.Parameters.AddWithValue("@c_name", text_cat1.Text);
                db_con.OpenCon();
                var result = cmd.ExecuteScalar();
                if(result!=null)
                {
                    MessageBox.Show("Category Name exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_clr();
                }
                else
                {
                    cmd = new SqlCommand("sp_categoryInsert", db_con.GetCon());
                    cmd.Parameters.AddWithValue("@c_name", text_cat1.Text);
                    cmd.Parameters.AddWithValue("@c_desc", text_cat2.Text);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int i = cmd.ExecuteNonQuery();   
                    if(i>0)
                    {
                        MessageBox.Show("Category Name Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_clr();
                        Bind_category();
                    }
                }
                db_con.CloseCon();
                
                

            }
        }
        private void txt_clr()
        {
            text_cat1.Clear();
            text_cat2.Clear();

        }
        private void Bind_category()
        {
            SqlCommand cmd = new SqlCommand("select cat_id as Category_ID, c_name, c_desc as Category_Description from category",db_con.GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

             db_con.OpenCon();
        }

    

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            btn_upd.Visible = true;
            btn_del.Visible = true;
            btn_add_cat.Visible = false;
            catId.Visible = true;
            catId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            text_cat1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            text_cat2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (catId.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your category ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                if(catId.Text != String.Empty)
                {
                    if (DialogResult.Yes == MessageBox.Show("Do you want to delete the record permanantly?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("sp_delete", db_con.GetCon());
                        cmd.Parameters.AddWithValue("@cat_id", Convert.ToInt32(catId.Text));
                        db_con.OpenCon();
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Category Deleted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_clr();
                            Bind_category();
                            btn_del.Visible = false;
                            btn_add_cat.Visible = true;
                            btn_del.Visible = false;
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
    }
}
