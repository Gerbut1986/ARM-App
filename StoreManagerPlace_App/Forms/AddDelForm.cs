namespace StoreManagerPlace_App.Forms
{
    using System;
    using System.Linq;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using StoreManagerPlace_App.Entities;
    using StoreManagerPlace_App.Services;

    public partial class AddDelForm : Form
    {
        private readonly SMP_Service service;
        private readonly List<Category> categories;

        public AddDelForm()
        {
            InitializeComponent();
            Add_Rb.Checked = true;
            Delete_Btn.Enabled = false;
            this.Size = new Size(new Point(342, 519)); 
            service = new SMP_Service(Entities.Security.Credential.ConnectStr);
            categories = service.GetCategories().ToList();
            foreach(var c in categories)
                Category_Tb.Items.Add(c.Name);
            RefreshAndGetList();
        }

        private void Products_Lst_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Products_Lst, "Вибери любий продукт зі списку, та натисни кнопку Видалити.");
        }      

        private void Add_Rb_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(new Point(342, 519));
        }  
        
        private void Del_Rb_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(new Point(752, 519));
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Products_Lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            Delete_Btn.Enabled = true;
            Delete_Btn.BackColor = Color.Red;
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                var selProdName = Products_Lst.SelectedItem.ToString();
                service.DeleteProduct(service.GetProducts().FirstOrDefault(n => n.Name.Equals(selProdName)));
                Products_Lst.Items.Remove(selProdName);
                RefreshAndGetList();
                MessageBox.Show("Вибраний продукт успішно видалений з дази данних!",
                    "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Delete_Btn.Enabled = false;
            }
            catch 
            {
                MessageBox.Show("Щось пішло не так під час видалення...",
                    "..Faild..", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }
            finally { Delete_Btn.Enabled = false; }
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                var newProd = new Product();
                newProd.Name = Name_Tb.Text;
                newProd.Description = Description_Tb.Text;
                newProd.Price = int.Parse(Price_Tb.Text);
                newProd.DateRelease = DateTime.Parse(DateRelease_Tb.Text);
                newProd.CategoryId =
                    categories.FirstOrDefault(n => n.Name.Equals(Category_Tb.Text)).Id;
                newProd.Photo = Photo_Lbl.Text;
                newProd.IsStock = IsStock_Cbx.Checked;
                service.AddProduct(newProd);
                MessageBox.Show("Новий товар успішно добавлений в базу данних!", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshAndGetList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "System.Exception", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Upload_Btn_Click(object sender, EventArgs e)
        {
            using(var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FileName != null)
                    {
                        var splt = ofd.FileName.Split(new char[] { '\\' });
                        Photo_Lbl.Text = splt[splt.Length - 1];
                        Upload_Btn.Text = "Загружено!";
                        Upload_Btn.BackColor = Color.Green;
                        Upload_Btn.ForeColor = Color.White;
                    }
                }
            }
        }

        private IEnumerable<Product> RefreshAndGetList()
        {
            var prodLst = service.GetProducts();
            Products_Lst.Items.Clear();
            Products_Lst.Items.AddRange(prodLst.Select(n => n.Name).ToArray());
            return prodLst;
        }
    }
}
