using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataVisualizerClassLibrary.User;


namespace DataVisualizerClassLibrary.User
{
    internal class Admin : User
    {
        public new string Name;
        public new string Password;
        public Admin(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}
