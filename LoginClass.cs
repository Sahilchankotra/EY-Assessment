using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSite_GUI
{
    internal class LoginClass
    {
        private string _username = "admin";
        private string _password = "admin";
        
        public bool LoginMethod(string username, string password)
        {
         
                if (username.Equals(_username) && password.Equals(_password))
                {
                    Console.WriteLine("Welcome: " + _username);
                    
                   return true;
                }
                else
                {
                return false;
                
               
            }
        }
    }
}
