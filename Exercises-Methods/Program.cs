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

        }

        static void GreetUser()
        {
            Console.WriteLine("Hello, user! Welcome to the program.");
        }

        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}