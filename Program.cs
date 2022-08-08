using System;
using static System.Console;

Clear();
WriteLine("Данная программа формирует массив строк, введенных с клавиатуры, и формирует из его элементов новый массив строк, длина которых не более 3-х символов ");
Write("Введите строковые значения для заполнения исходного массива через пробел, либо запятую или точкой с зяпятой: ");
string [] arrayForAnalysis = ReadLine().Split(new char[] {' ', ',', ';',}, StringSplitOptions.RemoveEmptyEntries);
WriteLine("Вывод исходного массива с использованием метода PrintArray:");
PrintArray(arrayForAnalysis);

WriteLine("Вывод исходного массива с использованием метода сцепления элементов массива String.Join:");
//Вывод String.Join работает только с одномерными массивами
WriteLine($"[{String.Join(",",arrayForAnalysis)}]");

string [] modified = GetNewArray(arrayForAnalysis);
WriteLine("В результате анализа сформирован массив с элементами из исходного массива, длина которыз не более 3-х символов:");
PrintArray(modified);

// Описание метода сравнения 
string [] GetNewArray (string [] arrayStr)
{
    string tempstr = null;
    for (int i = 0; i < arrayStr.Length; i++)
    {
        if (arrayStr[i].Length <=3) tempstr+= ' ' + arrayStr[i];
    }
    string [] result = tempstr.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    return result;
}

// Описание метода вывода на экран массива
void PrintArray (string[] array)
{
    Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]},"); 
    }
    WriteLine($"{array[array.Length - 1]}]");
}