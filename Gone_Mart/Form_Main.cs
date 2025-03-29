using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gone_Mart
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = Form1.login_name;
            if(Form1.login_name!=null && Form1.login_type=="Seller")
            {
                masterToolStripMenuItem.Enabled = false;
                productToolStripMenuItem.Enabled = false;
                addUserToolStripMenuItem.Enabled = false;
            }

        }
        private void Form_Main_Load(object sender,EventArgs e)
        {
            if(Form1.login_name!=null)
            {
                MessageBox.Show("Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cat fcat = new Form_cat();
            fcat.Show();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abt = new AboutBox1();
            abt.Show();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close the application?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formaddnewseller fseller = new formaddnewseller();
            fseller.ShowDialog();
        }
 

        private void adminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            add_admin aaf = new add_admin();
            aaf.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_item add = new add_item();
            add.ShowDialog();
        }

        private void sellerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selling_form sf = new selling_form();
            sf.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
