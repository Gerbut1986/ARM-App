namespace StoreManagerPlace_App.Forms
{
    using System.Linq;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using StoreManagerPlace_App.Entities;
    using StoreManagerPlace_App.Services;

    public partial class AddDelForm : Form
    {
        private readonly SMP_Service service;

        public AddDelForm(IEnumerable<Product> products)
        {
            InitializeComponent();
            Add_Rb.Checked = true;
            Delete_Btn.Enabled = false;
            this.Size = new Size(new Point(342, 519)); 
            service = new SMP_Service(Entities.Security.Credential.ConnectStr);
            Products_Lst.Items.AddRange(service.GetProducts().Select(n => n.Name).ToArray());
        }

        private void Products_Lst_MouseEnter(object sender, System.EventArgs e)
        {
            toolTip1.SetToolTip(Products_Lst, "Вибери любий продукт зі списку, та натисни кнопку Видалити.");
        }      

        private void Add_Rb_CheckedChanged(object sender, System.EventArgs e)
        {
            this.Size = new Size(new Point(342, 519));
        }  
        
        private void Del_Rb_CheckedChanged(object sender, System.EventArgs e)
        {
            this.Size = new Size(new Point(752, 519));
        }

        private void Products_Lst_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Delete_Btn.Enabled = true;
            Delete_Btn.BackColor = Color.Red;
        }

        private void Delete_Btn_Click(object sender, System.EventArgs e)
        {
            try
            {
                var selProdName = Products_Lst.SelectedItem.ToString();
                service.DeleteProduct(service.GetProducts().FirstOrDefault(n => n.Name.Equals(selProdName)));
                Products_Lst.Items.Remove(selProdName);
                MessageBox.Show("Вибраний продукт успішно видалений з дази данних!",
                    "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Щось пішло не так під час видалення...",
                    "..Faild..", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }
            finally { Delete_Btn.Enabled = false; }
        }
    }
}
