using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTwo
{
    internal class Program
    {




        static void AddCreditCard()
        {
            var cc = new CreditCard();

            Console.WriteLine("Enter Card Holder Name:");
            cc.CardHolderName = Console.ReadLine();

            Console.WriteLine("Enter Card Number:");
            cc.CardNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter Expiry Month:");
            cc.ExpiryMonth = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter Expiry Year:");
            cc.ExpiryYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter CVC:");
            cc.Cvc = int.Parse(Console.ReadLine());

            creditCards.Add(cc);
            Console.WriteLine("Credit Card added successfully!");
        }
        static List<CreditCard> creditCards = new List<CreditCard>();
        static void Main(string[] args)
        {
            var cc = new CreditCard();
            int choice;
            while (true)
            {


                Console.WriteLine("Enter the card Name");
                cc.CardHolderName = Console.ReadLine();

                Console.WriteLine("Enter the card number");
                cc.CardNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the expiry month");
                cc.ExpiryMonth = byte.Parse(Console.ReadLine());

                Console.WriteLine("Enter the expiry year");
                cc.ExpiryYear = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter CVC");
                cc.Cvc = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Choice");
                choice = int.Parse(Console.ReadLine());

                Console.WriteLine("\n1. Add Credit Card");
                Console.WriteLine("2. Update Credit Card");
                Console.WriteLine("3. Delete Credit Card");
                Console.WriteLine("4. Search Credit Card by Number");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddCreditCard();
                        break;
                    case 2:
                        return;
                        //    UpdateCreditCard();
                        //    break;
                        //case 3:
                        //    DeleteCreditCard();
                        //    break;
                        //case 4:
                        //    SearchByCardNumber();
                        //    break;
                        //case 5:
                        //    Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }




            }






            Console.WriteLine(cc);

            Console.ReadKey();
        }
    }
}