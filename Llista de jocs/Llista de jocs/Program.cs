﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Llista_de_jocs
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcio = "";
            do
            {
                Console.WriteLine("MENU:" +
                    "\n0. Sortir" +
                    "\n1. Buscaminas" +
                    "\n2. Solitario" +
                    "\n3. Tetris" +
                    "\n4. Canvis company");

            } while ((opcio = Console.ReadLine()) != "0");
        }
    }
}
