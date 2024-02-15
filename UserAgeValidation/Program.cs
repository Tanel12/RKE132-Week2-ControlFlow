// See https://aka.ms/new-console-template for more information
using System.Net.Security;

Console.WriteLine("Enter your age:");
//int userAge = Int32.Parse(Console.ReadLine());
string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");
if ( isAgeNumber == true)
{
    if(userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram.");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }

}
else
{
    Console.WriteLine("Could not read your age.");
}
