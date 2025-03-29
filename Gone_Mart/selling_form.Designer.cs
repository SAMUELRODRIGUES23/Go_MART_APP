
namespace Gone_Mart
{
    partial class selling_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.pro_name = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.dataGridView1_ord = new System.Windows.Forms.DataGridView();
            this.PRODUCT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_btn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_pro = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.resfresh = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.GrandTotal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.Label();
            this.billnumber = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_ord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(425, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selling Form";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.add1);
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 247);
            this.panel2.TabIndex = 1;
            // 
            // add1
            // 
            this.add1.BackColor = System.Drawing.SystemColors.Highlight;
            this.add1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add1.Location = new System.Drawing.Point(172, 200);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(87, 35);
            this.add1.TabIndex = 25;
            this.add1.Text = "ADD";
            this.add1.UseVisualStyleBackColor = false;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(37, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(17, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(29, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Product Name";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(116, 96);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(238, 22);
            this.id.TabIndex = 7;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(116, 187);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(238, 22);
            this.price.TabIndex = 8;
            // 
            // pro_name
            // 
            this.pro_name.Location = new System.Drawing.Point(116, 141);
            this.pro_name.Name = "pro_name";
            this.pro_name.ReadOnly = true;
            this.pro_name.Size = new System.Drawing.Size(238, 22);
            this.pro_name.TabIndex = 9;
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(116, 235);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(238, 22);
            this.qty.TabIndex = 10;
            // 
            // dataGridView1_ord
            // 
            this.dataGridView1_ord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_ord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRODUCT_ID,
            this.PRODUCT_NAME,
            this.PRO_PRICE,
            this.QUANTITY,
            this.TOTAL});
            this.dataGridView1_ord.Location = new System.Drawing.Point(390, 77);
            this.dataGridView1_ord.Name = "dataGridView1_ord";
            this.dataGridView1_ord.RowHeadersWidth = 51;
            this.dataGridView1_ord.RowTemplate.Height = 24;
            this.dataGridView1_ord.Size = new System.Drawing.Size(681, 215);
            this.dataGridView1_ord.TabIndex = 11;
            // 
            // PRODUCT_ID
            // 
            this.PRODUCT_ID.HeaderText = "PRODUCT_ID";
            this.PRODUCT_ID.MinimumWidth = 6;
            this.PRODUCT_ID.Name = "PRODUCT_ID";
            this.PRODUCT_ID.Width = 125;
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.HeaderText = "PRODUCT_NAME";
            this.PRODUCT_NAME.MinimumWidth = 6;
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            this.PRODUCT_NAME.Width = 125;
            // 
            // PRO_PRICE
            // 
            this.PRO_PRICE.HeaderText = "PRO_PRICE";
            this.PRO_PRICE.MinimumWidth = 6;
            this.PRO_PRICE.Name = "PRO_PRICE";
            this.PRO_PRICE.Width = 125;
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.MinimumWidth = 6;
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Width = 125;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.MinimumWidth = 6;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Width = 125;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_btn.Location = new System.Drawing.Point(4, 938);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(87, 35);
            this.add_btn.TabIndex = 12;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(191, 342);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(374, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView2.Location = new System.Drawing.Point(0, 329);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1071, 46);
            this.dataGridView2.TabIndex = 13;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Gold;
            this.Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Search.Location = new System.Drawing.Point(585, 337);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(94, 33);
            this.Search.TabIndex = 13;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 686);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 246);
            this.dataGridView1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(153, 644);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selling List";
            // 
            // dataGridView_pro
            // 
            this.dataGridView_pro.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView_pro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pro.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView_pro.Location = new System.Drawing.Point(0, 633);
            this.dataGridView_pro.Name = "dataGridView_pro";
            this.dataGridView_pro.RowHeadersWidth = 51;
            this.dataGridView_pro.RowTemplate.Height = 24;
            this.dataGridView_pro.Size = new System.Drawing.Size(1071, 46);
            this.dataGridView_pro.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(984, 938);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // resfresh
            // 
            this.resfresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.resfresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resfresh.Location = new System.Drawing.Point(685, 337);
            this.resfresh.Name = "resfresh";
            this.resfresh.Size = new System.Drawing.Size(94, 33);
            this.resfresh.TabIndex = 17;
            this.resfresh.Text = "Refresh";
            this.resfresh.UseVisualStyleBackColor = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(5, 381);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(1066, 246);
            this.dataGridView4.TabIndex = 24;
            this.dataGridView4.Click += new System.EventHandler(this.dataGridView4_Click);
            // 
            // GrandTotal
            // 
            this.GrandTotal.AutoSize = true;
            this.GrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotal.ForeColor = System.Drawing.Color.Red;
            this.GrandTotal.Location = new System.Drawing.Point(858, 300);
            this.GrandTotal.Name = "GrandTotal";
            this.GrandTotal.Size = new System.Drawing.Size(90, 18);
            this.GrandTotal.TabIndex = 25;
            this.GrandTotal.Text = "Grand Total:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(948, 638);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 26;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number.Location = new System.Drawing.Point(618, 644);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(108, 25);
            this.number.TabIndex = 27;
            this.number.Text = "Bill number";
            // 
            // billnumber
            // 
            this.billnumber.Location = new System.Drawing.Point(745, 647);
            this.billnumber.Name = "billnumber";
            this.billnumber.Size = new System.Drawing.Size(122, 22);
            this.billnumber.TabIndex = 28;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Red;
            this.lblDate.Location = new System.Drawing.Point(858, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 18);
            this.lblDate.TabIndex = 29;
            this.lblDate.Text = "DATE: ";
            // 
            // selling_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 986);
            this.Controls.Add(this.billnumber);
            this.Controls.Add(this.number);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GrandTotal);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.resfresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1_ord);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.pro_name);
            this.Controls.Add(this.price);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView_pro);
            this.MaximizeBox = false;
            this.Name = "selling_form";
            this.Text = "selling_form";
            this.Load += new System.EventHandler(this.selling_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_ord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox pro_name;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.DataGridView dataGridView1_ord;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_pro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button resfresh;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Label GrandTotal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox billnumber;
        private System.Windows.Forms.Label lblDate;
    }
}