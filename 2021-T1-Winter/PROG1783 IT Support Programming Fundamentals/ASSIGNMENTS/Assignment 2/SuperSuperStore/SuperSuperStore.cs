using System;

/*
 * AUTHOR:  Duke Do
 * ID NUM:  8632240
 * DATE:    05/04/2021
 * COURSE:  PROG1783: IT Support Programming Fundamentals
 * PROJECT:  Assignment 2: Improved Superstore
 * DESCRIPTION:
 * FIRST TASK:
 * Review your code from the first assignment, correct any issues or missed items
 * 
 * SECOND TASK:
 * Your program should meet the same specifications as in Assignment 1, with the following additions:
 *  1) The available products should be stored in an array of structures
 *      + Up to 6 items and their price
 *  - Pick another 4 items, including sub-type and colour
 *  
 *  2) Limit the customer to a max quantity of 10 per item
 *  
 *  3) If the customer places an order for the same type of item again, have it replace the previous order
 *  
 *  4) Add error checking to resolve/prevent common errors, including program crashes/exceptions
 *  For example:
 *      + Inputs with leading or trailing blank spaces whould work (ie, " 1 " == "1")
 *      + Handle crash/exception for trying int.Parse("Fred")
 *      + Other invalid inputs should be handled without crash
 * 
 *  5) Use an array of structures to store the items available, and another separate array of structures to record shopping cart
 */

namespace SuperSuperStore
{
    class SuperSuperStore
    {
        // Break() method to slow program and format text for readability
        static void Break()
        {
            Console.Write("\n");
            System.Threading.Thread.Sleep(500);
        }

        // Inventory structure to label item details
        struct Inventory
        {
            public string Name;
            public string Type;
            public string Colour;
            public double Price;
        }

        static void DisplayInv(Inventory[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("{0}) {1,-12}   ${2}", i + 1, x[i].Name, x[i].Price);
            }
        }

        static void Main(string[] args)
        {
            // Message to welcome user to the program
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine(" WELCOME TO THE ATLAS SUPERSUPERSTORE!\n" +
                " A new and improved shopping experience!");
            Console.WriteLine("|--------------------------------------------------|");

            // Initialize variables
            double perDiscount = 0.93;
            double quanDiscount = 0.7;
            // double tax = 0.87;

            // Initialize inventory array
            Inventory[] Ware = new Inventory[6];

            // Initialize cart array
            Inventory cart = new Inventory();

            // Boots
            Ware[0].Name = "Boots";
            Ware[0].Type = "1) 7 US\n2) 7.5 US\n3) 8 US";
            Ware[0].Colour = "1) Black\n2) Tan";
            Ware[0].Price = 87.99;

            // Goggles
            Ware[1].Name = "Googles";
            Ware[1].Type = "One-Size";
            Ware[1].Colour = "1) Black Tint\n2) Blue Tint\n3) Orange Tint";
            Ware[1].Price = 9.99;

            // Helmet
            Ware[2].Name = "Helmet";
            Ware[2].Type = "1) Adult\n2) Youth";
            Ware[2].Colour = "1) Black\n2) Grey";
            Ware[2].Price = 24.95;

            // Hockey Stick
            Ware[3].Name = "Hockey Stick";
            Ware[3].Type = "1) Adult\n2) Youth";
            Ware[3].Colour = "1) Black\n2) Blue\n3) Yellow";
            Ware[3].Price = 7.99;

            // Knee Pads
            Ware[4].Name = "Knee Pad";
            Ware[4].Type = "Adult, Youth";
            Ware[4].Colour = "Black, Green, Silver";
            Ware[4].Price = 19.95;

            // Jersey
            Ware[5].Name = "Jersey";
            Ware[5].Type = "1) Small\n2) Medium\n3) Large";
            Ware[5].Colour = "1) Black\n2) Green\n3) White";
            Ware[5].Price = 12.99;

            Break();

            // OUTPUT: Display inventory
            DisplayInv(Ware);

            Break();



            // OLD
            // Variables
            int quan1, quan2, i = 0;
            double cost1 = 0, price1, cost2 = 0, price2, discount1 = 1, discount2 = 1;
            String input, savings, sub, tax, total;

            // Items Array
            String[] item1 = new string[6];
            String[] item2 = new string[6];

            // Welcome Message
            Console.WriteLine(" Welcome to the Atlas Store!");

            Break();

            // Inventory Information
            Console.WriteLine("This location currently has the following items in stock:\n" +
                "   1 - Helmet        $24.95\n" +
                "   2 - Hockey Sticks  $7.99\n" +
                "   3 - Knee Pads     $19.95$");

            Break();

            // ITEM 1
            // INPUT: Item
            Console.WriteLine("What is the 1st item you want to purchase?");
            input = Console.ReadLine();
            do
            {
                if (input == "1")
                {
                    item1[0] = "Helmet";
                    item1[2] = "$24.95";
                    cost1 = 24.95;
                    i++;
                }
                else if (input == "2")
                {
                    item1[0] = "Hockey Sticks";
                    item1[2] = "$7.99";
                    cost1 = 7.99;
                    i++;
                }
                else if (input == "3")
                {
                    item1[0] = "Knee Pads";
                    item1[2] = "$19.95";
                    cost1 = 19.95;
                    i++;
                }
                else
                {
                    Break();

                    Console.WriteLine("Please choose one of the available options by number.");
                    input = Console.ReadLine();
                    i = 0;
                }
            } while (i == 0);

            Break();

            // INPUT: Type
            Console.WriteLine("Please pick an available option:\n" +
                "   1 - Adult\n" +
                "   2 - Youth");
            input = Console.ReadLine();
            do
            {
                if (input == "1")
                {
                    item1[1] = "Adult";
                    i++;
                }
                else if (input == "2")
                {
                    item1[1] = "Youth";
                    i++;
                }
                else
                {
                    Break();

                    Console.WriteLine("Please choose one of the available options by number.");
                    input = Console.ReadLine();
                    i = 0;
                }
            } while (i == 0);

            Break();

            // INPUT: Colour
            if (item1[0] == "Helmet")
            {
                Console.WriteLine("Please pick an available colour:\n" +
                    "   1 - Black\n" +
                    "   2 - Green");
                input = Console.ReadLine();
                do
                {
                    if (input == "1")
                    {
                        item1[1] = item1[1] + ", Black";
                        i++;
                    }
                    else if (input == "2")
                    {
                        item1[1] = item1[1] + ", Green";
                        i++;
                    }
                    else
                    {
                        Break();

                        Console.WriteLine("Please choose one of the available options by number.");
                        input = Console.ReadLine();
                        i = 0;
                    }
                } while (i == 0);
            }
            else if (item1[0] == "Hockey Sticks")
            {
                Console.WriteLine("Please pick an available colour:\n" +
                    "   1 - Black\n" +
                    "   2 - Blue\n" +
                    "   3 - Yellow");
                input = Console.ReadLine();
                do
                {
                    if (input == "1")
                    {
                        item1[1] = item1[1] + ", Black";
                        i++;
                    }
                    else if (input == "2")
                    {
                        item1[1] = item1[1] + ", Blue";
                        i++;
                    }
                    else if (input == "3")
                    {
                        item1[1] = item1[1] + ", Yellow";
                        i++;
                    }
                    else
                    {
                        Break();

                        Console.WriteLine("Please choose one of the available options by number.");
                        input = Console.ReadLine();
                        i = 0;
                    }
                } while (i == 0);
            }
            else if (item1[0] == "Knee Pads")
            {
                Console.WriteLine("Please pick an available colour:\n" +
                    "   1 - Black\n" +
                    "   2 - Grey");
                input = Console.ReadLine();
                do
                {
                    if (input == "1")
                    {
                        item1[1] = item1[1] + ", Black";
                        i++;
                    }
                    else if (input == "2")
                    {
                        item1[1] = item1[1] + ", Grey";
                        i++;
                    }
                    else
                    {
                        Break();

                        Console.WriteLine("Please choose one of the available options by number.");
                        input = Console.ReadLine();
                        i = 0;
                    }
                } while (i == 0);
            }

            Break();

            // INPUT: Quantity
            Console.WriteLine("How many {0} would you like to purchase?", item1[0].ToLower());
            item1[3] = Console.ReadLine();

            // INPUT: Discounts
            quan1 = int.Parse(item1[3]);
            if (quan1 >= 5)
            {
                discount1 = 0.70;
                item1[4] = "30%";
            }
            else
            {
                Break();

                Console.WriteLine("Are you a student or senior? Y / N");
                input = Console.ReadLine().ToLower();
                do
                {
                    if (input == "y")
                    {
                        discount1 = 0.93;
                        item1[4] = "7%";
                        i++;
                    }
                    else if (input == "n")
                    {
                        i++;
                    }
                    else
                    {
                        Break();

                        Console.WriteLine("Please choose one available options by letter.");
                        input = Console.ReadLine().ToLower();
                    }
                } while (i == 0);
            }

            Break();

            // ITEM 2
            // INPUT: Item
            Console.WriteLine("What is the 2nd item you want to purchase?\n" +
                "   1 - Helmet        $24.95\n" +
                "   2 - Hockey Sticks  $7.99\n" +
                "   3 - Knee Pads     $19.95$");
            input = Console.ReadLine();
            do
            {
                if (input == "1")
                {
                    item2[0] = "Helmet";
                    item2[2] = "$24.95";
                    cost2 = 24.95;
                    i++;
                }
                else if (input == "2")
                {
                    item2[0] = "Hockey Sticks";
                    item2[2] = "$7.99";
                    cost2 = 7.99;
                    i++;
                }
                else if (input == "3")
                {
                    item2[0] = "Knee Pads";
                    item2[2] = "$19.95";
                    cost2 = 19.95;
                    i++;
                }
                else
                {
                    Break();

                    Console.WriteLine("Please choose one of the available options by number.");
                    input = Console.ReadLine();
                    i = 0;
                }
            } while (i == 0);

            Break();

            // INPUT: Type
            Console.WriteLine("Please pick an available option:\n" +
                "   1 - Adult\n" +
                "   2 - Youth");
            input = Console.ReadLine();
            do
            {
                if (input == "1")
                {
                    item2[1] = "Adult";
                    i++;
                }
                else if (input == "2")
                {
                    item2[1] = "Youth";
                    i++;
                }
                else
                {
                    Break();

                    Console.WriteLine("Please choose one of the available options by number.");
                    input = Console.ReadLine();
                    i = 0;
                }
            } while (i == 0);

            Break();

            // INPUT: Colour
            if (item2[0] == "Helmet")
            {
                Console.WriteLine("Please pick an available colour:\n" +
                    "   1 - Black\n" +
                    "   2 - Green");
                input = Console.ReadLine();
                do
                {
                    if (input == "1")
                    {
                        item2[1] = item2[1] + ", Black";
                        i++;
                    }
                    else if (input == "2")
                    {
                        item2[1] = item2[1] + ", Green";
                        i++;
                    }
                    else
                    {
                        Break();

                        Console.WriteLine("Please choose one of the available options by number.");
                        input = Console.ReadLine();
                        i = 0;
                    }
                } while (i == 0);
            }
            else if (item2[0] == "Hockey Sticks")
            {
                Console.WriteLine("Please pick an available colour:\n" +
                    "   1 - Black\n" +
                    "   2 - Blue\n" +
                    "   3 - Yellow");
                input = Console.ReadLine();
                do
                {
                    if (input == "1")
                    {
                        item2[1] = item2[1] + ", Black";
                        i++;
                    }
                    else if (input == "2")
                    {
                        item2[1] = item2[1] + ", Blue";
                        i++;
                    }
                    else if (input == "3")
                    {
                        item2[1] = item2[1] + ", Yellow";
                        i++;
                    }
                    else
                    {
                        Break();

                        Console.WriteLine("Please choose one of the available options by number.");
                        input = Console.ReadLine();
                        i = 0;
                    }
                } while (i == 0);
            }
            else if (item2[0] == "Knee Pads")
            {
                Console.WriteLine("Please pick an available colour:\n" +
                    "   1 - Black\n" +
                    "   2 - Grey");
                input = Console.ReadLine();
                do
                {
                    if (input == "1")
                    {
                        item2[1] = item2[1] + ", Black";
                        i++;
                    }
                    else if (input == "2")
                    {
                        item2[1] = item2[1] + ", Grey";
                        i++;
                    }
                    else
                    {
                        Break();

                        Console.WriteLine("Please choose one of the available options by number.");
                        input = Console.ReadLine();
                        i = 0;
                    }
                } while (i == 0);
            }

            Break();

            // INPUT: Quantity
            Console.WriteLine("How many {0} would you like to purchase?", item2[0].ToLower());
            item2[3] = Console.ReadLine();

            Break();

            // INPUT: Discounts
            quan2 = int.Parse(item2[3]);
            if (quan2 >= 5)
            {
                discount2 = 0.70;
                item2[4] = "30%";
            }
            else
            {
                Console.WriteLine("Are you a student or senior? Y / N");
                input = Console.ReadLine().ToLower();
                do
                {
                    if (input == "y")
                    {
                        discount2 = 0.93;
                        item2[4] = "7%";
                        i++;
                    }
                    else if (input == "n")
                    {
                        i++;
                    }
                    else
                    {
                        Break();

                        Console.WriteLine("Please choose one available options by letter.");
                        input = Console.ReadLine().ToLower();
                    }
                } while (i == 0);
            }

            Break();

            // CALCULATIONS: Price
            price1 = cost1 * quan1 * discount1;
            item1[5] = "$" + price1.ToString("0.##");
            price2 = cost2 * quan2 * discount2;
            item2[5] = "$" + price2.ToString("0.##");

            // CALCULATIONS: Savings
            savings = (price1 * (1 - discount1) + price2 * (1 - discount2)).ToString("0.##");

            // CALCULATIONS: Sub-Total
            sub = "$" + (price1 + price2).ToString("0.##");

            // CALCULATIONS: Tax
            tax = "$" + ((price1 + price2) * 0.13).ToString("0.##");

            // CALCULATIONS Grand Total
            total = "$" + ((price1 + price2) * 0.13 + price1 + price2).ToString("0.##");

            // OUTPUT
            Console.WriteLine("Item Type       Details         Cost per   Qnty   Discount     Total");
            Console.WriteLine("-------------   -------------   --------   ----   --------   -------");
            Console.WriteLine("{0, -13}   {1, -13}   {2, 8}   {3, 4}   {4, 8}   {5, 7}", item1[0], item1[1], item1[2], item1[3], item1[4], item1[5]);
            Console.WriteLine("{0, -13}   {1, -13}   {2, 8}   {3, 4}   {4, 8}   {5, 7}", item2[0], item2[1], item2[2], item2[3], item2[4], item2[5]);
            Console.WriteLine();
            if (discount1 != 1 || discount2 != 1)
            {
                Console.WriteLine("                                               Total Savings: {0, 7}\n", savings);
            }
            Console.WriteLine("                                                   Sub-Total: {0, 7}", sub);
            Console.WriteLine("                                                         Tax: {0, 7}", tax);
            Console.WriteLine("                                                 Grand Total: {0, 7}", total);
        }
    }
}