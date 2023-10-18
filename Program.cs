using System.IO;
using DesignPattern;

class Program
{
    public static void Main(String[] args)
    {
        // Get the singleton instance of SingletonClass
        SingletonClass singletonClass = SingletonClass.getInstance();

        try
        {
            while (true)
            {
                Console.Write("Enter a message (or type 'exit' to quit): ");
                string message = Console.ReadLine();

                // Exit loop if user types 'exit' or provides an empty message
                if (string.IsNullOrEmpty(message) || message.ToLower() == "exit")
                {
                    break;
                }

                // Log the entered message
                singletonClass.LogEntryMessage(message);
            }

            Console.WriteLine("Logging complete. Press any key to exit.");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
