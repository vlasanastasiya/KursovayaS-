//Задача: Написать программу, которая из имеющегося массива строк 
//формирует массив из строк, длина которых меньше либо равна 3 символа. 

void Zadacha()
{
string[] arrayA = new string [5] {"World", "Hi", ":)", "222", "Kazan"};
Console.WriteLine("Вывод массива");
PrintArray(arrayA);
string[] arrayB = new string [arrayA.Length];
FindArray(arrayA, arrayB);
Console.WriteLine("Вывод сформированного массива");
PrintArray(arrayB);

void PrintArray(string[] arrayA)
{
    for (int i = 0; i < arrayA.Length; i++)
   {
        Console.Write(arrayA[i] + "\t");
   }
Console.WriteLine();
}

void FindArray(string[] arrayA, string[] arrayB)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
        if (arrayA[i].Length <= 3)
        {
            arrayB[count] = arrayA[i];
            count++;
        }
    }
}
}
Zadacha();
