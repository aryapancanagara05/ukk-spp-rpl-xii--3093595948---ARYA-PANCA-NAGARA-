using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_csharp.Models
{
    internal class SessionUser
    {
        public SessionUser(string idPetugas, string username, string namaPetugas, string password, string level, string isLoggedIn)
        {
            this.idPetugas = idPetugas;
            Username = username;
            this.namaPetugas = namaPetugas;
            Password = password;
            this.level = level;
            IsLoggedIn = isLoggedIn;
        }

        public string idPetugas { get; set; }
        public string Username { get; set; }
        public string namaPetugas { get; set; }
        public string Password { get; set; }
        public string level { get; set; }
        public string IsLoggedIn { get; set; }

    }
}
