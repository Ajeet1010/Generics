namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  Generics Problems  -----");
            int[] intArray = { 10, 20, 30, 40, 50, 80 };
            float[] floatArray = { 54.70f, 58.00f, 63.47f, 58.98f, 98.36f, 25.3f };
            string[] stringArray = { "WHAT", "ARE", "YOU", "DOING" };
            MaxMethod.Maximum(intArray);
            MaxMethod.Maximum(floatArray);
            MaxMethod.Maximum(stringArray);
        }
    }
}