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
        
        int min = num_list[0];
        int max = num_list[0];
        
        for(int i = 0; i < 17; i++)
        {
            if(num_list[i] < min)
            {
                min = (num_list[i]);
            }
        }
        Console.WriteLine($"\nMin number is: {min}");
        
        for(int i = 0; i < 17; i++)
        {
            if(num_list[i] > max)
            {
                max = (num_list[i]);
            }
        }
        Console.WriteLine($"Max number is: {max}");
    }
}
