/*
 * *Class name: Banking App
 * Version 1
 * Author: Toby Johnston
 */

using System.Xml.Serialization;

void BuildBankingApp()
{
    int choice;
    double depositAmmount;
    double accountBalance = 1000;

    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1 - Deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option (1-2)");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1 || choice == 2)
    {
        if (choice == 1)
        {
            Console.WriteLine("You have chosen to deposit or withdraw funds");
            Console.WriteLine("How much do you want to deposit?");
            Console.WriteLine("Please enter the ammount including pence using a decimal point");

            depositAmmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your original account balance was {accountBalance}");

            accountBalance += depositAmmount;
            Console.WriteLine($"Your new account balacne is {accountBalance}");
        }
        else
        {
            Console.WriteLine("You have chosen to view current account information");
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }
    }
    else
    {
        Console.WriteLine("Invalid choice, please choose 1 or 2");
    }
}
BuildBankingApp();
