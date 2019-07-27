using FisioAvalia.Models.Base;

namespace FisioAvalia.Models.Users
{
    public class User : Entity
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        public bool CheckUserInformation()
        {
            if (!this.Email.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        }
    }
}
