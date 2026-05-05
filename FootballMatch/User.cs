namespace FootballMatch
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public bool IsAdmin => Role == "admin";

        public User(int id, string login, string email, string role = "user")
        {
            Id = id;
            Login = login;
            Email = email;
            Role = role;
        }
    }
}
