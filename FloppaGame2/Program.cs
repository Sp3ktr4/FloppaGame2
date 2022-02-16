using System;

//Loading//
int n = 0;
int hp = 100;
string command;
Random gen = new Random();
while (n < 100)
{
    Console.WriteLine("+-----------+");
    Console.WriteLine($"|Loading {n}%|");
    Console.WriteLine("+-----------+");
    System.Threading.Thread.Sleep(gen.Next(10));
    Console.Clear();
    n++;
}

Console.WriteLine("+------------------------+");
Console.WriteLine("|Welcome to FloppaGame 2!|");
Console.WriteLine("+------------------------+------+");
Console.WriteLine("|Type ENTER to start a new game,|");
Console.WriteLine("|Type EXIT to leave.            |");
Console.WriteLine("+-------------------------------+");
Console.WriteLine($"ENTER COMMAND:");

command = Console.ReadLine();

if (command.ToUpper() == "EXIT")
{
    Console.Clear();
    Console.WriteLine("Shutting down...");
    System.Threading.Thread.Sleep(6000);
    Console.Clear();
    Console.ReadLine();
    int.Parse("DIE");
}
else if (command.ToUpper() == "ENTER")
{
    Console.Clear();
    Console.WriteLine("+--------------------------------+");
    Console.WriteLine("|          FloppaGame 2          |");
    Console.WriteLine("|                                |");
    Console.WriteLine("|    You wake up in the lands    |");
    Console.WriteLine("|    of the flops. It is warm    |");
    Console.WriteLine("|   outside, and you feel like   |");
    Console.WriteLine("|     today is gonna be good.    |");
    Console.WriteLine("|                                |");
    Console.WriteLine("|             Until..,           |");
    Console.WriteLine("|        You hear a faint        |");
    Console.WriteLine("|  explosion and you go outside. |");
    Console.WriteLine("+--------------------------------+");
    System.Threading.Thread.Sleep(10000);
    Console.Clear();
}
Console.WriteLine("+------------------+");
Console.WriteLine("|What is your name?|");
Console.WriteLine("+------------------+");
Console.Write("Enter Username:");

string name = Console.ReadLine();

Console.Clear();
Console.WriteLine("+----------------------+");
Console.WriteLine("|Chapter 1: The Village|");
Console.WriteLine("+----------------------+");
System.Threading.Thread.Sleep(5000);
Console.Clear();
Console.WriteLine("There was an invasion on our village around 1 hour ago...");
System.Threading.Thread.Sleep(3000);
Console.WriteLine(" ");
Console.WriteLine("Many of us tried to fight them of, but we were unsuccessful.");
System.Threading.Thread.Sleep(3000);
Console.WriteLine(" ");
Console.WriteLine("I have been tasked to set out on an adventure to gain information and also try to take down the Bingus Syndicate.");
System.Threading.Thread.Sleep(5000);
Console.Clear();
Console.WriteLine("PRESS `ENTER` TO CONTINUE");

//Gameplay \/\/

Console.WriteLine(" ");
Console.WriteLine("STATS:");
Console.WriteLine("NAME: "+name+"   HP: "+hp+"/100");
Console.WriteLine("EQUIPMENT:");
Console.WriteLine("NONE / NONE");
Console.ReadLine();

//^^Gör till en metod^^

Console.WriteLine("");