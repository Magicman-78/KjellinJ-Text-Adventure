namespace Text_Adventure
{
    internal class Program
    {
        static void TypeLine(string line, int Delay = 50)
        {
            // Counts how many characters are in your word n
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                Thread.Sleep(Delay); // Sleep for 150 milliseconds
            }

            Console.WriteLine();
        }
        static void PrintMainMenu()
        {
            TypeLine("Hello! And welcome to Josiah's wonderful world!");
            TypeLine("Where would you like to go?");
            TypeLine("The squishy room");
            TypeLine("The bathroom");
            TypeLine("The silent room");
            TypeLine("The hallway");

            
        }
        static void Main(string[] args)
        {
            // string insert name here = "whatever you want it to print"; will print whatever message you want
            // int insert name here = #; will print whatever number you want
            // bool insert name here = true; will tell you whatever you want is true or false
            // (string + int + bool); will smoosh all the programmed messages together (string concatenation) 
            // Console.Foregroundcolor = ConsoleColor.Red; above your message will change the color of the text 
            // Console.Beep(); will make a beep sound of whatever frequency you type and for however many milliseconds
            // Console.ReadKey; will make the console wait until you press a button to read the next message
            // string myMessage = Console.ReadLine(); and Console.Writeline(myMessage); will print back whatever you assign (type) to be myMessage

            PrintMainMenu();

            string Answer = Console.ReadLine();

            if (Answer == "The squishy room")
            {
                TypeLine("The walls and floor are covered")
            }
        }
    }
}
