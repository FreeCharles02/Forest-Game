using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
namespace ConsoleApp1
{
    
class Program {
static void Main(string[] args) {


Console.WriteLine("You're lost in the magic woods an elf walks up to you in the dark and asks for you to come with them to shelter, what do you do?:");
Console.WriteLine("Options: \n 1. Go with Elf \n 2. Punch elf \n 3. Run from elf");

var userInput = Console.ReadLine();
var c1 = int.Parse(userInput);
var c2 = int.Parse(userInput);
switch (c1) 
{
   case 1: 
    Console.WriteLine("You go with the elf back to his humble abode in the side of a stump");
    Console.WriteLine("The Elf has you sit in his awkardly shaped home and cooks you a hot portion of porridge:");
    Console.WriteLine("\n 1. Happily indulge \n 2. Rest on the couch \n 3. look to escape");  
ChoiceTwo(c2);
   break;

void ChoiceTwo(int c2) {
        Console.ReadLine();
        switch (c2) {
            case 1: 
             Console.WriteLine("You wharf down spoonful after spoonful of the porridge (to the elves disgust), it feels as if you havent eaten for days despite only being lost for a few hours");
                 Console.WriteLine("The Elf tells you about the dangers of the enchanted forest, \n it exists between the world of the living and the dead time doenst exist here and many vile demons and spirits live in purgatory.");
                    Console.WriteLine("The elf tells you how lucky you are to have found him and leaves the room:");
                        Console.WriteLine("\n 1. Investigate \n 2. Rest \n 3. Get seconds");
                            Console.ReadLine();
                            switch (c1) {
                                case 1: 
                                Console.WriteLine("");
                                break; 
                            }
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
            }
        }
    }
