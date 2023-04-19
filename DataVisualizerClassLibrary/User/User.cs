using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVisualizerClassLibrary.User
{
    public abstract class User
    {
        //parent class to create characters and mobs from
        public User(string name, string password)
        {
            Name = name;
            Password = password;

        }

        public string Name { get; set; }
        public string Password { get; set; }


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public User() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
