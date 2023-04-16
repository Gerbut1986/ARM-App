namespace StoreManagerPlace_App.Forms
{
    partial class AddDelForm
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
            this.components = new System.ComponentModel.Container();
            this.Products_Lst = new System.Windows.Forms.ListBox();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Tb = new System.Windows.Forms.TextBox();
            this.Description_Tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Price_Tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateRelease_Tb = new System.Windows.Forms.DateTimePicker();
            this.Category_Tb = new System.Windows.Forms.ComboBox();
            this.Photo_Lbl = new System.Windows.Forms.Label();
            this.Upload_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IsStock_Cbx = new System.Windows.Forms.CheckBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Del_Rb = new System.Windows.Forms.RadioButton();
            this.Add_Rb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Products_Lst
            // 
            this.Products_Lst.BackColor = System.Drawing.Color.Black;
            this.Products_Lst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Products_Lst.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products_Lst.ForeColor = System.Drawing.Color.Yellow;
            this.Products_Lst.FormattingEnabled = true;
            this.Products_Lst.ItemHeight = 26;
            this.Products_Lst.Location = new System.Drawing.Point(3, 58);
            this.Products_Lst.Name = "Products_Lst";
            this.Products_Lst.Size = new System.Drawing.Size(405, 419);
            this.Products_Lst.TabIndex = 0;
            this.Products_Lst.SelectedIndexChanged += new System.EventHandler(this.Products_Lst_SelectedIndexChanged);
            this.Products_Lst.MouseEnter += new System.EventHandler(this.Products_Lst_MouseEnter);
            // 
            // Add_Btn
            // 
            this.Add_Btn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Btn.Location = new System.Drawing.Point(162, 433);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(129, 35);
            this.Add_Btn.TabIndex = 1;
            this.Add_Btn.Text = "Добавити";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Delete_Btn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Btn.Location = new System.Drawing.Point(3, 16);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(405, 42);
            this.Delete_Btn.TabIndex = 2;
            this.Delete_Btn.Text = "Видалити";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Назва продукту:";
            // 
            // Name_Tb
            // 
            this.Name_Tb.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Tb.Location = new System.Drawing.Point(34, 73);
            this.Name_Tb.Name = "Name_Tb";
            this.Name_Tb.Size = new System.Drawing.Size(257, 28);
            this.Name_Tb.TabIndex = 4;
            // 
            // Description_Tb
            // 
            this.Description_Tb.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_Tb.Location = new System.Drawing.Point(34, 122);
            this.Description_Tb.Name = "Description_Tb";
            this.Description_Tb.Size = new System.Drawing.Size(257, 28);
            this.Description_Tb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Опис товару:";
            // 
            // Price_Tb
            // 
            this.Price_Tb.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_Tb.Location = new System.Drawing.Point(34, 171);
            this.Price_Tb.Name = "Price_Tb";
            this.Price_Tb.Size = new System.Drawing.Size(257, 28);
            this.Price_Tb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ціна:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата випуску:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Категорія:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "В наявності:";
            // 
            // DateRelease_Tb
            // 
            this.DateRelease_Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRelease_Tb.Location = new System.Drawing.Point(35, 220);
            this.DateRelease_Tb.Name = "DateRelease_Tb";
            this.DateRelease_Tb.Size = new System.Drawing.Size(256, 24);
            this.DateRelease_Tb.TabIndex = 17;
            // 
            // Category_Tb
            // 
            this.Category_Tb.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Tb.FormattingEnabled = true;
            this.Category_Tb.Location = new System.Drawing.Point(35, 265);
            this.Category_Tb.Name = "Category_Tb";
            this.Category_Tb.Size = new System.Drawing.Size(256, 28);
            this.Category_Tb.TabIndex = 18;
            // 
            // Photo_Lbl
            // 
            this.Photo_Lbl.AutoSize = true;
            this.Photo_Lbl.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Photo_Lbl.Location = new System.Drawing.Point(16, 24);
            this.Photo_Lbl.Name = "Photo_Lbl";
            this.Photo_Lbl.Size = new System.Drawing.Size(105, 17);
            this.Photo_Lbl.TabIndex = 19;
            this.Photo_Lbl.Text = "не завантажуно..";
            // 
            // Upload_Btn
            // 
            this.Upload_Btn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload_Btn.Location = new System.Drawing.Point(159, 49);
            this.Upload_Btn.Name = "Upload_Btn";
            this.Upload_Btn.Size = new System.Drawing.Size(87, 23);
            this.Upload_Btn.TabIndex = 20;
            this.Upload_Btn.Text = "Завантажити";
            this.Upload_Btn.UseVisualStyleBackColor = true;
            this.Upload_Btn.Click += new System.EventHandler(this.Upload_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Upload_Btn);
            this.groupBox1.Controls.Add(this.Photo_Lbl);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 83);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фото товару:";
            // 
            // IsStock_Cbx
            // 
            this.IsStock_Cbx.AutoSize = true;
            this.IsStock_Cbx.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsStock_Cbx.Location = new System.Drawing.Point(38, 402);
            this.IsStock_Cbx.Name = "IsStock_Cbx";
            this.IsStock_Cbx.Size = new System.Drawing.Size(86, 25);
            this.IsStock_Cbx.TabIndex = 22;
            this.IsStock_Cbx.Text = "Так / Ні";
            this.IsStock_Cbx.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.groupBox3);
            this.groupBox.Controls.Add(this.Add_Btn);
            this.groupBox.Controls.Add(this.IsStock_Cbx);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.groupBox1);
            this.groupBox.Controls.Add(this.Name_Tb);
            this.groupBox.Controls.Add(this.Category_Tb);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.DateRelease_Tb);
            this.groupBox.Controls.Add(this.Description_Tb);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.Price_Tb);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(325, 480);
            this.groupBox.TabIndex = 23;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Новий товар";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Del_Rb);
            this.groupBox3.Controls.Add(this.Add_Rb);
            this.groupBox3.Location = new System.Drawing.Point(162, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 38);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // Del_Rb
            // 
            this.Del_Rb.AutoSize = true;
            this.Del_Rb.Location = new System.Drawing.Point(74, 13);
            this.Del_Rb.Name = "Del_Rb";
            this.Del_Rb.Size = new System.Drawing.Size(73, 17);
            this.Del_Rb.TabIndex = 1;
            this.Del_Rb.TabStop = true;
            this.Del_Rb.Text = "Видалити";
            this.Del_Rb.UseVisualStyleBackColor = true;
            this.Del_Rb.CheckedChanged += new System.EventHandler(this.Del_Rb_CheckedChanged);
            // 
            // Add_Rb
            // 
            this.Add_Rb.AutoSize = true;
            this.Add_Rb.Location = new System.Drawing.Point(6, 13);
            this.Add_Rb.Name = "Add_Rb";
            this.Add_Rb.Size = new System.Drawing.Size(63, 17);
            this.Add_Rb.TabIndex = 0;
            this.Add_Rb.TabStop = true;
            this.Add_Rb.Text = "Додати";
            this.Add_Rb.UseVisualStyleBackColor = true;
            this.Add_Rb.CheckedChanged += new System.EventHandler(this.Add_Rb_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Products_Lst);
            this.groupBox2.Controls.Add(this.Delete_Btn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 480);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Видалити наявний товар";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(325, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 480);
            this.panel1.TabIndex = 25;
            // 
            // AddDelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox);
            this.Name = "AddDelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати / Видалити товар";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Products_Lst;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_Tb;
        private System.Windows.Forms.TextBox Description_Tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Price_Tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateRelease_Tb;
        private System.Windows.Forms.ComboBox Category_Tb;
        private System.Windows.Forms.Label Photo_Lbl;
        private System.Windows.Forms.Button Upload_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox IsStock_Cbx;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Del_Rb;
        private System.Windows.Forms.RadioButton Add_Rb;
    }
}