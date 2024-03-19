using System;

class Pr2 
{
    static void Main() 
    {
        int[] num_list = new int[3];
        
        Random random_num = new Random();
        
        Console.WriteLine("3 numbers:");
        for(int i = 0; i < 3; i++)
        {
            num_list[i] = random_num.Next(-10, 20);
            Console.WriteLine(num_list[i]);
        }
        
        Console.WriteLine("Numbers between 1 and 17:");
        for(int i = 0; i < 3; i++)
        {
            if(num_list[i] > 0 && num_list[i] < 17)
            {
                Console.WriteLine(num_list[i]);
            }
        }
        
    }
}
