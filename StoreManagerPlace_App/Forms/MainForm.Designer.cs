namespace StoreManagerPlace_App.Forms
{
    partial class MainForm
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
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.SessStat_Btn = new System.Windows.Forms.Button();
            this.CreateOrder_Btn = new System.Windows.Forms.Button();
            this.ViewProds_Btn = new System.Windows.Forms.Button();
            this.AddDel_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Exit_Btn);
            this.panel1.Controls.Add(this.SessStat_Btn);
            this.panel1.Controls.Add(this.CreateOrder_Btn);
            this.panel1.Controls.Add(this.ViewProds_Btn);
            this.panel1.Controls.Add(this.AddDel_Btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 459);
            this.panel1.TabIndex = 0;
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit_Btn.Location = new System.Drawing.Point(488, 354);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(156, 78);
            this.Exit_Btn.TabIndex = 6;
            this.Exit_Btn.Text = "Вихід";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            this.Exit_Btn.MouseEnter += new System.EventHandler(this.Exit_Btn_MouseEnter);
            this.Exit_Btn.MouseLeave += new System.EventHandler(this.Exit_Btn_MouseLeave);
            // 
            // SessStat_Btn
            // 
            this.SessStat_Btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessStat_Btn.Location = new System.Drawing.Point(488, 187);
            this.SessStat_Btn.Name = "SessStat_Btn";
            this.SessStat_Btn.Size = new System.Drawing.Size(156, 78);
            this.SessStat_Btn.TabIndex = 5;
            this.SessStat_Btn.Text = "Статистика торгової сесії";
            this.SessStat_Btn.UseVisualStyleBackColor = true;
            this.SessStat_Btn.Click += new System.EventHandler(this.SessStat_Btn_Click);
            this.SessStat_Btn.MouseEnter += new System.EventHandler(this.SessStat_Btn_MouseEnter);
            this.SessStat_Btn.MouseLeave += new System.EventHandler(this.SessStat_Btn_MouseLeave);
            // 
            // CreateOrder_Btn
            // 
            this.CreateOrder_Btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateOrder_Btn.Location = new System.Drawing.Point(488, 28);
            this.CreateOrder_Btn.Name = "CreateOrder_Btn";
            this.CreateOrder_Btn.Size = new System.Drawing.Size(156, 78);
            this.CreateOrder_Btn.TabIndex = 4;
            this.CreateOrder_Btn.Text = "Створити замовлення";
            this.CreateOrder_Btn.UseVisualStyleBackColor = true;
            this.CreateOrder_Btn.Click += new System.EventHandler(this.CreateOrder_Btn_Click);
            this.CreateOrder_Btn.MouseEnter += new System.EventHandler(this.CreateOrder_Btn_MouseEnter);
            this.CreateOrder_Btn.MouseLeave += new System.EventHandler(this.CreateOrder_Btn_MouseLeave);
            // 
            // ViewProds_Btn
            // 
            this.ViewProds_Btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProds_Btn.Location = new System.Drawing.Point(265, 28);
            this.ViewProds_Btn.Name = "ViewProds_Btn";
            this.ViewProds_Btn.Size = new System.Drawing.Size(156, 78);
            this.ViewProds_Btn.TabIndex = 3;
            this.ViewProds_Btn.Text = "Переглянути товари";
            this.ViewProds_Btn.UseVisualStyleBackColor = true;
            this.ViewProds_Btn.Click += new System.EventHandler(this.ViewProds_Btn_Click);
            this.ViewProds_Btn.MouseEnter += new System.EventHandler(this.ViewProds_Btn_MouseEnter);
            this.ViewProds_Btn.MouseLeave += new System.EventHandler(this.ViewProds_Btn_MouseLeave);
            // 
            // AddDel_Btn
            // 
            this.AddDel_Btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDel_Btn.Location = new System.Drawing.Point(43, 28);
            this.AddDel_Btn.Name = "AddDel_Btn";
            this.AddDel_Btn.Size = new System.Drawing.Size(156, 78);
            this.AddDel_Btn.TabIndex = 1;
            this.AddDel_Btn.Text = "Додати/Видалити товар";
            this.AddDel_Btn.UseVisualStyleBackColor = true;
            this.AddDel_Btn.Click += new System.EventHandler(this.AddDel_Btn_Click);
            this.AddDel_Btn.MouseEnter += new System.EventHandler(this.AddDel_Btn_MouseEnter);
            this.AddDel_Btn.MouseLeave += new System.EventHandler(this.AddDel_Btn_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StoreManagerPlace_App.Properties.Resources.mainPic;
            this.pictureBox1.InitialImage = global::StoreManagerPlace_App.Properties.Resources.mainPic;
            this.pictureBox1.Location = new System.Drawing.Point(43, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 459);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddDel_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.Button SessStat_Btn;
        private System.Windows.Forms.Button CreateOrder_Btn;
        private System.Windows.Forms.Button ViewProds_Btn;
    }
}