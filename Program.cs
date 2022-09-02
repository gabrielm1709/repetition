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
            

        
            // Uppgift 30
            Console.Write("Give me your percent: ");
            int percent = int.Parse(Console.ReadLine());
            int score = 0;

            if(percent <= 49) 
            {
                score = 0;
            }

            if(percent >= 50 && percent <= 59) 
            {
                score = 1;
            }

            if (percent >= 60 && percent <= 69)
            {
                score = 2;
            }

            if (percent >= 70 && percent <= 79)
            {
                score = 3;
            }

            if (percent >= 80 && percent <= 89)
            {
                score = 4;
            }

            if (percent >= 90 && percent <= 100)
            {
                score = 5;
            }

            else 
            {
                Console.WriteLine("Impossible");
            }

            Console.WriteLine($"Your score: {score}");

            // Uppgift 31
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("oDD");
            }

            // Uppgift 36
            int num = int.MinValue;
      
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
            int sum = 0;
            int cnt = -1;
            while(num != 0) 
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                cnt += 1;
            }
            Console.WriteLine($"Summa: {sum}, antal: {cnt}");
            
            // Svårare uppgifter

            // Uppgift 1 
            int len = 5;
            int[] arr = new int[len];
            Console.WriteLine("Array:");
            for (int i = 0; i < len; i++) 
            {
                int numb = int.Parse(Console.ReadLine());
                arr[i] = numb;
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            int[] sortedArr = sort(arr);
            Console.WriteLine("\nSorted Array:");
            for (int i = 0; i < len; i++) 
            {
                Console.Write($"{sortedArr[i]} ");
            }
        }

        static int[] sort(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++) 
                {
                    if(arr[i] > arr[j]) 
                    {
                        int saved = arr[i];
                        arr[i] = arr[j];
                        arr[j] = saved;
                    }
                }
            }
                
            return arr;
        }
    }
}
