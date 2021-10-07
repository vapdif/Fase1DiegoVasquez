using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1DiegoVasquez
{
    public class User
    {
        private String autor, app, username, fName;
        private int login = 123;

        //constructor
        public User(string autor, string app, string username, string fName, int login)
        {
            this.Autor = autor;
            this.App = app;
            this.Username = username;
            this.FName = fName;
            this.Login = login;
        }

        //encapsulamos
        public string Autor { get => autor; set => autor = value; }
        public string App { get => app; set => app = value; }
        public string Username { get => username; set => username = value; }
        public string FName { get => fName; set => fName = value; }
        public int Login { get => login; set => login = value; }        
    }
}
