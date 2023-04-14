namespace StoreManagerPlace_App.Context.EF
{
    using Entities;
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext(string connectStr)
            : base(connectStr)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
