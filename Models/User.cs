namespace TaskGenius.Models

{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }

        // Construtor
        public User(int id, string username, string password, string fullName)
        {
            UserId = id;
            Username = username;
            Password = password;
            FullName = fullName;
        }
    }
}
