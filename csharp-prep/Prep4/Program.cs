using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int num = -1;
        int quant = 0;
        while (num != 0)
        {
            Console.Write("Write a number: ");
            string numb = Console.ReadLine();
            num = int.Parse(numb);
            quant += 1;

            if (num != 0)
            {
                numbers.Add(num);
            }
        }



        foreach (int number in numbers)
        {
            sum += number;
        }

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The sum of all values os my list are: {sum}");
        Console.WriteLine($"The average of my list is {average}");

        int max = numbers[0];
        int min = numbers[0];
        foreach ( int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
            else if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The largest number is {max} and the lowest number is {min} from my list.");
    }
}