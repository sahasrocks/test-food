using System.ComponentModel.DataAnnotations;

namespace Project2.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? EmailId { get; set; }
        public string? Password { get; set; }
        public string? Mobileno { get; set; }
        public string? Address { get; set; }
        public string? UserType
        {
            get; set;
        }
    }
}

