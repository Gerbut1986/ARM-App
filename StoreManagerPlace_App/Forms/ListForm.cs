namespace StoreManagerPlace_App.Forms
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        public ListForm(DataSet products)
        {
            InitializeComponent();
            DataSet ds = new DataSet();
            ds = products;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoResizeColumn((int)DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ListForm_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'dataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.dataSet.Products);
        }
    }
}
