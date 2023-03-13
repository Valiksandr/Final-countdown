
// Задача: Написать программу, которая из имеющегося массива строк формирует массив строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами

Console.Clear();


void Commands()
{
    Console.WriteLine();
    Console.WriteLine("Выберите команду:");
    Console.WriteLine("1 – Ввод массива: [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine("2 – Ввод массива: [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine("3 – Ввод массива: [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine();
}

string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}

Commands();
string[] array = new string[] {};
string fromUser = ReadInput("Введите команду: ");
switch (fromUser)
{
    case "1": array = new string[] { "Hello", "2", "world", ":-)" };
        break;
    case "2": array = new string[] { "1234", "1567", "-2", "computer science" };
        break;
    case "3": array = new string[] { "Russia", "Denmark", "Kazan" };
        break;
    default: Console.WriteLine($"{fromUser} - Такой команды нет");
        break;
}

int LengthNewArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) LengthNewArray++;
}

string[] newArray = new string[LengthNewArray];
    int index = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[index] = array[i];
        index++;
    }
}   
PrintArray(array);
Console.Write("-> ");
PrintArray(newArray);