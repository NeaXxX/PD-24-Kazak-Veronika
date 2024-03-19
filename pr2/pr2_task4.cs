using System;

class Pr2
{
    static void Main()
    {
        int[] num_list = new int[17];
        
        Random random_num = new Random();
        
        Console.WriteLine("List of numbers:");
        for(int i = 0; i < 17; i++)
        {
            num_list[i] = random_num.Next(-10, 20);
            Console.Write(num_list[i] + " ");
        }
        
        Console.WriteLine("\nEnter min number to create new list of numbers:");
        int min = Convert.ToInt32(Console.ReadLine()); 
        int[] new_list = new int[17]; 
        int index = 0;
        
        for(int i = 0; i < 17; i++)
        {
            if(Math.Abs(num_list[i]) > min)
            {
               new_list[index] = num_list[i];
               index++;
            }
        }
        
        Console.WriteLine($"List of numbers that are bigger than {min}");
        for(int i = 0; i < index; i++)
        {
            Console.Write($"{new_list[i]} ");
        }
    }
}
