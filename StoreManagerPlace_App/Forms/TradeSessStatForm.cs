namespace StoreManagerPlace_App.Forms
{
    using StoreManagerPlace_App.Services;
    using System.Data;
    using System.Windows.Forms;

    public partial class TradeSessStatForm : Form
    {
        private readonly SMP_Service service;

        public TradeSessStatForm()
        {
            InitializeComponent();
            service = new SMP_Service(Entities.Security.Credential.ConnectStr);
        }

        private void TradeSessStatForm_Load(object sender, System.EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = service.GetProductsADO();
            Orders_Dgv.DataSource = ds.Tables[0];
            Orders_Dgv.AutoResizeColumn((int)DataGridViewAutoSizeColumnsMode.AllCells);

            ds = service.GetUsersADO();
            Users_Dgv.DataSource = ds.Tables[0];
            Users_Dgv.AutoResizeColumn((int)DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
