// See https://aka.ms/new-console-template for more information
// Console.Write("vvedite 4islo: ");
// int number = int.Parse(Console.ReadLine());

// if (number > 0)
// {
//     Console.WriteLine("Число положительное");
// }
// else if (number < 0)
// {
//     Console.WriteLine("Число отриц");
// }
// else
// {
//     Console.WriteLine("число равно нулю");
// }

// Console.Write("ball (0-100): ");
// int score = int.Parse(Console.ReadLine());

// if (score >= 91)
// {
//     Console.WriteLine("5");
// }
// else if (score >= 71)
// {
//     Console.WriteLine("4");
// }
// else if (score >= 51)
// {
//     Console.WriteLine("3");
// }
// else
// {
//     Console.WriteLine("2");
// }

// Console.Write("sr ball: ");
// int attendance = int.Parse(Console.ReadLine());

// Console.Write("sr ball po prk: ");
// double practicagpa = double.Parse(Console.ReadLine());

// bool goodattendance = attendance >= 14;
// bool goodgrades = practicagpa >= 3.0;

// if (goodattendance && goodgrades)
// {
//     Console.WriteLine("vse 40tko");
// }
// else if (!goodattendance && goodgrades)
// {
//     Console.WriteLine("- nedostato4no pos");
// }
// else if (goodattendance && !goodgrades)
// {
//     Console.WriteLine("- nizkiy ball");
// }
// else
// {
//     Console.WriteLine("- problems ocen i pos");
// }

Console.Write("enter age: : ");

int age = int.Parse(Console.ReadLine());
string ageGroup = age >= 18 ? "soversh" : "nesoversh";

Console.WriteLine($"ti {ageGroup}.");
Console.Write("\ntemperatura (°C): ");

double temp = double.Parse(Console.ReadLine());

string weather = temp >= 20 ? "heat" : (temp >= 0 ? "holod" : "moroz");

Console.WriteLine($"{weather} na ulitse");

Console.Write("\nvvedi 4islo: ");
int n = int.Parse(Console.ReadLine());
string parity = n % 2 == 0 ? "4etnoe" : "ne4et";
Console.WriteLine($"{n} - {parity}");