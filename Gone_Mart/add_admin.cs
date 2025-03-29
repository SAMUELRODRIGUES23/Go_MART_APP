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
    public partial class add_admin : Form
    {
        Database_connect db_con = new Database_connect();

        public add_admin()
        {
            InitializeComponent();
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }
        private void Bind_admin()
        {
            SqlCommand cmd = new SqlCommand("select * from admin_table", db_con.GetCon());
            db_con.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            db_con.CloseCon();
        }
        private void add_admin_Load(object sender, EventArgs e)
        {
            s_Id.Visible = false;
            btn_del.Visible = false;
            btn_upd.Visible = false;
            btn_add.Visible = true;
            s_Id.Visible = true;
            Bind_admin();
        }
        private void txt_clr()
        {
            ad_name.Clear();
            ad_id.Clear();
            ad_pass.Clear();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ad_id.Text == String.Empty)
            {
                MessageBox.Show("Please enter your ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ad_id.Focus();
                txt_clr();
                return;
            }
            else if (ad_name.Text == String.Empty)
            {
                MessageBox.Show("Please enter your name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ad_name.Focus();
                txt_clr();

                return;
            }
            else if (ad_pass.Text == String.Empty)
            {
                MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ad_pass.Focus();
                txt_clr();

                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select A_ID from admin_table where A_ID=@A_ID;", db_con.GetCon());
                cmd.Parameters.AddWithValue("@A_ID", ad_id.Text);
                db_con.OpenCon();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Seller already exist in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_clr();
                }
                else
                {
                    cmd = new SqlCommand("admin_input", db_con.GetCon());
                    cmd.Parameters.AddWithValue("@A_ID", ad_id.Text);
                    cmd.Parameters.AddWithValue("@password", ad_pass.Text);
                    
                    cmd.Parameters.AddWithValue("@FullName", ad_name.Text);
                    db_con.OpenCon();
                    cmd.CommandType = CommandType.StoredProcedure;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Seller Added SuccessFully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_clr();
                        Bind_admin();
                    }
                }
                db_con.CloseCon();



            }

        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ad_name.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your admin ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ad_name.Focus();
                    return;
                }

                if (ad_pass.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your admin name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ad_pass.Focus();
                    return;
                }
                if (ad_id.Text == String.Empty)
                {
                    MessageBox.Show("Please enter your id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ad_id.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select Full Name from admin_table where FullName = @FullName", db_con.GetCon());

                    cmd.Parameters.AddWithValue("@FullName", ad_name.Text);
                    db_con.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Admin Name already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_clr();
                    }
                    else
                    {
                        cmd = new SqlCommand("admin_upd", db_con.GetCon());

                        db_con.OpenCon();
                        cmd.Parameters.AddWithValue("@A_ID", Convert.ToInt32(ad_id.Text));
                        cmd.Parameters.AddWithValue("@password", ad_pass.Text);
                        cmd.Parameters.AddWithValue("@FullName", ad_name.Text);
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Admin information Updated Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_clr();
                            Bind_admin();
                            btn_upd.Visible = false;

                            btn_add.Visible = false;
                            btn_del.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Admin Table Updation failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void dataGridView1_Click(object sender, EventArgs e)
        {

            try
            {
                btn_upd.Visible = true;
                btn_del.Visible = true;
                s_Id.Visible = true;
                btn_add.Visible = false;

                s_Id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ad_name.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ad_pass.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                ad_id.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
