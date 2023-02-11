namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  Generics Problems  -----");
            Console.WriteLine("Please enter three values to find maximum numbers");
            Console.Write("First no: ");
            float firstValue  = float.Parse(Console.ReadLine());
            Console.Write("Second no: ");
            float secondValue = float.Parse(Console.ReadLine());
            Console.Write("Third no: ");
            float thirdValue = float.Parse(Console.ReadLine());
            Maximum maximum = new Maximum();
            float output = Maximum.FloatNo(firstValue, secondValue, thirdValue);
            Console.WriteLine("{0} is the maximum number\n at position no {1}", output);
        }
    }
}