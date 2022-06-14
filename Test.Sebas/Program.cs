using System;
using System.Collections.Generic;

namespace Test.Sebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ingredientes> listaingredientes = new List<Ingredientes>();
            bool masingredientes = true;
            do
            {
                Console.WriteLine("Introuce el nombre del ingrediente " + (listaingredientes.Count + 1));
                Ingredientes ingr= new Ingredientes();
                ingr.Name=Console.ReadLine();
                Console.WriteLine("Introuce las calorias del ingrediente " + ingr.Name);
                ingr.Calorias=double.Parse(Console.ReadLine());
                listaingredientes.Add(ingr);
                Console.WriteLine("Quiere agregar mas ingredientes? S/N");
                string respuesta= Console.ReadLine();
                if (respuesta == "S")
                {
                    masingredientes = true;
                }
                else if (respuesta == "N")
                {
                    masingredientes= false;
                }
            }
            while (masingredientes==true);
            Console.WriteLine("Numero Ingredientes: "+listaingredientes.Count);
        }
    }
    public class Ingredientes
    {
        public string Name { get; set; }
        public double Calorias { get; set; }
    }
}
