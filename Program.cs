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
ChoiceFollow(c2);
   break;

void ChoiceFollow(int c2) {
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
                                Console.WriteLine("After your sure the elf has left the room an overwhelming sense of curiosity takes hold and you begin to check the room around you");
                                Console.WriteLine("You start feeling around a nearby bookshelf, you end up knocking a book over and suddenly the shelf opens like a door revealing a hidden pathway");
                                Console.WriteLine("\n 1. Enter and descend \n 2. Put book back and close the door \n 3. Question the Elf");
                                Console.ReadLine();
                                break; 
                                
                            }
                    break;
    case 2: 
        Console.WriteLine("You punch the elf out of shock!, The elfs head jerks back from the blow and hits a nearby tree knocking him out cold");
        Console.WriteLine("\n 1. Search elf \n 2. Bury him.. no witnesses... \n 3. Leave Elf alone");
        ChoiceViolence(c1);
            break;
            void ChoiceViolence(int c1) {
                Console.ReadLine(); 
                    switch(c1) {
                        case 1:
                        Console.WriteLine("You Search the elf, wondering if there's anything the elf might carry to help you survive");
                        Console.WriteLine("You find a small keychain on the elf and take some snacks he had too (ingredients for porridge?) and a golden medallion in his pocket");
                        Console.WriteLine("\n 1. Head West \n 2. Head East \n 3.Head North");
                        break;
                        case 2:
                        Console.WriteLine(); 
                        break;
                    }
            }

                case 3:
                   Console.WriteLine("Stranger danger! You sprint in the other direction and can only hear the elf pleading with you to not leave him");
                   ChoiceFlee(c1);
                        break;
                        void ChoiceFlee(int c1) {
                            Console.WriteLine("Escaping the elf you head deeper into the magic woods oddly enough despite the time thats past now it doesnt seem to get ant lighter");
                            Console.WriteLine("You keep heading in the same direction until you notice a cave");
                            Console.WriteLine("\n 1. Enter the Cave \n 2. Scope out the size of the cave \n 3. Call out to see if anyones around");
                            switch (c1) {
                                case 1:
                                Console.WriteLine("Not having anywhere else to really go or be you decide to enter the cave wondering if it might offer shelter");
                                Console.WriteLine("The cave isnt like any cave you've ever seen, its shockingly well lit by torches and outlined by marble flooring and the stone along the walls is is polished and smooth");
                                Console.WriteLine("\n 1. Continue? \n 2. Turn around");
                                    switch (c1) {
                                        
                                    }
                                    break;
                                    case 2: 
                                    Console.WriteLine("Walking around you begin to inspect the sheer size of this cave (going in blind would be a silly idea)");
                                    Console.WriteLine("");
                                break;
                            }
                        }
                    default: 
                    Console.WriteLine("Sorry! That is not an option...");
                    Console.ReadLine();
                    break;
            }
                
                    }
                }
            }
        }
    }
