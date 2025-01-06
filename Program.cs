using OOP.BankAccounts;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankaccount1 = new BankAccount(1, "Thierry", 67.1);
            var bankaccount2 = new BankAccount(2, "Monica", 61);
            var bankaccount3 = new BankAccount(3, "Roberto", 12);

            bankaccount1.display_data();
            bankaccount1.withdraw(10);
            bankaccount1.display_data();
            bankaccount2.display_data();
            bankaccount2.deposit(10);
            bankaccount2.display_data();
            bankaccount3.display_data();
            bankaccount3.withdraw(3);
            bankaccount3.deposit(222);
            bankaccount3.withdraw(333);
            bankaccount3.display_data();
        }
    }
}
