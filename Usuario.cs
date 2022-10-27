using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Usuario
    {
        public string User { get; }
        public string Contrasenia { get; }

        public Usuario()
        {
            User = "admin";
            Contrasenia = "1234";
        }
    }
}
