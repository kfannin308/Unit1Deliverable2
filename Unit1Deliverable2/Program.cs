using System;

namespace Unit1Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int waters = 0;
            int coffees = 0;
            double totalBill = 0;
            double drinkCharge = 0;
            double totalDrinkBill = 0;

            Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! \r\n" +
                              "We charge extra for drinks. Parties of 6 or lower please. \r\n \r\n" +
                              "How many people are in your group? ");
            int sizeOfParty = int.Parse(Console.ReadLine());

            if (sizeOfParty <= 6)
            {
                Console.WriteLine("A table for " + sizeOfParty + "! Please follow me to your seat.\r\n" +
                                  "What would you like to drink? We have coffee for $2.00 and water is free. \r\n \r\n");
                for (i = 0; i < sizeOfParty; i++)
                {
                    int person = i + 1;
                    Console.WriteLine("Alright person number " + person + " water or coffee?");
                    string drink = Console.ReadLine();
                    if (drink != "coffee" && drink != "water")
                    {
                        Console.WriteLine("We don't have that drink. No drink for you. \r\n");
                    }
                    else
                    {
                        if (drink == "coffee")
                        {
                            coffees++;
                        }
                        else
                        {
                            waters++;
                        };
                        drinkCharge = CalcDrinkCharge(drink);
                        totalDrinkBill += drinkCharge;
                        Console.WriteLine("You want a " + drink + "\r\n");
                    }

                }
                totalBill = CalcTotalBill(sizeOfParty, totalDrinkBill);
                Console.WriteLine("\r\n \r\nHere's Your Total Bill! Total Price: $" + totalBill + "\r\n \r\n" +
                                  "Order Details: \r\n");
                Console.WriteLine("Buffets: " + sizeOfParty + " X $9.99 = $" + sizeOfParty * 9.99);
                Console.WriteLine("Coffees: " + coffees + " X $2.00 = $" + totalDrinkBill.ToString("0.00"));
                Console.WriteLine("Waters:  " + waters + "         = $0.00");
                Console.WriteLine("Total:               $" + totalBill);

            }
            else
            {
                Console.WriteLine("Sorry, we can only seat parties up to 6. Have a nice day!");
            }


        }
        public static double CalcDrinkCharge(string drinkOrdered)
        {
            double price;
            if (drinkOrdered == "coffee")
            {
                price = 2.00;
            }
            else { price = 0; }
            return price;
        }

        public static double CalcTotalBill(int party, double drinkTotal)
        {
            double buffetTotal = party * 9.99;
            double totalBill = buffetTotal + drinkTotal;
            return totalBill;
        }
    }
}
