using System;

class Pr2
{
    static void Main()
    {
        int a, b, c;
        
        Random random_num = new Random();
        a = random_num.Next(1, 20);
        b = random_num.Next(1, 20);
        c = random_num.Next(1, 20);
 
        if(a + c > b && a + b > c && b + c > a)
        {
            Console.WriteLine($"Triangle with sides {a}, {b}, {c} can exist"); 
        }
        else
        {
            Console.WriteLine($"Triangle with sides {a}, {b}, {c} can NOT exist"); 
        }
    }
}
