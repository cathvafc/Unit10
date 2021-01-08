using System;

namespace Unit10
{
    class Program
    {
        static void Main(string[] args)
        {

            int edad = 0;
            char sexo;
            double peso = 0;
            double altura = 0;
            string name = "";

            
          

            Console.WriteLine("Inserta el nombre: ");
            name = Console.ReadLine();
            Console.WriteLine("Inserta el sexo: H (hombre) o M (Mujel) ");
            sexo = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Inserta el peso en kg: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserta la edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserta la altura en metros: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Persona person1 = new Persona(name,edad,sexo,peso,altura);
            Persona person2 = new Persona(name,edad,sexo);
            Persona person3 = new Persona();

            Console.WriteLine("----------------------------------------------------------------");

           person3.setNombre("Jorgito");
            person3.setEdad(18);
            person3.setSexo('X');
            person3.setPeso(75);
            person3.setAltura(170);

            Console.WriteLine("----------------------------------------------------------------");

            TieneSobrepeso(person1);
            TieneSobrepeso(person2);
            TieneSobrepeso(person3);

            Console.WriteLine("----------------------------------------------------------------");

            EsMayorDeEdad(person1);
            EsMayorDeEdad(person2);
            EsMayorDeEdad(person3);

            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("{0}", person1.toString()); 
            Console.WriteLine("{0}", person2.toString()); 
            Console.WriteLine("{0}", person3.toString());

            Console.WriteLine("----------------------------------------------------------------");

        }

        public static void TieneSobrepeso(Persona person)
        {
            if (person.CalcularIMC() == -1)
            {
                Console.WriteLine(" {0} está por debajo de su peso Ideal", person.getName());
            }
            else if (person.CalcularIMC() == 0)
            {
                Console.WriteLine("{0} está en su peso ideal", person.getName());
            }
            else
            {
                Console.WriteLine("{0} está con sobrepeso", person.getName());
            }
        }

        public static void EsMayorDeEdad(Persona person)
        {
            if(person.EsMayorDeEdad())
            {
                Console.WriteLine("{0} es mayor de edad", person.getName());
            }
            else
            {
                Console.WriteLine("{0} no es mayor de edad", person.getName());
            }
        }
    }
}
