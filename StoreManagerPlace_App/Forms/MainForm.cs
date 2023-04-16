namespace StoreManagerPlace_App.Forms
{
    using StoreManagerPlace_App.Entities;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Drawing;
    using System;

    public partial class MainForm : Form
    {
        private IEnumerable<Product> productsLst;
        private DateTime DateEnter { get; set; }
        public User CurrentUser { get; }

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(User entered, IEnumerable<Product> productsLst)
        {
            InitializeComponent();
            CurrentUser = entered;
            DateEnter = DateTime.Now;
            this.productsLst = productsLst;
            this.Text = $"Привіт - {entered.FirstName} {entered.LastName}!";
        }

        #region Button's 'Click' event hundlers:
        private void AddDel_Btn_Click(object sender, EventArgs e)
        {
            new AddDelForm().ShowDialog();
        }

        private void ViewProds_Btn_Click(object sender, EventArgs e)
        {
            new ListForm().ShowDialog();
        }

        private void CreateOrder_Btn_Click(object sender, EventArgs e)
        {
            var cof = new CreateOrderForm();
            cof.Owner = this;
            cof.ShowDialog();
        }

        private void SessStat_Btn_Click(object sender, EventArgs e)
        {
            new TradeSessStatForm().ShowDialog();
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            (Owner as LoginForm).CurrentUser.DateEnter = DateEnter;
            this.Close();
        }
        #endregion

        #region Button's 'MouseEnter & MouseLeave' event hundlers:
        private void AddDel_Btn_MouseEnter(object sender, EventArgs e)
        {
            AddDel_Btn.BackColor = Color.Black;
            AddDel_Btn.ForeColor = Color.White;
        }

        private void AddDel_Btn_MouseLeave(object sender, EventArgs e)
        {
            AddDel_Btn.BackColor = Color.WhiteSmoke;
            AddDel_Btn.ForeColor = Color.Black;
        }

        private void ViewProds_Btn_MouseEnter(object sender, EventArgs e)
        {

            ViewProds_Btn.BackColor = Color.Black;
            ViewProds_Btn.ForeColor = Color.White;
        }

        private void ViewProds_Btn_MouseLeave(object sender, EventArgs e)
        {
            ViewProds_Btn.BackColor = Color.WhiteSmoke;
            ViewProds_Btn.ForeColor = Color.Black;
        }

        private void CreateOrder_Btn_MouseEnter(object sender, EventArgs e)
        {
            CreateOrder_Btn.BackColor = Color.Black;
            CreateOrder_Btn.ForeColor = Color.White;
        }

        private void CreateOrder_Btn_MouseLeave(object sender, EventArgs e)
        {
            CreateOrder_Btn.BackColor = Color.WhiteSmoke;
            CreateOrder_Btn.ForeColor = Color.Black;
        }

        private void SessStat_Btn_MouseEnter(object sender, EventArgs e)
        {
            SessStat_Btn.BackColor = Color.Black;
            SessStat_Btn.ForeColor = Color.White;
        }

        private void SessStat_Btn_MouseLeave(object sender, EventArgs e)
        {
            SessStat_Btn.BackColor = Color.WhiteSmoke;
            SessStat_Btn.ForeColor = Color.Black;
        }

        private void Exit_Btn_MouseEnter(object sender, EventArgs e)
        {
            Exit_Btn.BackColor = Color.DarkRed;
            Exit_Btn.ForeColor = Color.White;
        }

        private void Exit_Btn_MouseLeave(object sender, EventArgs e)
        {
            Exit_Btn.BackColor = Color.WhiteSmoke;
            Exit_Btn.ForeColor = Color.DarkRed;
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            (Owner as LoginForm).CurrentUser.DateEnter = DateEnter;
        }

        #region Auxiliary method:

        #endregion
    }
}
