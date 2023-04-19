using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataVisualizerClassLibrary.User;

namespace DataVisualizerClassLibrary.User
{
    public class EndUser : User
    {
        public new string Name { get; set; }
        public new string Password { get; set; }
        public EndUser(string name, string password)
        {
            Name = name;
            Password = password;
        } 
        
    }
}
