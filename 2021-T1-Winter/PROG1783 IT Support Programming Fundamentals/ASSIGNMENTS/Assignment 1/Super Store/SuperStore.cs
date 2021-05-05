﻿using System;
/*
 * AUTHOR:  Duke Do
 * ID NUM:  8632240
 * DATE:    01/03/2021
 * COURSE:  PROG1783: IT Support Programming Fundamentals
 * PROJECT: Assignment 1: Superstore
 * DESCRIPTION:
 * For the store, you will offer 2 items of your choice for sale.
 * 
 * For each item:
 * - Have two versions
 * - Allow the user to choose which version they would like to purchase
 * - Have a colour choice:
 * 	+ Provide a list of available colours
 * 	+ Allow the user to select a colour
 * - Have a price
 * - Price visible to the user before ordering
 * - Provide discounts:
 * 	+ 7% for students
 * 	+ 7% for senior citizens
 * 	+ 30% for 5 or more items
 * - Ask the user to confirm if student, or senior
 * - Discounts cannot stack
 * - Only 1 discount per item:
 * 	+ E.g. A senior citizen purchasing 10 shirts, 1 pants:
 * 		> 10 shirts= 30% quantity discount; 1 pants= 7% senior discount
 * - Display sub-total
 * - Apply 13% sale tax
 * - Display grand total
 * - Repeat prompts until a valid choice is given
 * 	+ Include brief error message
 * - Print summary menu, include:
 * 	+ Name
 * 	+ Type
 * 	+ Details
 * 	+ Price
 * 	+ Total cost
 * - All text columns must align
 * - Savings row only visible if discount was given
 * 
 * Item Type      Details       Cost per   Qnty   Discount    Total
 * ------------   -----------   --------   ----   --------   ------
 * Hockey Stick   Adult, Blue      $7.99      5        30%   $27.97
 * 
 *                                            Total Savings: $11.96
 * 
 *                                                Sub Total: $27.97
 *                                                      Tax:  $3.64
 *                                                    Total: $31.60
 */

namespace Super_Store
{
    class SuperStore
    {
        static void Break()
        {
            Console.WriteLine();
            System.Threading.Thread.Sleep(500);
        }

        static void Main(string[] args)
        {
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
            } else if (item1[0] == "Hockey Sticks")
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
            } else if (item1[0] == "Knee Pads")
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
            } else
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