namespace CSharpFundamentals.Models
{
    public class UserProfile
    {
        private string _username;
        private DateTime _registrationDate;
        private string _email;


        public string username;
        public DateTime registrationDate;
        public string email;

        public UserProfile(string username, string email)
        {
          _username = username;
          _email = email;
          _registrationDate = DateTime.Now;
        
        }


        

        public string GetUserName()
        {
            
            return _username;
            
        }

        public DateTime GetRegistrationDate()
        {
            
            return _registrationDate;
        }

        public string GetEmail()
        {
            
            return _email;
        }


        public  void UpdateEmail(string newEmail)
        {
            _email = newEmail;
            Console.WriteLine($"Email updated successfully to: {newEmail}");
        }


       
    }

    
}
