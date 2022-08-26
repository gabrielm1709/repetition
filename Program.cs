using System;

namespace repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uppgift 1
            Console.WriteLine("Hello World!");

            // Uppgift 2
            Console.WriteLine("Once upon a time\nI was falling in love\nNow I’m only falling apart");


            // Uppgift 3

            // Uppgift 4
            string text = "Live and Sleep";
            Console.WriteLine(text);

            // Uppgift 5
            string name = "Ada LoveLace";
            Console.WriteLine($"Hej {name}");

            // Uppgift 6
            string input = Console.ReadLine();
            Console.WriteLine(input);

            // Uppgift 7
            input = Console.ReadLine();
            Console.WriteLine(input);
            Console.WriteLine(input);
            Console.WriteLine(input);

            // Uppgift 8
            Console.Write("Hello how are you? ");
            input = Console.ReadLine();
            Console.WriteLine($"");
            Console.Write("What's your name? ");
            input = Console.ReadLine();
            Console.WriteLine($"Hej {input}!");
            
            // Uppgift 14
            bool svar = bool.Parse(Console.ReadLine());
            Console.WriteLine(svar);

            // Uppgift 16
            int days = int.Parse(Console.ReadLine());
            int seconds = days * 24 * 3600;
            Console.WriteLine(seconds);
            
          
            // Uppgift 36
            int num = int.MinValue;
            int sum = 0;
            int cnt = -1;

            while(num != 0) 
            {
                num = int.Parse(Console.ReadLine());
                if(num < 0) 
                {
                    Console.WriteLine("Negative");
                }
            }

            // Uppgift 40
            num = int.MinValue;
            sum = 0;
            cnt = -1;
            while(num != 0) 
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                cnt += 1;
            }
            Console.WriteLine($"Summa: {sum}, antal: {cnt}");


        }
    }
}
