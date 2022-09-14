/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами.
*/

string[] FillArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Ввидите значение элемента массива");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] SortArray(string[] array, int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {       
        if (array[i].Length < 4) arr[i] = array[i];
    }
    return arr;
}


Console.WriteLine("Введите количество элементов массива");
int number = int.Parse(Console.ReadLine());

string[] massive = FillArray(number);
PrintArray(massive);
Console.WriteLine();
string[] mass = SortArray(massive, number);
PrintArray(mass);