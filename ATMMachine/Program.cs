using System;

namespace ATMMachine
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("--------------CAMP ATM----------------");
            ShowOperationTypeScreen();
            var oppType = (OperationType)ReadInput();
            ShowAccountTypeScreen();
            var accType = (AccountType)ReadInput();
            PerformOperation(accType, oppType);
            Console.ReadLine();
        }

        private static void ShowOperationTypeScreen()
        {
            Console.WriteLine("-----Choose your Operation Type-------");
            Console.WriteLine("                          Deposit -> 1");
            Console.WriteLine("                         Withdraw -> 2");
            Console.WriteLine("                  Balance Enquiry -> 3");
        }

        private static void ShowAccountTypeScreen()
        {
            Console.WriteLine("------Choose your Account Type--------");
            Console.WriteLine("                           Active -> 1");
            Console.WriteLine("                           Closed -> 2");
            Console.WriteLine("                     In-Operative -> 3");
        }

        private static int ReadInput()
        {
            int input;
            bool inValid;
            do
            {
                inValid = false;
                Console.Write("                                     ");
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Input should be a numaric value");
                    inValid = true;
                }
                else if (input < 1 || input > 3)
                {
                    Console.WriteLine("Input should be among 1, 2, 3");
                    inValid = true;
                }
            } while (inValid);
            return input;
        }

        private static void PerformOperation(AccountType accType, OperationType oppType)
        {
            switch (accType)
            {
                case AccountType.Active:
                    Console.WriteLine("                                  True");
                    Console.WriteLine("                                Active");
                    break;
                case AccountType.Operative:
                    if (oppType.Equals(OperationType.BalanceEnquiry))
                    {
                        Console.WriteLine("                                  True");
                        Console.WriteLine("                           InOperative");
                    }
                    else
                    {
                        Console.WriteLine("                                  True");
                        Console.WriteLine("                                Active");
                    }
                    break;
                case AccountType.Closed:
                    Console.WriteLine("                                 False");
                    Console.WriteLine("                                Closed");
                    break;
            }
        }
    }

    public enum AccountType
    {
        Active = 1,
        Closed = 2,
        Operative = 3
    }

    public enum OperationType
    {
        Deposit = 1,
        Withdraw = 2,
        BalanceEnquiry = 3
    }
}
