namespace StockFlowERP.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // "Admin", "User"
    }
} 