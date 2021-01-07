using System;
using System.Collections.Generic;
using System.Text;

namespace Unit10
{
    class Password
    {
        Random rdn = new Random();
    
        private int longitudContraseña = 8;
        private char letra;

        private string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
        private int longitud = 0;
        string contraseñaAleatoria = "";

        public Password()
        {
          
        }

        public Password(int longitudContraseña)
        {
            this.longitudContraseña = longitudContraseña;
        }

        public string GenerarContraseña()
        {
            longitud = caracteres.Length;

            for (int i = 0; i < longitudContraseña; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                contraseñaAleatoria += letra.ToString();
            }

            return contraseñaAleatoria;
        }    
    }
}
