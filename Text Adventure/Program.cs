using static System.Net.Mime.MediaTypeNames;
using System.Numerics;

namespace Text_Adventure
{
    internal class Program
    {
        // Makes a string named "line" and an int named "Delay" that has a default 50 millisecond sleep time
        static void Type(string line, int Delay = 50)
        {
            // Counts how many characters are in your word
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                Thread.Sleep(Delay);
            }

        }
        // This copy of the code above allows me to use the Type code but it ends the line afterwards
        static void TypeLine(string line, int Delay = 50)
        {
            Type(line, Delay);

            Console.WriteLine();
        }


        // Creates a code to run the Ringing at the same time as the Type code
        static void Ringing(int Pitch = 1000, int Duration = 5000)
        {
            new Thread(() => Console.Beep(1000, 5000)).Start();
        }
        

        static void PrintMainMenu()
        {
            TypeLine("Hello! And welcome to Josiah's wonderful world!\r\n");
            TypeLine("Where would you like to go?\r\n");
            TypeLine("> The squishy room\r\n");
            TypeLine("> The bathroom\r\n");
            TypeLine("> The silent room\r\n");
            TypeLine("> The hallway\r\n");

        }

        static void PrintMainArea()
        {
            TypeLine("> The squishy room\r\n");
            TypeLine("> The bathroom\r\n");
            TypeLine("> The silent room\r\n");
            TypeLine("> The hallway\r\n");
        }
        static void Main(string[] args)
        {


            PrintMainMenu();

            string Answer = Console.ReadLine();

            if (Answer == "The squishy room")
            {
                Type("The walls and floor are covered in squishy moist");
                Console.ForegroundColor = ConsoleColor.Red;
                Type(" f l e s h ");
                Console.ForegroundColor = ConsoleColor.White;
                TypeLine("that reminds you of canned spam or thanksgiving ham\r\n");
                TypeLine("Your shoes squish and sink slightly into the floor as you step on it\r\n");
                TypeLine("It reeks of something dead\r\n");
                TypeLine("What would you like to do?\r\n");
                TypeLine("Feel the wall\r\n");
                TypeLine("Leave\r\n");

                Answer = Console.ReadLine();

                if (Answer == "Feel the wall") 
                {
                    TypeLine("You slide your hand against the wall. It feels slightly warm, and it covers your hand in a thin slimy layer that you quickly wipe off on your shirt");
                }
                else if (Answer == "Leave")
                {
                    PrintMainArea();
                }

                Answer = Console.ReadLine();

            }

           

            if (Answer == "The bathroom")
            {
                Type("The walls have smiling");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Type(" suns ");
                Console.ForegroundColor = ConsoleColor.White;
                TypeLine("and clouds that would be present in a child's hospital\r\n");
                TypeLine("The place reeks of human feces and pee\r\n");
                TypeLine("You feel dirty just being in here\r\n");
                TypeLine("There's a singular toilet in the room with something inside of it\r\n");
                TypeLine("What do you want to do?\r\n");
                TypeLine(">Inspect what's in the toilet\r\n");
                TypeLine(">Leave\r\n");

                Answer = Console.ReadLine();

                if (Answer == "Inspect what's in the toilet")
                {
                    TypeLine("It appears to be some kind of office key\r\n");
                    TypeLine("Where could it lead? You wonder\r\n");
                }

                else if (Answer == "Leave")
                {
                    PrintMainArea();
                }

                Answer = Console.ReadLine();
            }

            if (Answer == "The silent room")
            {
                TypeLine("The walls, ceiling, and floor are covered in white pads that remind you of mattresses\r\n");
                Type("There are small dark ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Type("rust-colored ");
                Console.ForegroundColor = ConsoleColor.White;
                TypeLine("stains scattered all around the room\r\n");
                Type("It’s so quiet that all you can hear is the ");
                Ringing();
                TypeLine("ringing in your ears\r\n");
                TypeLine("You don't want to be in this room anymore\r\n");
                TypeLine(">Leave\r\n");

                Answer = Console.ReadLine();

                if (Answer == "Leave")
                {
                    PrintMainArea();
                }
               
                Answer = Console.ReadLine();
            }
        
        
            if (Answer == "The hallway")
            {
                TypeLine("As you stand in the middle of the hall, you look up at the colorful drawings made by all of this year's patients\r\n");
                TypeLine("Looking around at the empty hall and rooms gives you an eerie feeling that something is missing\r\n");
                TypeLine("There should be kids running around and smiling as they run past you, excited for whatever the doctor wants to show them next\r\n");
                Type("This thought makes you ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Type("shiver ");
                Console.ForegroundColor = ConsoleColor.White;
                TypeLine("a little, and you keep moving forward\r\n");
                TypeLine("There are ceiling tiles scattered on the floor, and you hear a skittering above you, but it turns out to be some rats living in the ceiling\r\n");
            }
        }
    }
}
