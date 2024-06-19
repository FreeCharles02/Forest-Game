using System;
using System.Xml.Serialization;
namespace ConsoleApp1
{
    
class Program {

static void Main(string[] args) {

Console.WriteLine("You're lost in the magic woods an elf walks up to you in the dark and asks for you to come with them to shelter, what do you do?:");
Console.WriteLine("Options: \n 1. Go with Elf \n 2. Punch elf \n 3. Run from elf");
var userinput = Console.ReadLine();
var choice = int.Parse(userinput);

if (choice == 1) {
Console.WriteLine("You go with the elf, he takes you to his little humble abode in the side of a tree he cooks you a bowl of porridge and shows you where you will be sleeping");
Console.WriteLine("Options: \n 1. Happily Eat \n 2. Go to Sleep \n 3. Escape secretly");
}
        }
    }
};