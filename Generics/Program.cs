namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  Generics Problems  -----");
            Console.WriteLine("Please enter all the string lines ");
            Console.Write("First string: ");
            string Line1  = Console.ReadLine();
            Console.Write("Second string: ");
            string Line2 = Console.ReadLine();
            Console.Write("Third string: ");
            string Line3 = Console.ReadLine();
            Maximum maximum = new Maximum();
            string maxstring = Maximum.String(Line1, Line2, Line3);
            Console.WriteLine("{0} is the maximum number\n at position no {1}", maxstring);
        }
    }
}