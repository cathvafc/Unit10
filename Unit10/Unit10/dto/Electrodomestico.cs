using System;
using System.Collections.Generic;
using System.Text;

namespace Unit10
{
    class Electrodomestico
    {
        //valores por defecto
        const string BLANCO = "Blanco";
        const string ROJO = "Rojo";
        const string AZUL= "Azul";
        const string NEGRO = "Negro";
        const string GRIS = "Gris";
        const string CONSUMO = "F";
        const double PRECIO = 100;
        const double PESO = 5;

        //Atributos
        private double precioBase = PRECIO;
        string color = BLANCO;
        private string consumoEnergetico = CONSUMO;
        private double peso = PESO;

        public Electrodomestico()
        {

        }

        public Electrodomestico(double precio, double peso)
        {
            this.peso = peso;
            this.precioBase = precio;
        }

        public Electrodomestico(double precio, double peso, string color, string consumo)
        {
            this.peso = peso;
            this.precioBase = precio;
            this.color = color;
            this.consumoEnergetico = consumo;
        }
    }
}
