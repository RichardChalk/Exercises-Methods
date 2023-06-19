namespace Exercises_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Write and call a method that greets the user with a Console.WriteLine().
            // GreetUser();

            // 2. Write and call a method that returns the sum of two integer parameters.
            //int a = 5;
            //int b = 3;
            //int sum = AddNumbers(a, b);
            //Console.WriteLine("The sum of {0} and {1} is {2}.", a, b, sum);

            // 3. Write and call a method that returns the area of a circle.
            //double radius = 5.0;
            //double area = CalculateArea(radius);
            //Console.WriteLine("The area of the circle with radius {0} is {1}.", radius, area.ToString("F2"));

            // 4. Write and call a method that checks if a number is even.
            //int number = 7;
            //bool isEven = IsEven(number);
            //Console.WriteLine("{0} is {1}.", number, isEven ? "even" : "odd");

            // 5.Write and call a method that checks which of two numbers is larger.
            //int a = 10;
            //int b = 7;
            //int max = GetMax(a, b);
            //Console.WriteLine("The maximum of {0} and {1} is {2}.", a, b, max);

            // 6. Write a program that checks if a word is a palindrome.
            //string input = "madam";
            //bool isPalindrome = CheckPalindrome(input);
            //Console.WriteLine("{0} is {1} palindrome.", input, isPalindrome ? "a" : "not a");

            // 7.Write a program that calculates the sum of an array.
            //int[] numbers = { 2, 4, 6, 8, 10 };
            //int sum = CalculateArraySum(numbers);
            //Console.WriteLine("The sum of the array elements is {0}.", sum);

            // 8. Write a program that sorts an array.
            //int[] numbers = { 5, 2, 8, 1, 9 };
            //SortArray(numbers);
            //Console.WriteLine("Sorted array: {0}", string.Join(", ", numbers));

            // 9. Write a program that calculates the average of an array.
            //int[] numbers = { 5, 10, 15, 20, 25 };
            //double average = CalculateAverage(numbers);
            //Console.WriteLine("The average of the array elements is {0}.", average);

            int baseNumber = 2;
            int exponent = 5;
            int result = CalculatePower(baseNumber, exponent);
            Console.WriteLine("{0} raised to the power of {1} is {2}.", baseNumber, exponent, result);
        }

        static void GreetUser()
        {
            Console.WriteLine("Hello, user! Welcome to the program.");
        }

        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        static int GetMax(int num1, int num2)
        {
            return Math.Max(num1, num2);
            
            // Using ternary operator
            // return num1 > num2 ? num1 : num2;
        }

        static bool CheckPalindrome(string input)
        {
            string reversed = ReverseString(input);
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static int CalculateArraySum(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }

        static void SortArray(int[] arr)
        {
            Array.Sort(arr);
        }

        static double CalculateAverage(int[] arr)
        {
            int sum = CalculateMyArraySum(arr);
            return (double)sum / arr.Length;
        }

        static int CalculateMyArraySum(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }

        static int CalculatePower(int num, int exp)
        {
            int result = 1;
            for (int i = 1; i <= exp; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}