using System;

class Program
{
    static void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            Console.Write(", ");
        }
        Console.WriteLine(); 
    }

    static string[] Number()
    {
        Console.WriteLine("Введите значения через запятую в одну строку: ");
        string input = Console.ReadLine();
        string[] numberArray = input.Split(",");
        return numberArray;
    }

    static string[] Len3Array()
    {
        string[] array = Number();
        string newString = String.Empty;
        for (int count = 0; count < array.Length; count++)
        {
            if (array[count].Length <= 3)
            {
                newString = newString + array[count] + ",";
            }
        }

        if (!string.IsNullOrEmpty(newString))
        {
            newString = newString.Remove(newString.Length - 1);
        }

        string[] newArray = newString.Split(",");
        return newArray;
    }

    static void Main()
    {
        PrintArray(Len3Array());
    }
}