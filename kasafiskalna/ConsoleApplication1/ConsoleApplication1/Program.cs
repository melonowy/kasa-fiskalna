﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplikacja nowe = new Aplikacja();
            nowe.WczytajKlawisz();
            nowe.WykonajDzialanie(Convert.ToChar(Console.ReadLine()));

        }
    }
}
