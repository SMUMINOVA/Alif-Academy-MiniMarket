using System;
namespace lesson3
{
    public class Programm
    {
        static void Main()
        {

            decimal userBalance = 300m;
            string basket = "";
            string erroBalanceMessage = "You haven't enough money";

        start: //Метка "start"

            System.Console.WriteLine($"Your balance - {userBalance}");

            if (userBalance <= 0)
            {
                System.Console.WriteLine(erroBalanceMessage);
                goto End;
            };

            System.Console.WriteLine("" +
            "1 Cola - 10 somoni\n" +
            "2 Snikers - 7 somoni\n" +
            "3 Mars - 9 somoni\n" +
            "4 M&Ms - 4 somoni\n" +
            "5 Chips - 14 somoni\n" +
            "6 Exit\n" +
            "Your choice (1-6):");

            int choice = int.Parse(Console.ReadLine());

            // goto start; //идти к метке "start"
            switch (choice)
            {
                case 1:
                    {
                        if (userBalance - 10 >= 0)
                        {
                            basket += "Cola,";
                            userBalance -= 10;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Do you want to continue? y/n:");
                        if (Console.ReadLine().ToLower() == "y") goto start;
                        else goto End;
                    }
                    break;
                    case 2:
                    {
                        if (userBalance - 7 >= 0)
                        {
                            basket += "Snikers,";
                            userBalance -= 7;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Do you want to continue? y/n:");
                        if (Console.ReadLine().ToLower() == "y") goto start;
                        else goto End;
                    }
                    break;
                    case 3:
                    {
                        if (userBalance - 9 >= 0)
                        {
                            basket += "Mars,";
                            userBalance -= 9;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Do you want to continue? y/n:");
                        if (Console.ReadLine().ToLower() == "y") goto start;
                        else goto End;
                    }
                    break;
                    case 4:
                    {
                        if (userBalance - 4 >= 0)
                        {
                            basket += "M&Ms,";
                            userBalance -= 4;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Do you want to continue? y/n:");
                        if (Console.ReadLine().ToLower() == "y") goto start;
                        else goto End;
                    }
                    break;
                    case 5:
                    {
                        if (userBalance - 14 >= 0)
                        {
                            basket += "Chips,";
                            userBalance -= 14;
                        }
                        else
                        {
                            System.Console.WriteLine(erroBalanceMessage);
                            goto End;
                        }
                        System.Console.Write("Do you want to continue? y/n:");
                        if (Console.ReadLine().ToLower() == "y") goto start;
                        else goto End;
                    }
                    break;
                case 6: goto End;
                default: goto start;
                break;
            }

        End:
            System.Console.WriteLine($"Your prchases:{basket}\nYour balance:{userBalance}");
            System.Console.WriteLine("If you want to replenish your balance push \"a\"\n If you want to exit push some another keys: ");
            if(Console.ReadLine().ToLower() == "a"){
                System.Console.WriteLine("how much do you want to replenish your balance? ");
                int money = int.Parse(Console.ReadLine());
                userBalance += money;
                System.Console.WriteLine("Do you want to continue shopping? y/n :");
                if (Console.ReadLine().ToLower() == "y") goto start;
                        else System.Console.WriteLine("Good bye!");
            } else {
                System.Console.WriteLine("Good bye!");
            }


            Console.ReadKey();
        }
    }
}