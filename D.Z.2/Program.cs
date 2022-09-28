//Zadanie_10();
void Zadanie_10()
{
    //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    Console.WriteLine("Введите трёхзначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    int hundreds = number / 100;
    int tens = number / 10 % 10;
    int ones = number % 10;
    Console.Write(" Вторая цифра числа " + (number) + " это " + (tens));
}


// Zadanie_13();
void Zadanie_13()
{
    // Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает,
    // что третьей цифры нет.
    Console.WriteLine("Введите любое число");
    int number1 = Convert.ToInt32(Console.ReadLine());
    if (number1 < 100)
    {
       Console.WriteLine("В числе " + (number1) + " третьей цифры нет!"); 
    }
    else
    {
        int number2 = number1;
        while (number1 > 999)
        {
            number1 = number1 / 10;
        }
        number1 = number1 % 10;
        Console.WriteLine("В числе " + (number2) + " третья цифра " + (number1));
    }
}


// Zadanie_15();
void Zadanie_15()
{
    // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
    // является ли этот день выходным.
    Console.Write("Введи цифру, обозначающую день недели: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string[] weekday ={"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
    if (number == 6 || number== 7 )
    {
        Console.WriteLine($"Это {weekday[number - 1]} Этот день недели - выходной");
    }
    else if (number < 1 || number > 7)
    {
       Console.WriteLine("Данное число не является днём недели"); 
    }
    else
    {
        Console.WriteLine($"Это {weekday[number - 1]} Этот день недели - не выходной");
    }
}