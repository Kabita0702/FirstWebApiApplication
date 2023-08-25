using FirstWebApiApplication.Models.Domain;

namespace FirstWebApiApplication.Models.DTO
{
    public class UserDetailsDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string UserEmail { get; set; }
        public Role Role { get; set; }
        public Boolean IsStudent { get; set; }

        public int UserId { get; set; }
        
    }
}
