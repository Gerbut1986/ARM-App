namespace StoreManagerPlace_App
{
    partial class LoginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_Txt = new System.Windows.Forms.TextBox();
            this.Pass_Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Enter_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Error_Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StoreManagerPlace_App.Properties.Resources.user_login;
            this.pictureBox1.Location = new System.Drawing.Point(147, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логін :";
            // 
            // Login_Txt
            // 
            this.Login_Txt.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Txt.Location = new System.Drawing.Point(151, 82);
            this.Login_Txt.Name = "Login_Txt";
            this.Login_Txt.Size = new System.Drawing.Size(229, 28);
            this.Login_Txt.TabIndex = 2;
            // 
            // Pass_Txt
            // 
            this.Pass_Txt.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_Txt.Location = new System.Drawing.Point(151, 133);
            this.Pass_Txt.Name = "Pass_Txt";
            this.Pass_Txt.PasswordChar = '*';
            this.Pass_Txt.Size = new System.Drawing.Size(229, 28);
            this.Pass_Txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль :";
            // 
            // Enter_Btn
            // 
            this.Enter_Btn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_Btn.Location = new System.Drawing.Point(73, 199);
            this.Enter_Btn.Name = "Enter_Btn";
            this.Enter_Btn.Size = new System.Drawing.Size(142, 39);
            this.Enter_Btn.TabIndex = 5;
            this.Enter_Btn.Text = "Увійти";
            this.Enter_Btn.UseVisualStyleBackColor = true;
            this.Enter_Btn.Click += new System.EventHandler(this.Enter_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Btn.Location = new System.Drawing.Point(228, 199);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(142, 39);
            this.Cancel_Btn.TabIndex = 6;
            this.Cancel_Btn.Text = "Закрити";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Error_Lbl);
            this.groupBox1.Controls.Add(this.Cancel_Btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Enter_Btn);
            this.groupBox1.Controls.Add(this.Login_Txt);
            this.groupBox1.Controls.Add(this.Pass_Txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 263);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автоматизоване робоче місце менеджера магазину ";
            // 
            // Error_Lbl
            // 
            this.Error_Lbl.AutoSize = true;
            this.Error_Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Error_Lbl.Location = new System.Drawing.Point(101, 37);
            this.Error_Lbl.Name = "Error_Lbl";
            this.Error_Lbl.Size = new System.Drawing.Size(0, 18);
            this.Error_Lbl.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(445, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Авторизація]";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Login_Txt;
        private System.Windows.Forms.TextBox Pass_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Enter_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Label Error_Lbl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

