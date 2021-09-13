using System;
using System.Collections.Generic;

namespace ACME_Cars
{
    class Program //GLÖM EJ ATT COMMITA
    {
        static void Main(string[] args)
        {
            List<Cars> car = new List<Cars>(); //Detta ska du träna på att skriva!
            bool a = true;
                
            while (a = true)
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("Welcome to ACME Cars industry program Copyrighted est.1999");
                Console.WriteLine("===========================================================");
                Console.WriteLine("S\tShow all cars\nX\tAdd car\nE\tEdit car\nD\tRemove car\nX\tExit program\n");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "S":
                            break;
                    case "S":
                        break;
                    case "S":
                        break;
                    case "S":
                        break;

                }
            }
        }
    }

    public class Cars //Color, Model, Make och Price i domänmodellen
    {
        public string Color { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Price { get; set; }
    }
}
