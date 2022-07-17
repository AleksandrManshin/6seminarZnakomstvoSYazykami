// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.

void Zadacha40()
{
    Console.WriteLine("Введите 3 длинны сторон треугольника: ");
    Console.WriteLine("Сторона а: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сторона b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сторона c: ");
    int c = Convert.ToInt32(Console.ReadLine());

    Raschet(a, b, c);
}

void Raschet(int numb1 = 0, int numb2 = 0, int numb3 = 0)
{
    if(numb1 + numb2 > numb3 && numb1 + numb3 > numb2 && numb2 + numb3 > numb1)
    {
        Console.WriteLine("Такой треугольник существует");
    }
    else Console.WriteLine("Такой треугольник существовать не может");
}

//Zadacha40();

void Z40()
{
    int number1 = 50000;
    int number2 = 3;
    int number3 = 4;
    if(CheckSum(number1, number2, number3) && 
    CheckSum(number2, number3, number1) &&
    CheckSum(number3, number1, number2))
    {
        Console.WriteLine("Треугольник существует");
    }
    else Console.WriteLine("Треугольника нет");
}

bool CheckSum(int a, int b, int c)
{
    return a + b > c;
}

Z40();