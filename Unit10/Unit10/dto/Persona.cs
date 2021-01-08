using System;
using System.Collections.Generic;
using System.Text;

namespace Unit10
{
    class Persona
    {
        Random rand = new Random();

        const char H = 'H';
        const char M = 'M';
        const int LOWIMC = -1;
        const int MIDIMC = 0;
        const int HIGHIMC = 1;

        private string name = "";
        private int edad = 0;
        private string dni = "";
        private char sexo = H;
        private double peso = 0;
        private double altura = 0;
        public Persona()
        {
            GeneraDNI();
        }
        public Persona(string name, int edad, char sexo)
        {
            this.name = name;
            this.edad = edad;
            this.sexo = sexo;
            ComprobarSexo(sexo);
            GeneraDNI();
        }

        public Persona(string name, int edad, char sexo, double peso, double altura)
        {
            this.name = name;
            this.edad = edad;
            this.sexo = sexo;
            ComprobarSexo(sexo);
            this.peso = peso;
            this.altura = altura;
  
            GeneraDNI();
        }

        public int CalcularIMC()
        {
            double result = peso / Math.Pow(altura, 2);

            if (result < 20)
            {
                return LOWIMC;
            }
            else if (20 <= result && result <= 25)
            {
                return MIDIMC;
            }
            else
            {
                return HIGHIMC;
            }
        }

        public bool EsMayorDeEdad()
        {
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public void setNombre(string name)
        {
            this.name = name;
        }
        public void setEdad (int edad)
        {
            this.edad = edad;
        }

        public void setSexo(char sexo)
        {
            this.sexo = sexo;
            ComprobarSexo(sexo); //Siempre comprobamos el sexo y si no es H o M, por defecto será H.
        }

        public void setPeso (double peso)
        {
            this.peso = peso;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public string toString()
        {
            return string.Format("Name: {0}, DNI: {1} Peso: {2} Altura: {3}, Sexo: {4}, Edad: {5}.", name, dni, peso, altura, sexo , edad);
        }

        public string getName ()
        {
            return name;
        }


        /// <summary>
        /// Se comprueba si el sexo es M o H. Por defecto H.
        /// </summary>
        /// <param name="sexo"></param>
        private void ComprobarSexo(char sexo)
        {
            if (sexo != H || sexo != M)
                this.sexo = H;
        }
        private void GeneraDNI()
        {
            char letraDNI;
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int longitud = 0;
           
            longitud = caracteres.Length;
            letraDNI = caracteres[rand.Next(longitud)];


            int longitudNumDni = 8;

            for (int i = 0; i < longitudNumDni; i++)
            {
                dni += rand.Next(0, 9);
            }

            dni += letraDNI;

        }

        
    }
}
