﻿//Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string [] array = new string [5] {"Hello","2","world",":-)", "123"};
string [] array1 = new string [array.Length];

void NewArray(string [] array, string [] array1)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            array1[count] = array [i];
            count++;
        }
    }
}
void PrintArray(string [] array1)
{
    for(int i = 0; i<array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
    }
    Console.WriteLine();
}
NewArray(array,array1);
PrintArray(array1);