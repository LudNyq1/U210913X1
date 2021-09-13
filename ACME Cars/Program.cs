using System;
using System.Collections.Generic;

namespace ACME_Cars
{
    class Program //GLÖM EJ ATT COMMITA
    {
        static void Main(string[] args)
        {
            List<Cars> car = new List<Cars>(); //Detta ska du träna på att skriva! Skapar objektet

            car.Add(new Cars { Price = 3999, Color = "Silver", Make = "Volvo", Model = "744-GL" });
            car.Add(new Cars { Price = 499, Color = "Blue", Make = "Opel", Model = "Astra" });
            car.Add(new Cars { Price = 1599, Color = "Black", Make = "Audi", Model = "RS-8" });
            car.Add(new Cars { Price = 299, Color = "Yellow", Make = "Volksw.", Model = "Arteon" });

        start: //Istället för While loop används goto statement
            {
                Console.Clear();
                Console.WriteLine("Welcome to ACME Cars© Industry Program EST.1999");
                Console.WriteLine("===========================================================");
                Console.WriteLine("S\tShow all cars\nN\tAdd car\nE\tEdit car\nD\tRemove car\nX\tExit program\n");

                string choice = Console.ReadLine();
                switch (choice.ToUpper()) //Switch case för Menyns funktioner
                {
                    case "S":
                        Console.Clear();
                        Console.WriteLine($"Car-ID\t\tMake\t\tModel\t\tColor\t\tPrice");
                        Console.WriteLine("=======================================================================");
                        foreach (Cars k in car) //Skriver ut lista på alla bilar samt dess egenskaper
                        {
                            Console.WriteLine($"ID:{car.IndexOf(k)}\t\t{k.Make}\t\t{k.Model}\t\t{k.Color}\t\t{k.Price}$\n");
                        }
                        Console.ReadLine();
                        goto start;
                    case "N":
                        Console.Clear();
                        string color, model, make;
                        int price;

                        Console.WriteLine("Enter Car Color:");
                        color = Console.ReadLine();
                        Console.WriteLine("Enter Car Make:");
                        make = Console.ReadLine();
                        Console.WriteLine("Enter Car Model:");
                        model = Console.ReadLine();
                        Console.WriteLine("Enter Car Price:");
                        price = Int32.Parse(Console.ReadLine());

                        car.Add(new Cars { Color = color, Model = model, Make = make, Price = price }); //Skapar en ny bil med angivna egenskaper

                        Console.WriteLine();
                        Console.WriteLine($"\n {car[(car.Count) - 1].Model} added to list, returning to menu.");
                        Console.ReadLine();
                        goto start;

                    case "E":
                        Console.Clear();
                        Console.WriteLine($"Car-ID\t\tMake\t\tModel\t\tColor\t\tPrice");
                        Console.WriteLine("=======================================================================");
                        foreach (Cars l in car)
                        {
                            Console.WriteLine($"ID:{car.IndexOf(l)}\t\t{l.Make}\t\t{l.Model}\t\t{l.Color}\t\t{l.Price}$\n");
                        }

                        Console.WriteLine("Enter car ID to edit:");
                        int pos = Int32.Parse(Console.ReadLine());
                        if (pos > car.Count - 1)
                        {
                            Console.WriteLine("==================================");
                            Console.WriteLine($"ERROR: OUT OF BOUNDS \"{pos}\" (Press Enter)");
                            Console.WriteLine("==================================");
                            Console.ReadLine();
                            goto start;
                        }

                    redo: //Man kan fortsätta redigera efter man har gjort en redigering, ty kan man redigera flera gånger som så behövs.
                        Console.Clear();
                        Console.WriteLine($"ID:{pos}\t\t{car[pos].Make}\t\t{car[pos].Model}\t\t{car[pos].Color}\t\t{car[pos].Price}$\n");
                        Console.WriteLine("(Enter E to return to menu)\n1. Price\n2. Color\n3. Model\n4. Make");
                        string c = Console.ReadLine();
                        switch (c.ToUpper())
                        {
                            case "1":
                                Console.WriteLine("Enter the new price:");
                                car[pos].Price = Int32.Parse(Console.ReadLine());
                                goto redo;
                            case "2":
                                Console.WriteLine("Enter the new color:");
                                car[pos].Color = Console.ReadLine();
                                goto redo;
                            case "3":
                                Console.WriteLine("Enter the new model:");
                                car[pos].Model = Console.ReadLine();
                                goto redo;
                            case "4":
                                Console.WriteLine("Enter the new make:");
                                car[pos].Make = Console.ReadLine(); ;
                                goto redo;
                            case "E":
                                goto start;
                            default:
                                Console.Clear();
                                Console.WriteLine("==================================");
                                Console.WriteLine($"ERROR: FAULTY INPUT \"{c}\" (Press Enter)");
                                Console.WriteLine("==================================");
                                Console.ReadLine();
                                goto redo;

                        }

                    case "D": //Tar bort angiven bil
                        Console.Clear();
                        Console.WriteLine($"Car-ID\t\tMake\t\tModel\t\tColor\t\tPrice");
                        Console.WriteLine("=======================================================================");
                        foreach (Cars j in car)
                        {
                            Console.WriteLine($"ID:{car.IndexOf(j)}\t\t{j.Make}\t\t{j.Model}\t\t{j.Color}\t\t{j.Price}$\n");
                        }
                        Console.WriteLine("Enter Car ID to remove:");
                        int i = Int32.Parse(Console.ReadLine());
                        if (i > car.Count - 1) //Om värdet anget inte finns så blir det error
                        {
                            Console.WriteLine("==================================");
                            Console.WriteLine($"ERROR: OUT OF BOUNDS \"{i}\" (Press Enter)");
                            Console.WriteLine("==================================");
                            Console.ReadLine();
                            goto start;
                        }
                        string temp = $"{car[i].Make} {car[i].Model}";
                        car.RemoveAt(i);
                        Console.WriteLine($"Removed {temp}"); //Skriver ut vilken bil som togs bort med hjälp temp variabel
                        Console.ReadLine();
                        goto start;

                    case "X":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("==================================");
                        Console.WriteLine($"ERROR: FAULTY INPUT \"{choice}\" (Press Enter)");
                        Console.WriteLine("==================================");
                        Console.ReadLine();
                        goto start;


                }
            }
        }
    }

    public class Cars //ID, Color, Model, Make och Price i domänmodellen
    {
        public int Price { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
    }
}
