
    // static int EvenCount(int n)
    // {
    //     int count = 0;
    //     while (n > 0)
    //     {
    //         int digit = n % 10;
    //         if (digit % 2 == 0)
    //             count++;
    //         n /= 10;
    //     }
    //     return count;
    // }

    // static int OddCount(int n)
    // {
    //     int count = 0;
    //     while (n > 0)
    //     {
    //         int digit = n % 10;
    //         if (digit % 2 != 0)
    //             count++;
    //         n /= 10;
    //     }
    //     return count;
    // }

    // static int ZeroCount(int n)
    // {
    //     int count = 0;
    //     while (n > 0)
    //     {
    //         int digit = n % 10;
    //         if (digit == 0)
    //             count++;
    //         n /= 10;
    //     }
    //     return count;
    // }

    // static int DigitCount(int n)
    // {
    //     int count = 0;
    //     while (n > 0)
    //     {
    //         count++;
    //         n /= 10;
    //     }
    //     return count;
    // }

    // static int MinDigit(int n)
    // {
    //     int minDigit = 9;
    //     while (n > 0)
    //     {
    //         int digit = n % 10;
    //         if (digit < minDigit)
    //             minDigit = digit;
    //         n /= 10;
    //     }
    //     return minDigit;
    // }

    // static int MaxDigit(int n)
    // {
    //     int maxDigit = 0;
    //     while (n > 0)
    //     {
    //         int digit = n % 10;
    //         if (digit > maxDigit)
    //             maxDigit = digit;
    //         n /= 10;
    //     }
    //     return maxDigit;
    // }

    // static int SumDigit(int n)
    // {
    //     int sum = 0;
    //     while (n > 0)
    //     {
    //         sum += n % 10;
    //         n /= 10;
    //     }
    //     return sum;
    // }

    // static void Main(string[] args)
    // {
    //     int n = 12043;

    //     int evenCount = EvenCount(n);
    //     int oddCount = OddCount(n);
    //     int zeroCount = ZeroCount(n);
    //     int digitCount = DigitCount(n);
    //     int minDigit = MinDigit(n);
    //     int maxDigit = MaxDigit(n);
    //     int sumDigit = SumDigit(n);

    //     Console.WriteLine($"Even : {evenCount}");
    //     Console.WriteLine($"Odd : {oddCount}");
    //     Console.WriteLine($"Zeros : {zeroCount}");
    //     Console.WriteLine($"Digits : {digitCount}");
    //     Console.WriteLine($"Min : {minDigit}");
    //     Console.WriteLine($"Max : {maxDigit}");
    //     Console.WriteLine($"Sum of Digits: {sumDigit}");
    // }

// static char CheckGrade(int grade)
// {
//     if (grade >= 90)
//         return 'A';
//     else if (grade >= 80)
//         return 'B';
//     else if (grade >= 70)
//         return 'C';
//     else if (grade >= 60)
//         return 'D';
//     else
//         return 'F';
// }


// int grade = 90;

// char gradeLetter = CheckGrade(grade);
// Console.WriteLine(gradeLetter);



    // static void Main(string[] args)
    // {

    //     int N = int.Parse(Console.ReadLine());
    //     string[] numbers = Console.ReadLine().Split();

    //     int positiveCount = 0, negativeCount = 0, zeroCount = 0;

    //     for (int i = 0; i < N; i++)
    //     {
    //         int n = int.Parse(numbers[i]);
    //         if (n > 0)
    //             positiveCount++;
    //         else if (n < 0)
    //             negativeCount++;
    //         else
    //             zeroCount++;
    //     }

    //     Console.WriteLine($"Negative = {negativeCount}");
    //     Console.WriteLine($"Positive = {positiveCount}");
    //     Console.WriteLine($"Zeros = {zeroCount}");
    // }


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
        
//         int N = int.Parse(Console.ReadLine());
//         string[] input = Console.ReadLine().Split();

        
//         for (int i = 0; i < N; i += 2) 
//         {
//             Console.Write(input[i] + " ");
//         }
//     }
// }


    // static void Main()
    // {
        
    //     int n = int.Parse(Console.ReadLine()); 
    //     int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    //     int count = 0;

    //     for (int i = 1; i < n; i++)
    //     {
    //         if (arr[i] > arr[i - 1])
    //         {
    //             count++;
    //         }
    //     }

    //     Console.WriteLine(count);
    // }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("From = ");
//         int x = int.Parse(Console.ReadLine());
        
//         Console.Write("To = ");
//         int y = int.Parse(Console.ReadLine());
        
//         for (int i = x; i <= y; i++)
//         {

//             for (int j = 1; j <= 10; j++)
//             {
//                 Console.WriteLine($"{i}x{j}= {i * j}");
//             }
//         System.Console.WriteLine(" ");
//         }
//     }
// }

// using System;

// class Program
// {
//     static int Sum(int num1, int num2)
//     {
//         return num1 + num2;
//     }

//     static int Subtract(int num1, int num2)
//     {
//         return num1 - num2;
//     }

//     static int Multiplication(int num1, int num2)
//     {
//         return num1 * num2;
//     }

//     static double Division(int num1, int num2)
//     {
//         if (num2 == 0) 
//         {
//             Console.WriteLine("Error: Division by zero is not allowed.");
//             return double.NaN;
//         }
//         return (double)num1 / num2;
//     }

//     static void Main()
//     {
//         Console.Write("The first number is: ");
//         int num1 = int.Parse(Console.ReadLine());

//         Console.Write("The operation is: ");
//         string operation = Console.ReadLine();

//         Console.Write("The second number is: ");
//         int num2 = int.Parse(Console.ReadLine());

//         double result = 0;

//         if (operation == "+")
//         {
//             result = Sum(num1, num2);
//             Console.WriteLine($"{num1} + {num2} = {result}");
//         }
//         else if (operation == "-")
//         {
//             result = Subtract(num1, num2);
//             Console.WriteLine($"{num1} - {num2} = {result}");
//         }
//         else if (operation == "*")
//         {
//             result = Multiplication(num1, num2);
//             Console.WriteLine($"{num1} * {num2} = {result}");
//         }
//         else if (operation == "/")
//         {
//             result = Division(num1, num2);
//             if (!double.IsNaN(result))
//                 Console.WriteLine($"{num1} / {num2} = {result}");
//         }
//         else
//         {
//             Console.WriteLine("Error: Invalid operation.");
//         }
//     }
// }



    
// static int Power(int baseValue, int exponent)
// {
//     if (exponent == 0)
//     {
//         return 1;
//     }
//     else
//     {
//         return baseValue * Power(baseValue, exponent - 1);
//     }
// }

// Console.Write("Input the base value: ");
// int baseValue = int.Parse(Console.ReadLine());

// Console.Write("Input the exponent: ");
// int exponent = int.Parse(Console.ReadLine());
// int result = Power(baseValue, exponent);
// Console.WriteLine($"The value of {baseValue} to the power of {exponent} is: {result}");


// static int Fibonacci(int n)
// {
//         if (n <= 1)
//         {
//         return n;
//     }
//         else
//         {
//         return Fibonacci(n - 1) + Fibonacci(n - 2);
//     }
// }

// Console.Write("Input number of terms for the Fibonacci series: ");
// int n = int.Parse(Console.ReadLine());

// Console.Write("The Fibonacci series of " + n + " terms is: ");
// for (int i = 0; i < n; i++)
// {
//     Console.Write(Fibonacci(i) + " ");
// }