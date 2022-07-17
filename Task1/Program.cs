// void Recursion(int n)
// {
//     if(n < 0) return;
//     Console.WriteLine(n);
//     n--;
//     Recursion(n);
// }

// Recursion(100);

// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// void Zadacha39()
// {
//     int [] array = new int [8];
//     int [] secondArray = new int [array.Length];
//     FillArray(array, 1, 9);
//     PrintArray(array);
//     Console.WriteLine();
//     int maxIndex = array.Length - 1;

//     for(int i = 0; i < array.Length; i++)
//     {
//         secondArray[maxIndex - i] = array [i];
//     }

//     PrintArray(secondArray);

// }

// void FillArray(int [] array, int startNumber = 0, int finishNumber = 1)
// {
//     finishNumber++;
//     Random random = new Random();
//     for(int i = 0; i < array.Length; i++)
//     {
//         array [i] = random.Next(startNumber, finishNumber);
//     }

// }

// void PrintArray(int[] array)
// {
//     Console.WriteLine();
//     Console.WriteLine("Вывод массива:");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + "\t");
//     }
//     Console.WriteLine();
// }

// Zadacha39();





void Zadacha39()
{
    int [] array = new int [8];
    // int [] secondArray = new int [array.Length];
    FillArray(array, 1, 9);
    PrintArray(array);
    Console.WriteLine();
    int maxIndex = array.Length - 1;

    for(int i = 0; i < array.Length/2; i++)
    {
        // secondArray[maxIndex - i] = array [i];
        // int temp = array[i];
        // array[i] = array[maxIndex - i];
        // array[maxIndex - i] = temp;
        (array[i], array[maxIndex - i]) = (array[maxIndex - i], array [i]);

    }

    PrintArray(array);

}

void FillArray(int [] array, int startNumber = 0, int finishNumber = 1)
{
    finishNumber++;
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array [i] = random.Next(startNumber, finishNumber);
    }

}

void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

Zadacha39();












