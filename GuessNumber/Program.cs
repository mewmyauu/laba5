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

// Console.Write("enter age: : ");

// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "soversh" : "nesoversh";

// Console.WriteLine($"ti {ageGroup}.");
// Console.Write("\ntemperatura (°C): ");

// double temp = double.Parse(Console.ReadLine());

// string weather = temp >= 20 ? "heat" : (temp >= 0 ? "holod" : "moroz");

// Console.WriteLine($"{weather} na ulitse");

// Console.Write("\nvvedi 4islo: ");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "4etnoe" : "ne4et";
// Console.WriteLine($"{n} - {parity}");

// Console.WriteLine("меню");
// Console.WriteLine("1. прос. расписание");
// Console.WriteLine("2. прос. оценки");
// Console.WriteLine("3. связаться с преподавателем");
// Console.WriteLine("4. выйти");

// Console.WriteLine("выберите пункт (1-4): ");

// string choice = Console.ReadLine();
// switch (choice)
// {
//     case "1":
//         Console.WriteLine("rasp: isp 244 kab 103 08:00");
//         break;
//     case "2":
//         Console.WriteLine("ocenki irspo 20 pmp - 35");
//         break;
//     case "3":
//         Console.WriteLine("email");
//         break;
//     case "4":
//         Console.WriteLine("dosvidanie");
//         break;
//     default:
//         Console.WriteLine($"{choice} ne raspoznan");
//         break;
// }

// Console.Write("\nвведите номер дня недели (1-7): ");
// int daynum = int.Parse(Console.ReadLine());

// switch (daynum)
// {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("рабочий день - пора учиться");
//         break;
//     case 6:
//     case 7:
//         Console.WriteLine("выходной - заслуженный отдых");
//         break;
//     default:
//         Console.WriteLine("такого дня не сущ");
//         break;
// }

Console.Write("\nвведите номер mesyac (1-7): ");
int mesyac = int.Parse(Console.ReadLine());

switch (mesyac)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("зима");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("vesna");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("leto");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("osen");
        break;
    default:
        Console.WriteLine("takova neet");
        break;
}