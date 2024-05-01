namespace iTransition4.Models
{
    public class CreateUserViewModel
    {
        private string fullName;
        private string email;
        private string password;


        public string FullName
        {
            get => fullName; set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Full Name cannot be empty!");
                fullName = value;
            }
        }
        public string Email
        {
            get => email; set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Email cannot be emoty");
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
        public DateTime LastLoginTime { get; set; }
        public DateTime RegistrationTime { get; set; }
        public Status IsBlocked { get; set; } = Status.Active;
    }
}
