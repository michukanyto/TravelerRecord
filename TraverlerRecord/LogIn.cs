using System;
namespace TraverlerRecord
{
    public class LogIn
    {
        private string userName;
        private string password;

        public LogIn(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public string UserName
        {
            get => userName;
            set => userName = value ;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public bool CheckLogIn()
        {
            if (userName == "admin" && password == "12345")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
