﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona0._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> Persone = new List<Persona>();

            for (int i = 0; i < 3; i++)
            {
                Persone.Add(new Persona(Console.ReadLine(),int.Parse(Console.ReadLine())));   
            }

            for(int i = 0;i <Persone.Count;i++)
            {
                if (Persone[i].Eta>=18)
                {
                    Console.WriteLine(Persone[i].ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
