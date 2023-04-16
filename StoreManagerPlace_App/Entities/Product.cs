namespace StoreManagerPlace_App.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public System.DateTime DateRelease { get; set; }
        public int CategoryId { get; set; }
        public string Photo { get; set; }
        public bool IsStock { get; set; }
        public override string ToString()
        {
            var isStock = IsStock ? "Так" : "Ні";
            return $"Назва: {Name}\nОпис: {Description}\n" +
                $"Ціна: {Price}\nДата в-ва: {DateRelease}\nВ наявності: {isStock}\n";
        }
    }
}
