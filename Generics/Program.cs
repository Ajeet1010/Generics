namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  Generics Problems  -----");
            int[] intArray = { 10, 20, 30, 40, 50, 80 };
            float[] floatArray = { 54.70f, 58.00f, 63.47f, 58.98f, 98.36f, 25.3f };
            double[] doubleArray = { 12.7, 56.8, 89.2, 19.4, 66.5, 56.8 };
            string[] stringArray = { "WHAT", "ARE", "YOU", "DOING" };

            Console.WriteLine("\n\n***** Integer Array  *****");
            MaxGenerics<int> integerobj = new MaxGenerics<int>(intArray);
            integerobj.TestMaximum();

            Console.WriteLine("\n\n***** Double Array  *****");
            MaxGenerics<double> doubleobj = new MaxGenerics<double>(doubleArray);
            doubleobj.TestMaximum();

            Console.WriteLine("\n\n***** String Array  *****");
            MaxGenerics<string> stringobj = new MaxGenerics<string>(stringArray);
            stringobj.TestMaximum();

            Console.WriteLine("\n\n***** Float Array  *****");
            MaxGenerics<float> floatobj = new MaxGenerics<float>(floatArray);
            floatobj.TestMaximum();

        }
    }
}