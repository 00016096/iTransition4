namespace iTransition4.Models
{
    public class User
    {
        private string fullName;
        private string email;
        private string password;

        public Guid Id { get; set; }
        public string FullName
        {
            get => fullName; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Full Name cannot be empty");
                }
                fullName = value;
            }
        }
        public string Email
        {
            get => email; set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Email cannot be empty");
                email = value;
            }
        }
        public string Password
        {
            get => password; set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Password cannot be empty");
                password = value;
            }
        }
        public DateTime? LastLoginTime { get; set; } = DateTime.MinValue;
        public DateTime RegistrationTime { get; set; }
        public Status IsBlocked { get; set; } = Status.Active;
    }
}
