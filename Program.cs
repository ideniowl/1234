using System;

class Program
{
static void Main(string[] args)
{
string[] Array = {"1234", "1567", "-2", "computer science"};
int lengthLimit = 3;

 // Создаем новый массив строк, длина которых меньше или равна 3 символам
string[] Array2 = new string[Array.Length];
for (int i = 0; i < Array.Length; i++)
{
if (Array[i].Length <= lengthLimit)
{
Array2[i] = Array[i];
}
else
{
Array[i] = "";
}
}

 // Выводим новый массив
Console.WriteLine("Новый массив:");
for (int i = 0; i < Array2.Length; i++)
{
Console.WriteLine(Array[i]);
}
}
}