using System;
using System.Collections.Generic;
using System.Text;

namespace Unit10
{
    class Persona
    {
        const string H = "Hombre";
        const string M = "Mujer";

        private string name = "";
        private int edad = 0;
        private string dni = "";
        private string sexo = H;
        private double peso = 0;
        private double altura = 0;
        public Persona()
        {
            
        }
        public Persona(string name, int edad, string sexo)
        {
            this.name = name;
            this.edad = edad;
            this.sexo = sexo;

        }

        public Persona(string name, int edad, string sexo, double peso, double altura, string dni)
        {
            this.name = name;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
            this.dni = dni;
        }
        public void setNombre(string name)
        {
            this.name = name;
        }
        public void Saludar()
        {
            Console.WriteLine("Hola, soy {0}", name);
        }
    }
}
