// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

void Zadacha45()
{
    Random random = new Random();
    int [] array = new int [random.Next(4,8)];
    int [] secondArray = new int [array.Length];
     
     FillArray(array, 1, 9);
     PrintArray(array);
     Console.WriteLine();
     CopyArray(array, secondArray);
     PrintArray(secondArray);
    
}
void FillArray(int [] array, int startNumber = 0, int finishNumber = 0)
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

void CopyArray(int [] array, int [] secondArray)
{
    for(int i = 0; i < array.Length; i++)
    {
        secondArray [i] = array [i];
    }
}

Zadacha45();