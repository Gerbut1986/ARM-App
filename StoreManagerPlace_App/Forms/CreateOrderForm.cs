namespace StoreManagerPlace_App.Forms
{
    using Services;
    using System.Linq;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using StoreManagerPlace_App.Entities;

    public partial class CreateOrderForm : Form
    {
        private bool isClickEvent = false;
        private readonly SMP_Service service;
        private IEnumerable<Product> products;
        private IEnumerable<Category> categories;
        private Order SelectedOrder { get; set; }
        private Product SelectedProduct { get; set; }

        public CreateOrderForm()
        {
            InitializeComponent();
            Delete_Btn.Visible = false;
            service = new SMP_Service(Entities.Security.Credential.ConnectStr);          
        }

        private void CreateOrderForm_Load(object sender, System.EventArgs e)
        {
            categories = service.GetCategories().ToList();
            products = service.GetProducts().ToList();
            foreach (var pr in products)
                Products_Cmb.Items
                    .Add($"[{categories.FirstOrDefault(p => p.Id == pr.CategoryId).Name}]: {pr.Name}");
        }

        private void Products_Cmb_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selProd = Products_Cmb.SelectedItem.ToString().Split(new char[] { ':' });
            SelProt_Lst.ForeColor = Color.Green;
            SelProt_Lst.Items.Clear();
            SelProt_Lst.Refresh();
            SelectedProduct = products.FirstOrDefault(n => n.Name.Equals(selProd[1].Remove(0, 1)));
            if (SelectedProduct != null)
            {
                SelProt_Lst.Items.Add("Категорія:");
                SelProt_Lst.Items.Add(
                    categories.FirstOrDefault(n => n.Id == SelectedProduct.CategoryId).Name);
                SelProt_Lst.Items.Add("Назва товару:");
                SelProt_Lst.Items.Add(SelectedProduct.Name);
                if (SelectedProduct.Description != null)
                {
                    SelProt_Lst.Items.Add("Опис:");
                    SelProt_Lst.Items.Add(SelectedProduct.Description);
                }
                SelProt_Lst.Items.Add("Дата в-ва:");
                SelProt_Lst.Items.Add(SelectedProduct.DateRelease);
                SelProt_Lst.Items.Add("Ціна:");
                SelProt_Lst.Items.Add(SelectedProduct.Price);
                SelProt_Lst.Items.Add("В наявновті:");
                SelProt_Lst.Items.Add(SelectedProduct.IsStock ? "Так" : "Ні");
            }
            else return;
        }

        private void Add_Btn_Click(object sender, System.EventArgs e)
        {
            if (SelProt_Lst.Items.Count == 0) return;
            Order_Lst.Items.Add(SelectedProduct);
            ClearList();
        }

        private void Order_Btn_Click(object sender, System.EventArgs e)
        {
            if (Order_Lst.Items.Count == 0) return;
            try
            {
                var order = new Order();
                order.TotalPrice = 0;
                foreach (var item in Order_Lst.Items)
                {
                    order.ListOfProducts += (item as Product).Name + ",";
                    order.TotalPrice += (item as Product).Price;
                }
                order.OrderNumber = System.Guid.NewGuid();
                order.UserName = (Owner as MainForm).CurrentUser.FirstName + " " +
                    (Owner as MainForm).CurrentUser.LastName;
                order.OrderDate = System.DateTime.Now;
                order.UserId = (Owner as MainForm).CurrentUser.Id;
                service.AddOrder(order);
                MessageBox.Show("Замовлення успішно створене, та добавлено у базу данних!",
                    "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearList(true);
            }
            catch(System.Exception ex) 
            {
                MessageBox.Show(ex.Message, "..Щось пішло не так...", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
        }

        private void ClearList(bool isOrder = false)
        {
            if (isOrder)
            {
                Order_Lst.Items.Clear();
                Order_Lst.Refresh();
            }
            else
            {
                SelProt_Lst.Items.Clear();
                SelProt_Lst.Refresh();
            }
        }

        private void Order_Lst_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Delete_Btn.Visible = true;
            if(Order_Lst.Items.Count > 0)
            {
                Order_Btn.Enabled = true;
                Order_Btn.BackColor = Color.Green;
                Order_Btn.ForeColor = Color.White;
            }
            else
            {
                Order_Btn.Enabled = false;
            }
        }

        private void Delete_Btn_MouseEnter(object sender, System.EventArgs e)
        {
            Delete_Btn.BackColor = Color.Black;
            Delete_Btn.ForeColor = Color.Red;
        }

        private void Delete_Btn_MouseLeave(object sender, System.EventArgs e)
        {
            Delete_Btn.BackColor = Color.Red;
            Delete_Btn.ForeColor = Color.Black;
        }

        private void Delete_Btn_Click(object sender, System.EventArgs e)
        {
            var selProd = Order_Lst.SelectedItem as Product;
            if (selProd != null)
            {
                Order_Lst.Items.Remove(selProd);
                Delete_Btn.Visible = false;
            }
            else return;
        }
    }
}
