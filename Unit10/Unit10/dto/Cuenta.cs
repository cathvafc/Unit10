using System;
using System.Collections.Generic;
using System.Text;

namespace Unit10.dto
{
    class Cuenta
    {
        private string titular = "";
        private double cantidad = 0;

        public Cuenta(string titular)
        {
            this.titular = titular;        
        }

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public void Ingresar (double cantidad)
        {

            if (cantidad > 0 )
            {
                this.cantidad += cantidad;
            }

        }

        public void Retirar(double cantidad)
        {
            this.cantidad -= cantidad;

            if (this.cantidad < 0)
                this.cantidad = 0;

        }


        public void setTitular(string titular)
        {
            this.titular = titular;
        }

        public void setCantidad(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public string getTitular ()
        {
            return titular;
        }

        public double getCantidad()
        {
            return cantidad;
        }

        public string toString()
        {
            return titular + cantidad;
        }

    }
}
