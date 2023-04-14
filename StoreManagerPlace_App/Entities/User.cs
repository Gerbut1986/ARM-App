namespace StoreManagerPlace_App.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public System.DateTime DateRegister { get; set; }
        public System.DateTime DateEnter { get; set; }
        public System.DateTime DateExit { get; set; }
    }

    public class UserLoginModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
