using System;
using System.Collections.Generic;

namespace EXPRESIONES_LAMBDA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Edad = new List<int>();
            Edad.AddRange(new int[] { 60, 70, 35, 28, 20, 76, 46 });
            Console.WriteLine("Verificador de edad");

            List<int> Edades = Edad.FindAll((i) =>
            {
                int Valor = 140;
                if (i >= 60)
                {
                    Console.WriteLine("Persona de tecera edad, su pago es de:");
                    double Pagar = Valor * 0.50;
                    Console.WriteLine("$" + (Valor + Pagar));
                    return true;
                }
                else
                {
                    Console.WriteLine("Aun no es de la tecera edad, su pago es de:");
                    Console.WriteLine("$" + Valor);
                    return false;
                }
            });
            Console.WriteLine("Las edades de las personas de la tercera edad son:");
            foreach (int n in Edades)
                Console.WriteLine("Edades de :" + n);
            Console.ReadLine();
        }
    }
}
