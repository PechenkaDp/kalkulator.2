using System.Numerics;

public class Example
{
    public static void Main()
    {
        Start:

        Console.WriteLine("Введите 1-е число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2-е число");
        int b = Convert.ToInt32(Console.ReadLine());

        

        Console.WriteLine("Выбор операции: " +
            "    *1-Сложение*" +
            "    *2-Вычитание 1-го числа из 2-го*" +
            "    *3-Умножение*" +
            "    *4-Деление 1-го числа на 2-ое*" +
            "    *5-Возведение 1-го числа в N степень*" +
            "    *6-Вычисление квадратного корня из числа*" +
            "    *7-Нахождение 1% от числа*" +
            "     *8-Вычисление факториала из числа*" 
            
            );
        Console.WriteLine("*NumPad9-Завершение программы*");

        

        int c = Convert.ToInt32(Console.ReadLine());

        do
        {
            if (c == 1)
            {
                Console.WriteLine($"Результат сложения: {a} + {b} = " + (a + b));
                goto Start;
            }
        
       
        
        
        
            if (c == 2)
            {
                Console.WriteLine($"Результат вычитания: {b} - {a} = " + (b - a));
                goto Start;
            }
        
        
        
        
        
        
            if (c == 3)
            {
                Console.WriteLine($"Результат умножения: {a} * {b} = " + (a * b));
                goto Start;
            }
        
        
       
        
        
        
            if (c == 4)
            {
                Console.WriteLine($"Результат деления: {a} / {b} = " + (a / b));
                goto Start;
            }
        
        
       
        
        
        
            if (c == 5)
            {
                Console.WriteLine("Введите степень");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Первое число");
                Console.WriteLine($"Результат возведения в степень: {a} ** {N} = " + Math.Pow(a , N));
                Console.WriteLine("Второе число");
                Console.WriteLine($"Результат возведения в степень: {b} ** {N} = " + Math.Pow(b , N));
                goto Start;
            }
        
        
       
        
        
        
            if (c == 6)
            {
                Console.WriteLine("Первое число");
                Console.WriteLine($"Результат вычисления квадратного корня: /a/ = " + Math.Sqrt(a));
                Console.WriteLine("Второе число");
                Console.WriteLine($"Результат вычисления квадратного корня: /b/ = " + Math.Sqrt(b));
                goto Start;
            }
        
        
       
        
        
        
            if (c == 7)
            {
                Console.WriteLine("Первое число");
                Console.WriteLine($"Нахождение 1% от числа: a%   = " + (a / 100));
                Console.WriteLine("Второе число");
                Console.WriteLine($"Нахождение 1% от числа: b%   = " + (b / 100));
                goto Start;
            }
        
        


        
        
            if (c == 8)
            {







                Console.Write("Введите число : ");
                int e = Convert.ToInt32(Console.ReadLine());
                int factorial = 1;
                for (int i = 1; i <= e; i++)
                {
                    factorial *= i;
                    if (i == e)
                    {
                        Console.Write("{0}", i);
                    }
                    else
                    {
                        Console.Write("{0} * ", i);
                    }
                }
                Console.Write(" = {0}", factorial);
                Console.ReadKey();
                goto Start;





            }
        }
         while (c != 9);




        

        Console.Write("Нажмите клавишу 9 на NumPad чтобы завершить программу... ");
        while (Console.ReadKey().Key != ConsoleKey.NumPad9) { }
    }
}