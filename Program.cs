using System;

namespace Account_object
{
    public class Bank_Account
    {
        static String AccountNo;
        static String password;
        static Double Balance;

        public Bank_Account(String Account, String password1, Double Balan)
        {
            AccountNo = Account;
            password = password1;
            Balance = Balan;

        }

        public void input_Attributes()
        {
            Console.WriteLine(" NCEDA UFAKE INOMBOLO YE AKHAWUNTI ");
            AccountNo = Console.ReadLine();
            Console.WriteLine(" NCEDA UFAKE INOMBOLO YOKUVULA ");
            password = Console.ReadLine();
            Console.WriteLine(" NCEDA UFAKE IBHALANSI YOKUQALA ");
            Balance = Convert.ToDouble(Console.ReadLine());

        }


        static void validation(string pass)
        {

            if (pass != password)
            {

                Console.WriteLine(" IGAMA LOKUGQITHISA ALILUNGANGA,");
                Console.WriteLine("__PHINDA UFAKE KWAKHONA");
                password = Console.ReadLine();

            }
        }
        static void Deposit()
        {
            Console.WriteLine();
            Console.WriteLine("       ______UZO DIPHOZITHA_______    ");
            Console.WriteLine();
            Console.WriteLine(" NCEDA UFAKE INOMBOLO YOKUVULA ");
            String password1 = Console.ReadLine();
            validation(password1);
            Console.WriteLine(" FAKA IMALI ");
            Double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" INGABA UFUNA UKUBONISA IBHALANSI YAKHO ?");
            string answer = Console.ReadLine();
            Console.WriteLine(" IBHALANSI :  R" + (amount + Balance));

        }
        static void Withdraw()
        {
            Console.WriteLine();
            Console.WriteLine("       ______UZOKHUPHA IMALI______   ");
            Console.WriteLine();
            Console.WriteLine(" NCEDA UFAKE INOMBOLO YOKUVULA ");
            String password1 = Console.ReadLine();
            validation(password1);
            Double Amount;
            Console.WriteLine(" BHALA IMALI UZAKUYIKHUPHA");
            Amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" IBHALANSI : R" + (Balance - Amount));
        }
        public string Transaction()
        {
            string a;
            Console.WriteLine(" INGABA UFUNA 'UKUKHUPHA' OKANYE 'UKUFAKA' IMALI ?");
            a = Console.ReadLine();
            return a;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Bank_Account Obj = new Bank_Account("12344", " 1234", 1000);
                Obj.input_Attributes();
                if (Obj.Transaction() == "UKUKHUPHA")
                {
                    Withdraw();
                }
                else
                {
                    Deposit();
                }
            }
        }
    }
}

