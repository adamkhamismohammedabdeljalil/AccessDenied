namespace AccessDenied
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyBank customerA = new MyBank();
            customerA.Name = "Homer Simpson";  
            customerA.Balance = 250;
            //if protected access modifier is used for the property AccountNumber, it could not be access at Program.cs, however if it is changed to public or internal it could be accessed
            customerA.AccountNumber = 101;
            customerA.CreditPrompt();
        }
    }
}