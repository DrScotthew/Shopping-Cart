//12-3-21
//Shopping Cart
//This program allows the user to input the price(s) of any item(s) they have purchased and calculates the final price after tax.
//It also keeps track of how much money the user has spent and if their amount reaches $100, a message is shown which says they have
//received free shipping on their item(s).


using System;

class ShoppingCart
{

    public static double Price {get; set;}
    public static double ShippingCharges {get; set;}
    public static double GrandTotal {get; set;}
    public static double SalesTax {get; set;}


    public static void Main(string[] args)
    {
        string choice = null;
        int counter = 0;
        Price = 0.00;
        //The above code sets the starting parameters for the number of items the user has purchased and the price.  This allows for
        //the int counter to be increased as the user inputs items and for the price to increase as well.

    input:
        do
        {
            Console.WriteLine("Enter the price of an item");
            string num = Console.ReadLine();
            Price = Price + Convert.ToDouble(num);

            Console.WriteLine("Do you want to enter the price of another item?");
            choice = Console.ReadLine();
            counter++;

        } while (choice.Equals("yes") || (choice.Equals("Yes") || (choice.Equals("Y") || (choice.Equals("y")))));
        //This allows the user to enter different forms of 'yes' to the question of whether or not they would like to add more items.
        //This is important in every program since it takes into consideration the possible variations of how someone would respond 'yes.'

        if (Price <= 90 && Price < 100)    //<--- This triggers the following code when the user's total accumulated price is $90 or more, but less than $100.
        {
            double diff = 100.0 - Price;
            Console.WriteLine("You are $" + diff.ToString() + " away from getting free shipping on your order!  Keep shopping!");
            //This will allow the user to clearly see how far away they are from getting free shipping.
            Console.WriteLine();
            goto input;
        }
        else if (Price >= 100)
        {

            Console.WriteLine();
            Console.WriteLine("Congratulations!!!  You have reached $100 and are eligible for free shipping on your order!");
            Console.WriteLine();
        }
        if (counter < 3  && Price < 100)    //If the price is still under $100, then the shipping charges will still be applied on the order.
        {
            ShippingCharges = 3.50;
            
        }
        else if (counter >= 3 && counter <= 6 && Price < 100)
        {
            ShippingCharges = 5.00;
        }
        else if (counter >= 7 && counter <= 10 && Price < 100)
        {
            ShippingCharges = 7.00;
        }
        else if (counter >= 11 && counter <= 15 && Price < 100)
        {
            ShippingCharges = 9.00;
        }
        else if (counter > 15 && Price < 100)
        {
            ShippingCharges = 10.00;
        }

        SalesTax = (7.75 * Price) / 100.0;  //A sales tax of 7.75% will be applied on the price(s) of the item(s).
        GrandTotal = SalesTax + Price;      //Then, the grand total will be calculated after the sales tax has been applied.



        //The following code shows the "receipt of the order" so to speak.  It's clear, concise, and allows the user to see everything they
        //entered/purchased

        Console.WriteLine("This is your receipt.  Keep this handy in case you need to return any items");
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("Total purchase charge is $" + Price.ToString());
        Console.WriteLine();

        Console.WriteLine("Number of items purchased is " + counter.ToString());
        Console.WriteLine();

        Console.WriteLine("Total Sales Tax amount is $" + SalesTax.ToString("#.##"));   //<--- The '#.##' allows for the double
                                                                                        //to still have the same format as a normal
                                                                                        //dollar amount.  Without this, the program
                                                                                        //would print a number that went to just
                                                                                        //one decimal place.
        Console.WriteLine();

        Console.WriteLine("Shipping Charge is $" + ShippingCharges.ToString("#.##"));
        Console.WriteLine();

        Console.WriteLine("Grand Total amount is is $" + GrandTotal.ToString("#.##"));
        Console.WriteLine("----------------------------------------------------------------------------");
    }
}
