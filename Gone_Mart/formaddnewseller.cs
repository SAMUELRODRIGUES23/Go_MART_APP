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
    public partial class formaddnewseller : Form
    {
        Database_connect db_con = new Database_connect();
        public formaddnewseller()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void formaddnewseller_Load(object sender, EventArgs e)
        {
            a_Id.Visible = false;
            btn_del.Visible = false;
            btn_upd.Visible = false;
            btn_add.Visible = true;
            Bind_seller();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (text_sellername.Text == String.Empty)
            {
                MessageBox.Show("Please enter your seller name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_sellername.Focus();
                return;
            }
            else if (text_phone.Text == String.Empty)
            {
                MessageBox.Show("Please enter your phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                text_phone.Focus();
                return;
            }
            else if (txt_password.Text == String.Empty)
            {
                MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                text_phone.Focus();
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select s_name from seller_login where s_name=@s_name;", db_con.GetCon());
                cmd.Parameters.AddWithValue("@s_name", text_sellername.Text);
                db_con.OpenCon();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Seller already exist in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_clr();
                }
                else
                {
                    cmd = new SqlCommand("seller_input", db_con.GetCon());
                    cmd.Parameters.AddWithValue("@s_name", text_sellername.Text);
                    cmd.Parameters.AddWithValue("@s_age", Convert.ToInt32(text_age.Text));
                    cmd.Parameters.AddWithValue("@s_phone", text_phone.Text);
                    cmd.Parameters.AddWithValue("@s_password", txt_password.Text);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Seller Added SuccessFully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_clr();
                        Bind_seller();
                    }
                }
                db_con.CloseCon();



            }

        }

        private void txt_clr()
        {
            text_sellername.Clear();
            text_age.Clear();
            txt_password.Clear();
            text_phone.Clear();

        }

        private void Bind_seller()
        {
            SqlCommand cmd = new SqlCommand("select * from seller_login", db_con.GetCon());
            db_con.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            db_con.CloseCon();
        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            try
            {
                if (a_Id.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your seller ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_sellername.Focus();
                    return;
                }

                if (text_sellername.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your seller name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_sellername.Focus();
                    return;
                }
                if (text_age.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your age ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_age.Focus();
                    return;
                }
                else if (text_phone.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your Phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    text_phone.Focus();
                    return;
                }
                else if (txt_password.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    text_phone.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select s_name from seller_login where s_name = @s_name", db_con.GetCon());

                    cmd.Parameters.AddWithValue("@s_name", text_sellername.Text);
                    db_con.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Selle Name already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_clr();
                    }
                    else
                    { 
                     cmd = new SqlCommand("seller_update", db_con.GetCon());
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(a_Id.Text));
                        cmd.Parameters.AddWithValue("@s_name", text_sellername.Text);
                        cmd.Parameters.AddWithValue("@s_age", Convert.ToInt32(text_age.Text));
                        cmd.Parameters.AddWithValue("@s_phone", text_phone.Text);
                        cmd.Parameters.AddWithValue("@s_password", txt_password.Text);
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Seller information Updated Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_clr();
                            Bind_seller();
                            btn_upd.Visible = false;

                            btn_add.Visible = false;
                            btn_del.Visible = true;
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

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (a_Id.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your category ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (a_Id.Text != String.Empty)
                {
                    if (DialogResult.Yes == MessageBox.Show("Do you want to delete the record permanantly?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("s_del", db_con.GetCon());
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(a_Id.Text));
                        db_con.OpenCon();
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Category Deleted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_clr();
                            Bind_seller();
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

    

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btn_upd.Visible = true;
            btn_del.Visible = true;
            btn_add.Visible = false;
            a_Id.Visible = true;
            a_Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            text_sellername.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            text_age.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            text_phone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_password.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle the cell click event here
            MessageBox.Show($"Cell clicked at row {e.RowIndex}, column {e.ColumnIndex}");
        }
    }
}
