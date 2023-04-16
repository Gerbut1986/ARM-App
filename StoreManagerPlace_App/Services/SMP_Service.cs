namespace StoreManagerPlace_App.Services
{
    using StoreManagerPlace_App.Entities.Security;
    using StoreManagerPlace_App.Context.EF;
    using StoreManagerPlace_App.Entities;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data;

    public class SMP_Service
    {
        private readonly DataContext db;

        public SMP_Service(string conStr)
        {
            db = new DataContext(connectStr: conStr);
        }

        #region Users:
        public IEnumerable<User> GetUsers()
        {
            return db.Users;
        }

        public string UpdateUser(User user)
        {
            if (user != null)
            {
                db.Users.Add(user);
                var res = db.SaveChanges();
                return res == 1 ? $"{user.FirstName + " " + user.LastName} успішно оновлено в таблицю Users!"
                    : "Помилка при добавленні нового товару...";
            }
            else return $"Модель {nameof(User)} пуста...";
        }

        #endregion

        #region Products:
        public IEnumerable<Product> GetProducts()
        {
            return db.Products;
        }

        public DataSet GetProductsADO()
        {
            SqlConnection conn = null; DataSet dataSet = null;  
                using (conn = new SqlConnection(Credential.ConnectStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Products", conn);
                    SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                    dataSet = new DataSet();
                    sqlAdapter.Fill(dataSet);
                    cmd.ExecuteNonQuery();
                }

            return dataSet;
        }

        public string AddProduct(Product prod)
        {
            if (prod != null)
            {
                db.Products.Add(prod);
                var res = db.SaveChanges();
                return res == 1 ? $"{prod.Name} успішно добавлений в таблицю Products!"
                    : "Помилка при добавленні нового товару...";
            }
            else return "Ви не створили продукт ще...";
        }

        public string DeleteProduct(Product prod)
        {
            if (prod != null)
            {
                db.Products.Remove(prod);
                var res = db.SaveChanges();
                return res == 1 ? $"{prod.Name} успішно видалений з таблиці Products!"
                    : "Помилка при добавленні нового товару...";
            }
            else return "Ви не вибрали продукт ще...";
        }
        #endregion

        #region Category:
        public IEnumerable<Category> GetCategories()
        {
            return db.Categories;
        }
        #endregion

        #region Orders:
        public IEnumerable<Product> GetOrders()
        {
            return db.Products;
        }

        public DataSet GetOrdersADO()
        {
            SqlConnection conn = null; DataSet dataSet = null;
                using (conn = new SqlConnection(Credential.ConnectStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Orders", conn);
                    SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                    dataSet = new DataSet();
                    sqlAdapter.Fill(dataSet);
                    cmd.ExecuteNonQuery();
                }

            return dataSet;
        }

        public string AddOrder(Order order)
        {
            if (order != null)
            {
                db.Orders.Add(order);
                var res = db.SaveChanges();
                return res == 1 ? $"{res} замовлення № {order.OrderNumber} успішно добавленo в таблицю Orders!"
                    : "Помилка при добавленні нового товару...";
            }
            else return "Ви не створили замовлення ще...";
        }
        #endregion
    }
}
