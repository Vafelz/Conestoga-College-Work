using System;
using System.Collections.Generic;
/*
 * NAME:    Duc Do
 * ID:      8632240
 * DATE:    26/04/2021
 * PROGRAM: Gas Station & Price List
 */

namespace Final_Exam
{
    // GStation structure to contain all info for gas station
    struct Station
    {
        public string Name;
        public string Add;
        public string City;
        public double Price;
    }

    class Program
    {
        // Break() method to add spacing and ease output cleanliness
        static void Break()
        {
            Console.Write("\n");
            System.Threading.Thread.Sleep(500);
        }

        // Sleep() method to slow program to simulate 'thinking'
        static void Sleep()
        {
            System.Threading.Thread.Sleep(500);
        }

        // SleepBreak() method to simulate 'thinking' and add spacing
        static void SleepBreak()
        {
            Console.Write("\n");
            System.Threading.Thread.Sleep(500);
        }

        public static DateTime Today
        {
            get;
        }

        static void Welcome()
        {
            String p = "GAS STATION & PRICE LIST", n = "Duke Do";
            var d = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine("|---------------------------------------------------------------------------------|");
            Console.WriteLine(" {0,-30:0}{1,20:0}{2,30:0}", p, d, n);
            Console.WriteLine("|---------------------------------------------------------------------------------|");
        }

        static void PrintAll(Station[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("{0,20}{1,30}{2,20}${3,5}", list[i].Name, list[i].Add, list[i].City, list[i].Price);
            }
        }

        static void PrintLow(Station[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("{0,20}{1,30}{2,20}${3,5}", list[i].Name, list[i].Add, list[i].City, list[i].Price);
            }
        }

        static double PrintAvg(Station[] list)
        {
            double t = 0;

            for (int i = 0; i < list.Length; i++)
            {
                t =+ list[i].Price;
            }

            t = t / 5;

            return t;
        }

        static void Exit()
        {
            Console.WriteLine(" {0,-30:}{1,20:}", "2240", "Ferrari SF90");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Variables
            int u;
            double j;

            // gasList Array for 5 stations
            Station[] gasList = new Station[3];

            Welcome();

            SleepBreak();

            Console.WriteLine(" Please enter information for gas stations below. (Up to 5 stations)");

            Sleep();

            // User Input of Gas Stations
            for (int i = 0; i < gasList.Length; i++)
            {
                Console.WriteLine("Gas station name:");
                gasList[i].Name = Console.ReadLine();

                Console.WriteLine("Gas station street address:");
                gasList[i].Add = Console.ReadLine();

                Console.WriteLine("Gas station city");
                gasList[i].City = Console.ReadLine();

                Console.WriteLine("Regular gas price");
                gasList[i].Price = double.Parse(Console.ReadLine());

                if (i < 4)
                {
                    Break();
                }
                else
                {
                    SleepBreak();
                }
            }

            do
            {
                Console.WriteLine("1) Print all gas stations and price");
                Console.WriteLine("2) Print gas station with the lowest price");
                Console.WriteLine("3) Print average gas price");
                Console.WriteLine("4) Exit");

                u = int.Parse(Console.ReadLine());

                switch (u)
                {
                    case 1:
                        PrintAll(gasList);
                        Break();
                        break;
                    case 2:
                        PrintLow(gasList);
                        Break();
                        break;
                    case 3:
                        j = PrintAvg(gasList);
                        Console.WriteLine("The average gas price: ${0,-5}", j);
                        Break();
                        break;
                    case 4:
                        break;
                }
            } while (u < 4);

            Break();

            Console.WriteLine("Exiting...");

            SleepBreak();

            Exit();
        }
    }
}