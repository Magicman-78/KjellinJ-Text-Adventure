﻿using static System.Net.Mime.MediaTypeNames;
using System.Numerics;

namespace Josiahs_Wonderful_World
{


    internal class Program
    {
        static bool HasKey = false;
        // Makes a string named "line" and an int named "Delay" that has a default 50 millisecond sleep time
        static void Type(string line, int Delay = 0)
        {
            // Counts how many characters are in your word
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                Thread.Sleep(Delay);
            }

        }
        // This copy of the code above allows me to use the Type code but it ends the line afterwards
        static void TypeLine(string line, int Delay = 0)
        {
            Type(line, Delay);

            Console.WriteLine();
        }


        // Creates a code to run the Ringing at the same time as the Type code
        static void Ringing(int Pitch = 1000, int Duration = 5000)
        {
            new Thread(() => Console.Beep(1000, 5000)).Start();
        }
        
        static void SnarkyRemark()
        {
            TypeLine("Type it better dummy");
        }
        static void PrintMainMenu()
        {
            TypeLine("Hello! And welcome to Josiah's Wonderful World!\n");
            TypeLine("Where would you like to go?\n");
            TypeLine("> The squishy room\n");
            TypeLine("> The bathroom\n");
            TypeLine("> The silent room\n");
            TypeLine("> The hallway\n");

        }

        static void PrintMainArea()
        {
            TypeLine("Where would you like to go?\n");
            TypeLine("> The squishy room\n");
            TypeLine("> The bathroom\n");
            TypeLine("> The silent room\n");
            TypeLine("> The hallway\n");
        }

        static void PrintLobby()
        {
            TypeLine("Where would you like to go?\n");
            TypeLine(">The main office\n");
            TypeLine(">The hallway across from you\n");
            TypeLine(">The empty benches\n");
            TypeLine(">The front doors\n");
        }
        static void Main(string[] args)
        {
            Console.Title = ("Josiah's Wonderful World");

            PrintMainMenu();

            string Answer = Console.ReadLine();

            if (Answer == "The squishy room")
            {
                Type("The walls and floor are covered in squishy moist");
                Console.ForegroundColor = ConsoleColor.Red;
                Type(" f l e s h ");
                Console.ForegroundColor = ConsoleColor.White;
                TypeLine("that reminds you of canned spam or thanksgiving ham\n");
                TypeLine("Your shoes squish and sink slightly into the floor as you step on it\n");
                TypeLine("It reeks of something dead\n");
                TypeLine("What would you like to do?\n");
                TypeLine(">Feel the wall\n");
                TypeLine(">Leave\n");

                Answer = Console.ReadLine();

                if (Answer == "Feel the wall") 
                {
                    TypeLine("You slide your hand against the wall. It feels slightly warm, and it covers your hand in a thin slimy layer that you quickly wipe off on your shirt\n");
                    TypeLine(">Leave");

                    Answer = Console.ReadLine();

                    if (Answer == "Leave")
                    {
                        PrintMainArea();

                        Answer = Console.ReadLine();
                    }
                    
                }

                else if (Answer == "Leave")
                {
                    PrintMainArea();
                }

                else
                {
                    SnarkyRemark();
                }
            }

           

            if (Answer.ToUpper() == "THE BATHROOM")
            {
                Type("The walls have smiling");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Type(" suns ");
                Console.ForegroundColor = ConsoleColor.White;
                TypeLine("and clouds that would be present in a child's hospital\n");
                TypeLine("The place reeks of human feces and pee\n");
                TypeLine("You feel dirty just being in here\n");
                TypeLine("There's a singular toilet in the room with something inside of it\n");
                TypeLine("What do you want to do?\n");
                TypeLine(">Inspect what's in the toilet\n");
                TypeLine(">Leave\n");

                Answer = Console.ReadLine();

                if (Answer == "Inspect what's in the toilet")
                {
                    TypeLine("It appears to be some kind of office key\n");
                    TypeLine("Where could it lead? You wonder\n");
                    TypeLine(">Leave\n");
                    HasKey = true;

                    Answer = Console.ReadLine();

                    if (Answer == "Leave")
                    {
                        PrintMainArea();
                    }

                    Answer= Console.ReadLine();
                }

                else if (Answer == "Leave")
                {
                    PrintMainArea();
                }

             
            }

            if (Answer == "The silent room")
            {
                TypeLine("The walls, ceiling, and floor are covered in white pads that remind you of mattresses\n");
                Type("There are small dark ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Type("rust-colored ");
                Console.ForegroundColor = ConsoleColor.White;
                TypeLine("stains scattered all around the room\n");
                Type("It’s so quiet that all you can hear is the ");
                Ringing();
                TypeLine("ringing in your ears\n");
                TypeLine("You don't want to be in this room anymore\n");
                TypeLine(">Leave\n");

                Answer = Console.ReadLine();

                if (Answer == "Leave")
                {
                    PrintMainArea();
                }
               
                Answer = Console.ReadLine();
            }
        
        
            if (Answer == "The hallway")
            {
                Type("As you stand in the middle of the hall, you look up at the ");
                Console.ForegroundColor= ConsoleColor.Green;
                Type("c");
                Console.ForegroundColor = ConsoleColor.Blue;
                Type("o");
                Console.ForegroundColor = ConsoleColor.Red;
                Type("l");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Type("o");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Type("r");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Type("f");
                Console.ForegroundColor = ConsoleColor.Blue;
                Type("u");
                Console.ForegroundColor = ConsoleColor.Green;
                Type("l ");
                Console.ForegroundColor = ConsoleColor.White;
                TypeLine("drawings made by all of this year's patients");
                TypeLine("Looking around at the empty hall and rooms gives you an eerie feeling that something is missing\n");
                TypeLine("There should be kids running around and smiling as they run past you, excited for whatever the doctor wants to show them next\n");
                Type("This thought makes you ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Type("shiver ");
                Console.ForegroundColor = ConsoleColor.White;
                TypeLine("a little, and you keep moving forward\n");
                TypeLine("There are ceiling tiles scattered on the floor, and you hear a skittering above you, but it turns out to be some rats living in the ceiling\n");
                TypeLine("Your shoes tap on the floor creating a rhythmic noise as you pass by many rooms with tables and chairs flipped sideways and upside down, with papers scattered everywhere\n");
                TypeLine("Finally you reach the main lobby\n");
                TypeLine("The lobby contains two empty benches, an office and the front doors, as well as a hallway across from you\n");
                TypeLine("Where would you like to go?\n");
                TypeLine(">The main office\n");
                TypeLine(">The hallway across from you\n");
                TypeLine(">The empty benches\n");
                TypeLine(">The front doors\n");
                TypeLine("Go back the other way\n");

                Answer = Console.ReadLine();

                if (Answer == "The main office")
                {
                    TypeLine("You try the handle to the door but it doesn't budge\n");
                    TypeLine("You look into the office window and see an old dusty computer and keyboard sitting on a desk, as well as two filing cabinets with drawers in disarray\n");
                    TypeLine("Maybe there's a key around here somewhere?\n");

                    if (HasKey == true)
                    {
                        TypeLine("You remember that you found a key inside that nasty bathroom\n");
                        TypeLine("Try the key? (Yes or No)\n");

                        Answer = Console.ReadLine();

                        if (Answer == "Yes")
                        {
                            TypeLine("The key slides into the handle with minimal effort, and the door unlocks as you turn the key and push open the door\n");
                            TypeLine("The office is covered in layers of thick dust that cause you to cough as you move inside\n");
                            TypeLine("The computer sitting atop the desk below the window looks as though it hasn't been touched in years, and it's extremely outdated\n");
                            TypeLine("You press the button to turn the computer on, and to your surprise, it begins to light up with a dim blue color\n");
                            TypeLine("The computer auto fills the username, but it looks like you need a password\n");
                            TypeLine("You remember that the person who worked in the office never had a great memory\n");
                            TypeLine("There should be a sticky note with the password around here somewhere\n");
                            TypeLine("Look around? (Yes or No)\n");

                            Answer = Console.ReadLine();

                            if (Answer == "Yes")
                            {
                                TypeLine("You search around the various filing cabinets and papers strewn across the floor\n");
                                TypeLine("After a few minutes of searching, you find sticky note with the code 8372\n");
                                TypeLine("You open the files on the computer’s desktop and see reports on the children that they kept here\n");
                                TypeLine("This is what they say:\n");
                                Console.WriteLine("Report #23");
                                Console.WriteLine("4/21/88");
                                Console.WriteLine("Patient number 2 has been exhibiting more and more dangerous behavior, and his health is rapidly deteriorating. He hasn’t been behaving well with the other kids and often starts fights. One time when another doctor came to visit him in his room, he tried to kill him with a colored pencil. The doctor was wounded in the neck and is still recovering.\n");
                                Console.WriteLine("Report #30");
                                Console.WriteLine("5/7/88");
                                Console.WriteLine("The children are getting more and more out of control. They have all begun retaliating against us and won’t follow anything we say. It’s getting harder and harder to keep them in their rooms. I fear that they may overtake us soon, and at the time of writing this, it may be too late.\n");
                                Console.WriteLine("Report #31");
                                Console.WriteLine("5/7/88");
                                Console.WriteLine("Everything is in chaos as the alarms are blaring and we have been forced to go on lockdown. As I am writing this, our numbers are quickly decreasing. If you are reading this, I’m already dead, and the experiment has failed. Maybe one day somebody will succeed where we have failed. I wonder what awaits me in the great beyond. After all I’ve done, it surely can’t be anything good. God help us now.\n");
                                TypeLine("You knew that there was no hope for this place, but a part of you deep down still hoped there was a chance that your boy was still out there\n");
                                TypeLine("Just as a tear slides down your cheek slowly, the power goes out and you can’t see a thing\n");
                                TypeLine("Luckily you came prepared for this with an industrial flashlight on your hip\n");
                                TypeLine("You leave the office, trying not to trip over anything in the dark\n");
                                TypeLine("Where would you like to go?\n");
                                TypeLine(">The hallway across from you\n");
                            }

                            else if (Answer == "No")
                            {
                                PrintLobby();
                            }

                            else
                            {
                                SnarkyRemark();
                            }
                        }

                        else if (Answer == "No")
                        {
                            PrintLobby();
                        }

                    }

                    else if (HasKey == false)
                    {
                        TypeLine(">Leave");

                        if (Answer == "Leave")
                        {
                            PrintLobby();
                        }
                        
                        Answer = Console.ReadLine();
                    }
                }
            
                else if (Answer == "The hallway across from you")
                {
                    TypeLine("As you walk down the corridor you imagine the horrible things that happened here\n");
                    TypeLine("It must have been terrible being a child here\n");
                    TypeLine("You feel ashamed for ever leaving your kid here\n");
                    TypeLine("When you reach the end of the hall, there are several barricaded rooms and a window above you that casts pale moonlight onto the ground\n");
                    TypeLine("One door is untouched, and has a label beside it that reads “electrical room”\n");
                    TypeLine("What do you want to do?\n");
                    TypeLine(">Enter the electrical room");
                    TypeLine(">Go back to the lobby");

                    Answer = Console.ReadLine();

                    if (Answer == "Enter the electrical room")
                    {
                        TypeLine("The electrical room is really more of a closet\n");
                        TypeLine("Inside is a few mops and brooms and other custodial objects that the janitor would use\n");
                        TypeLine("On the wall is the electrical box\n");
                        TypeLine("You open it up and everything seems to be fine with it\n");
                        TypeLine("What would you like to do?\n");
                        TypeLine(">Leave");

                        Answer = Console.ReadLine();
                    }

                    else if (Answer == "Go back to the lobby")
                    {
                        PrintLobby();
                    }

                    else
                    {
                        SnarkyRemark();
                    }
                    
                
                }
            
                else if (Answer == "The empty benches")
                {

                }
            
                else if (Answer == "The front doors")
                {

                }

                else if (Answer == "Go back")
                {
                    PrintMainArea();
                }

            }
        }
    }
}
