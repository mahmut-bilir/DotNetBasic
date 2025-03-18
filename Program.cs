// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number = 5;
double pi = 3.14;
char letter = 'A';
bool control = true;
string message = "Hello, World!";
var name = "Mahmut";
var age = 18;

int x = 10, y = 20;
bool result = (x < y) && (y > 15);

if (age >= 18)
{
    Console.WriteLine("You can get a driver's licence.");
}
else
{
    Console.WriteLine("Your not old enought to get a driver's licence.");
}

int day = 3;

switch (day)
{
    case 1:

        Console.WriteLine("Monday");
        break;

    case 2:

        Console.WriteLine("Tuesday");
        break;

    case 3:

        Console.WriteLine("Wednesday");
        break;

    default:
        Console.WriteLine("Invalid day");
        break;

}

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Number: " + i);
}

int counter = 1;
while (counter <= 5)
{
    Console.WriteLine("Number: " + counter);
    counter++;
}

int n = 1;
do
{
    Console.WriteLine("N: " + n);
    n++;
} while (n <= 5);