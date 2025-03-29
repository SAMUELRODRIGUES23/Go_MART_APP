
namespace Gone_Mart
{
    partial class add_admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ad_pass = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.ad_id = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.s_Id = new System.Windows.Forms.Label();
            this.btn_upd = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.ad_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.ad_pass);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.ad_id);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.s_Id);
            this.groupBox1.Controls.Add(this.btn_upd);
            this.groupBox1.Controls.Add(this.btn_del);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.ad_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(966, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new Admin";
            // 
            // ad_pass
            // 
            this.ad_pass.Location = new System.Drawing.Point(212, 110);
            this.ad_pass.Name = "ad_pass";
            this.ad_pass.Size = new System.Drawing.Size(646, 22);
            this.ad_pass.TabIndex = 20;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Password.Location = new System.Drawing.Point(34, 110);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 17);
            this.Password.TabIndex = 21;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // ad_id
            // 
            this.ad_id.Location = new System.Drawing.Point(591, 42);
            this.ad_id.Name = "ad_id";
            this.ad_id.Size = new System.Drawing.Size(222, 22);
            this.ad_id.TabIndex = 17;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.age.Location = new System.Drawing.Point(484, 44);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(96, 17);
            this.age.TabIndex = 18;
            this.age.Text = "Admin User Id";
            // 
            // s_Id
            // 
            this.s_Id.AutoSize = true;
            this.s_Id.ForeColor = System.Drawing.Color.Yellow;
            this.s_Id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.s_Id.Location = new System.Drawing.Point(34, 28);
            this.s_Id.Name = "s_Id";
            this.s_Id.Size = new System.Drawing.Size(46, 17);
            this.s_Id.TabIndex = 4;
            this.s_Id.Text = "label6";
            // 
            // btn_upd
            // 
            this.btn_upd.BackColor = System.Drawing.Color.Indigo;
            this.btn_upd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_upd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_upd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_upd.Location = new System.Drawing.Point(321, 165);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(91, 37);
            this.btn_upd.TabIndex = 16;
            this.btn_upd.Text = "Update";
            this.btn_upd.UseVisualStyleBackColor = false;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.Red;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_del.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_del.Location = new System.Drawing.Point(645, 165);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(91, 37);
            this.btn_del.TabIndex = 15;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_add.Location = new System.Drawing.Point(487, 165);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(91, 37);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // ad_name
            // 
            this.ad_name.Location = new System.Drawing.Point(212, 44);
            this.ad_name.Name = "ad_name";
            this.ad_name.Size = new System.Drawing.Size(222, 22);
            this.ad_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(34, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Admin Name";
            // 
            // label2
            // 
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(418, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(968, 281);
            this.dataGridView1.TabIndex = 23;
            // 
            // add_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 519);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "add_admin";
            this.Text = "add_admin";
            this.Load += new System.EventHandler(this.add_admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ad_pass;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox ad_id;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label s_Id;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox ad_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}