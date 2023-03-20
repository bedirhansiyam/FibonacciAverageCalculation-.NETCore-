namespace FibonacciAverageCalculation;
class Program
{
    static void Main(string[] args)
    {
        bool result;
        int n;
        decimal average;

        Console.Write("Please enter the length of the Fibonacci series you want to calculate average : ");
        do
        {
            result = int.TryParse(Console.ReadLine(), out n);

            if(result == false || n < 1)
                Console.Write("Please enter a positive number : ");

        }while(result == false || n < 1);
        
        int[] fibonacci = new int[n];

        if(n == 1 || n == 2)
            average = 1;
        else
        {            
            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for(int i = 2; i<n; i++)
            {
                fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
            }

            average = Convert.ToDecimal(fibonacci.Sum()) / Convert.ToDecimal(n);
        }

        Console.WriteLine("");
        Console.WriteLine("The average of Fibonacci series = " + Math.Round(average,6));
    }
}
