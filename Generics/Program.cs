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

            Console.WriteLine("1. Maximum Integer value.\n2. Maximum Float value.\n3. Maximum String in length.\n" +
                "4. Find maximum by taking more than three parameters\n5. Generics\n6. Exit");
            Console.Write("Enter the option to perform:  ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter three values to find maximum numbers");
                    Console.Write("First no: ");
                    int firstValue = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Second no: ");
                    int secondValue = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Third no: ");
                    int thirdValue = Convert.ToInt32(Console.ReadLine());
                    Maximum maximum = new Maximum();
                    int output = Maximum.IntegerNo(firstValue, secondValue, thirdValue);
                    Console.WriteLine("{0} is the maximum number", output);
                    break;

                case 2:
                    Console.WriteLine("Please enter three values to find maximum numbers");
                    Console.Write("First no: ");
                    float f1 = float.Parse(Console.ReadLine());
                    Console.Write("Second no: ");
                    float f2 = float.Parse(Console.ReadLine());
                    Console.Write("Third no: ");
                    float f3 = float.Parse(Console.ReadLine());
                    MaxFloat maxfloat = new MaxFloat();
                    float output1 = MaxFloat.FloatNo(f1, f2, f3);
                    Console.WriteLine("{0} is the maximum number", output1);
                    break;
                    
                case 3:
                    Console.WriteLine("Please enter all the string lines ");
                    Console.Write("First string: ");
                    string Line1 = Console.ReadLine();
                    Console.Write("Second string: ");
                    string Line2 = Console.ReadLine();
                    Console.Write("Third string: ");
                    string Line3 = Console.ReadLine();
                    MaxString maxString = new MaxString();
                    string maxstring = MaxString.String(Line1, Line2, Line3);
                    Console.WriteLine("{0} is the maximum number", maxstring);
                    break;

                case 4:
                    MaxMethod.Maximum(intArray);
                    MaxMethod.Maximum(floatArray);
                    MaxMethod.Maximum(stringArray);
                    break;
                case 5:
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
                    break;
                default:
                    break;
            }   
        }
    }
}