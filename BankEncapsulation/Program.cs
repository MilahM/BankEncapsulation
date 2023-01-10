namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("Enter deposit amount.");

            var depositAmount = double.Parse(Console.ReadLine());

            account.Deposit(depositAmount);

            Console.WriteLine($"Thank you! Your new Account Balance is: ${account.GetBalance()}");
            
        }
    }
}
