namespace StoreManagerPlace_App.Forms
{
    partial class CreateOrderForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Products_Cmb = new System.Windows.Forms.ComboBox();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Order_Lst = new System.Windows.Forms.ListBox();
            this.Order_Btn = new System.Windows.Forms.Button();
            this.SelProt_Lst = new System.Windows.Forms.ListBox();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 450);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(326, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 450);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelProt_Lst);
            this.groupBox1.Controls.Add(this.Products_Cmb);
            this.groupBox1.Controls.Add(this.Add_Btn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вибери продукт у випадаючому списку";
            // 
            // Products_Cmb
            // 
            this.Products_Cmb.FormattingEnabled = true;
            this.Products_Cmb.Location = new System.Drawing.Point(12, 41);
            this.Products_Cmb.Name = "Products_Cmb";
            this.Products_Cmb.Size = new System.Drawing.Size(308, 28);
            this.Products_Cmb.TabIndex = 1;
            this.Products_Cmb.SelectedIndexChanged += new System.EventHandler(this.Products_Cmb_SelectedIndexChanged);
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(200, 397);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(120, 33);
            this.Add_Btn.TabIndex = 0;
            this.Add_Btn.Text = "Добавити";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delete_Btn);
            this.groupBox2.Controls.Add(this.Order_Btn);
            this.groupBox2.Controls.Add(this.Order_Lst);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 450);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вибрані товари";
            // 
            // Order_Lst
            // 
            this.Order_Lst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Order_Lst.FormattingEnabled = true;
            this.Order_Lst.ItemHeight = 20;
            this.Order_Lst.Location = new System.Drawing.Point(3, 63);
            this.Order_Lst.Name = "Order_Lst";
            this.Order_Lst.Size = new System.Drawing.Size(645, 384);
            this.Order_Lst.TabIndex = 0;
            this.Order_Lst.SelectedIndexChanged += new System.EventHandler(this.Order_Lst_SelectedIndexChanged);
            // 
            // Order_Btn
            // 
            this.Order_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Order_Btn.Location = new System.Drawing.Point(3, 24);
            this.Order_Btn.Name = "Order_Btn";
            this.Order_Btn.Size = new System.Drawing.Size(645, 39);
            this.Order_Btn.TabIndex = 1;
            this.Order_Btn.Text = "Зробити замовлення";
            this.Order_Btn.UseVisualStyleBackColor = true;
            this.Order_Btn.Click += new System.EventHandler(this.Order_Btn_Click);
            // 
            // SelProt_Lst
            // 
            this.SelProt_Lst.FormattingEnabled = true;
            this.SelProt_Lst.ItemHeight = 20;
            this.SelProt_Lst.Location = new System.Drawing.Point(12, 90);
            this.SelProt_Lst.Name = "SelProt_Lst";
            this.SelProt_Lst.Size = new System.Drawing.Size(308, 284);
            this.SelProt_Lst.TabIndex = 2;
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.BackColor = System.Drawing.Color.Red;
            this.Delete_Btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Delete_Btn.Location = new System.Drawing.Point(6, 24);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(175, 39);
            this.Delete_Btn.TabIndex = 2;
            this.Delete_Btn.Text = "Видалити";
            this.Delete_Btn.UseVisualStyleBackColor = false;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            this.Delete_Btn.MouseEnter += new System.EventHandler(this.Delete_Btn_MouseEnter);
            this.Delete_Btn.MouseLeave += new System.EventHandler(this.Delete_Btn_MouseLeave);
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CreateOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Створення нового замовлення";
            this.Load += new System.EventHandler(this.CreateOrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox SelProt_Lst;
        private System.Windows.Forms.ComboBox Products_Cmb;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Order_Btn;
        private System.Windows.Forms.ListBox Order_Lst;
        private System.Windows.Forms.Button Delete_Btn;
    }
}