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
    public partial class Form1 : Form
    {
        Database_connect dbcon = new Database_connect();
        public static string login_name,login_type;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            textBox1.Text = "Samx";
            textBox2.Text = "Samuel";

        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex > 0)
                {
                    if (comboBox1.SelectedIndex > 0 && textBox1.Text != String.Empty && textBox2.Text != String.Empty)
                    {
                        //login modes
                        if (comboBox1.Text == "Admin")
                        {
                            SqlCommand cmd = new SqlCommand("select top 1 A_ID, [password], FullName from admin_table where A_ID=@A_ID and password=@password", dbcon.GetCon());
                            cmd.Parameters.AddWithValue("@A_ID", textBox1.Text);
                            cmd.Parameters.AddWithValue("@password", textBox2.Text.Trim());
                            dbcon.OpenCon();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();     
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                MessageBox.Show("Login Success.Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                login_name = textBox1.Text;
                                login_type = comboBox1.Text;
                                this.Hide();
                                Form_Main fm = new Form_Main();
                                fm.Show();
                            }
                            else
                            {
                                MessageBox.Show("ERROR,LOGIN FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else if (comboBox1.Text == "Seller")
                        {
                            SqlCommand cmd = new SqlCommand("select top 1 s_name,s_password from seller_login where s_name=@s_name and s_password=@s_password", dbcon.GetCon());
                            cmd.Parameters.AddWithValue("@s_name", textBox1.Text);
                            cmd.Parameters.AddWithValue("@s_password", textBox2.Text.Trim());
                            dbcon.OpenCon();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                MessageBox.Show("Login Success.Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                login_name = textBox1.Text;
                                login_type = comboBox1.Text;
                                this.Hide();
                                Form_Main fm = new Form_Main();
                                fm.Show();
                            }
                            else
                            {
                                MessageBox.Show("ERROR,LOGIN FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {

                        }

                    }
                    else
                    {
                        MessageBox.Show("ERROR, PLEASE ENTER THE MISSING BLOCKS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clrValue();
                    }
                    if (textBox1.Text == String.Empty)
                    {
                        MessageBox.Show("Please enter your username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Focus();
                        return;
                    }
                    if (textBox2.Text == String.Empty)
                    {
                        MessageBox.Show("Please enter your respective password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        textBox2.Focus();
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Please slect any role from the combo box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clrValue()
        {
            comboBox1.SelectedIndex = 0;
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
