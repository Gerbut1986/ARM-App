namespace StoreManagerPlace_App.Forms
{
    using System;
    using System.Data;
    using System.Windows.Forms;
    using StoreManagerPlace_App.Services;

    public partial class ListForm : Form
    {
        private readonly SMP_Service service;

        public ListForm()
        {
            InitializeComponent();
            service = new SMP_Service(Entities.Security.Credential.ConnectStr);
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.dataSet.Products);

            DataSet ds = new DataSet();
            ds = service.GetProductsADO();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoResizeColumn((int)DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
