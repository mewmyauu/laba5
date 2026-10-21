
// zadanie 1
// string password = Console.ReadLine();
// string prav_password = "password";

// if (password == prav_password)
// {
//     Console.WriteLine("password prinyat");
// } else
// {
//     Console.WriteLine("password ne prinyat");
// }

// zadanie 2
// int vozrast = int.Parse(Console.ReadLine());

// if (vozrast >= 18)
// {
//     Console.WriteLine("dostup razreshen");
// } else
// {
//     Console.WriteLine("zapreshen dostup");
// }

// zadanie 3
// int first = int.Parse(Console.ReadLine());
// int second = int.Parse(Console.ReadLine());
// string operation = Console.ReadLine();

// switch (operation) 
// {
//     case "+":
//         Console.WriteLine(first + second);
//         break;
//     case "-":
//         Console.WriteLine(first - second);
//         break;
//     case "*":
//         Console.WriteLine(first * second);
//         break;
//     case "/":
//         if (second == 0)
//             Console.WriteLine("delenie na nol");
//         else
//             Console.WriteLine(first / second);
//         break;
//     default:
//         Console.WriteLine("neiv oper");
//         break;
// }

// zadanie 4
// int first = int.Parse(Console.ReadLine());
// int second = int.Parse(Console.ReadLine());
// int three = int.Parse(Console.ReadLine());
// int total = 0;

// if (first > 0)
// {
//     total = total + first;
// }

// if (second > 0)
// {
//     total = total + second;
// }

// if (three > 0)
// {
//     total = total + three;
// }

// Console.WriteLine(total);

// zadanie 5
// using System.Linq.Expressions;

// Console.WriteLine("Вы стоите перед первой дверью. Перед вами два пути:");
// Console.WriteLine("A: Войти в комнату с огромным драконом.");
// Console.WriteLine("B: Пойти по тёмному коридору.");
// Console.Write("Ваш выбор (A/B): ");
// string put = Console.ReadLine();

// if (put == "A")
// {
//     Console.WriteLine("Дракон говорит: \"Кто не дышит, но живёт; хоть не нужно - много пьёт; и в жизни, и в смерти тело как лёд.\"");
//     Console.Write("Ваш ответ: ");
//     string ovet = Console.ReadLine();

//     if (ovet == "рыба")
//     {
//         Console.WriteLine("Верно! Дракон открывает дверь в следующую комнату. Вы продолжаете путь к Dungeon Master'у.");
//     }
//     else
//     {
//         Console.WriteLine("Неверно! Дракон вас съел. Игра окончена.");
//     }
// }
// else if (put == "B")
// {
//     Console.WriteLine("Вы попали в тёмную комнату с двумя дверями:");
//     Console.WriteLine("1: За ней скрыты сокровища Dungeon Master'а.");
//     Console.WriteLine("2: За ней - ловушка с ядовитыми шипами.");
//     Console.Write("Выберите дверь (1/2): ");
//     int door = int.Parse(Console.ReadLine());

//     if (door == 1)
//     {
//         Console.WriteLine("Вы открыли дверь и нашли сокровища Dungeon Master'а! Победа!");
//     }
//     else if (door == 2)
//     {
//         Console.WriteLine("Вы попали в ловушку с ядовитыми шипами.");
//     }
//     else
//     {
//         Console.WriteLine("Такой двери нет. Вы заблудились в темноте.");
//     }
// }
// else
// {
//     Console.WriteLine("Такого пути нет.");
// }



    