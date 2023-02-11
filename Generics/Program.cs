namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  Generics Problems  -----");
            Console.WriteLine("Please enter three values to find maximum numbers");
            Console.Write("First no: ");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second no: ");
            int secondValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third no: ");
            int thirdValue = Convert.ToInt32(Console.ReadLine());
            Maximum maximum = new Maximum();
            int output = Maximum.IntegerNo(firstValue, secondValue, thirdValue);
            Console.WriteLine("{0} is the maximum number\n at position no {1}", output, value);
        }
    }
}