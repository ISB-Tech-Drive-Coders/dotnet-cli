namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank you for using the ISBTD Windows Configurator");
            Console.WriteLine("What is this PC's password? (Needed for sudo commands)");
            //sudopswrd is the password to be used for sudo commands
            var sudopswrd = Console.ReadLine();
            //The code lower then this is for the end of the script to exit
            Console.WriteLine("Thank you for using the ISBTD Windows Configurator");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}