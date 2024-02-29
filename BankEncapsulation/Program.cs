namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var userIsAccount = new BankAccount();

            Console.WriteLine("how much $ you want to deposit?");

            double amountToDeposit = double.Parse(Console.ReadLine());

            userIsAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Your current balance is {userIsAccount.GetBalance()}");
        }
    }
}
