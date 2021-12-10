using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_drinkDispensor
{
    class Program
    {
        public static int amount;
        public class Drinks 
        {
            public String name;
            public int price;
            public bool order=false;
        }

        static void Main(string[] args)
        {

            Drinks drnk_apple = new Drinks();
            drnk_apple.name = "Apple";
            drnk_apple.price = 150;
            Drinks drnk_orange = new Drinks();
            drnk_orange.name = "Orange";
            drnk_orange.price = 100;
            Drinks drnk_grapes = new Drinks();
            drnk_grapes.name = "Grapes";
            drnk_grapes.price = 120;

            int total = 0;
            Console.WriteLine($"Welcome to Drik Dispensor\nChoose your drink\n1 - {drnk_apple.name}\t2 - {drnk_orange.name}\t3 - {drnk_grapes.name}");
            String input = Console.ReadLine();

                    if (input.Contains("1"))
                    {
                        drnk_apple.order = true;
                        total += drnk_apple.price;
                    }
                    if (input.Contains("2"))
                    {
                        drnk_orange.order = true;
                        total += drnk_orange.price;
                    }
                    if (input.Contains("3"))
                    {
                        drnk_grapes.order = true;
                        total += drnk_grapes.price;
                    }

            Console.WriteLine("Your orders are\n"+ (drnk_apple.order ? drnk_apple.name:null) +" "+ (drnk_orange.order ? drnk_orange.name : null) + " " + (drnk_grapes.order ? drnk_grapes.name : null) + $"\nand the total bill is Rs{total}");
            

            do
            {
                Console.WriteLine("How much do you want to pay (Enter a valid amount)");
                amount = int.Parse(Console.ReadLine());
            }
            while (amount < total);

            int balance = amount - total;
            Console.WriteLine($"You paid {amount} balance is {balance}");
            Console.WriteLine("Thanks for buying");
            Console.ReadLine();
        }
    }
}
