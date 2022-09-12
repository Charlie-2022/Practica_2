using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2._1
{
    internal class Program

    {
        static void Main(string[] args)
        {
            int edad = 22;
            string nombre = "Charlie Perez Neri";
            string pais = "Mexico";
            
            string concat = +edad + nombre + pais;
            Console.WriteLine(concat);
        }
    }
}
