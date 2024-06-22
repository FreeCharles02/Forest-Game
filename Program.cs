using System;
using System.Xml.Serialization;
namespace ConsoleApp1
{
    
class Program {

static void Main(string[] args) {

Console.WriteLine("You're lost in the magic woods an elf walks up to you in the dark and asks for you to come with them to shelter, what do you do?:");
Console.WriteLine("Options: \n 1. Go with Elf \n 2. Punch elf \n 3. Run from elf");
var userInput = Console.ReadLine();
var choice = int.Parse(userInput);

switch (choice)
{
   case 1:  
   Console.WriteLine("You go with the elf back to his humble abode in the side of a stump");
   break;

    case 2: 
        Console.WriteLine("You punch the elf out of shock! The elf curses you and leaves you in the dark magic woods alone");
            break;

                case 3:
                   Console.WriteLine("Stranger danger! You sprint in the other direction and can only hear the elf pleading with you to not leave him");
                        break;
                    default: 
                    Console.WriteLine("Sorry! That is not an option...");
                    break;
            }
        }
    }
};