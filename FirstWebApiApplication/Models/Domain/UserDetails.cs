namespace FirstWebApiApplication.Models.Domain
{
    public class UserDetails
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Specilization { get; set; }
        public bool IsEmployee { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public string Role { get; set; }

    }
}
