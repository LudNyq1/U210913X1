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
                Console.Clear();
                Console.WriteLine("Welcome to ACME Cars industry program Copyrighted est.1999");
                Console.WriteLine("===========================================================");
                Console.WriteLine("If you wish to return to the menu at any time while \nadding, removing och editing car, enter Q.");
                Console.WriteLine("===========================================================\n");
                Console.WriteLine("S\tShow all cars\nN\tAdd car\nE\tEdit car\nD\tRemove car\nX\tExit program\n");

                string choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "S":
                        Console.Clear();
                        foreach (Cars c in car)
                        {
                            Console.WriteLine($"{c.ID} {c.Price} {c.Color} {c.Model} {c.Make}");
                        }
                        Console.ReadLine();
                        break;
                    case "N":
                        Console.Clear();
                        string color, model, make;
                        int id = car.Count;
                        int price;

                        Console.WriteLine("Enter Car Color:");
                        color = Console.ReadLine();
                        Console.WriteLine("Enter Car Model:");
                        model = Console.ReadLine();
                        Console.WriteLine("Enter Car Make:");
                        make = Console.ReadLine();
                        Console.WriteLine("Enter Car Price:");
                        price = Int32.Parse(Console.ReadLine());

                        car.Add(new Cars{ ID = id, Color = color, Model = model, Make = make });

                        Console.WriteLine($"\n {car[id].Model} added to list, returning to menu.");
                        break;

                    case "E":
                        Console.Clear();
                        Console.WriteLine("Enter car ID to edit:");
                        string n = Console.ReadLine();
                        if (n.ToUpper() == "Q")
                        {

                        }
                           
                        
                        break;

                    case "D":
                        Console.Clear();
                        break;

                    case "X":
                        Console.Clear();
                        break;

                }
            }
        }
    }

    public class Cars //ID, Color, Model, Make och Price i domänmodellen
    {
        public int ID { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
    }
}
