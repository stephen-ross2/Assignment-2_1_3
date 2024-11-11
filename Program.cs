namespace Assignment_2_1_3
{
        class Maths
        {
            public static int AddInts(int num1, int num2)
            {
                return num1 + num2;
            }

            public static decimal AddDecimals(decimal num1, decimal num2, decimal num3)
            {
                return num1 + num2 + num3;
            }

        public static float Multiply2Floats(float num1,float num2)
        {
            return num1 * num2;
        }

            public static float Multiply3Floats(float num1, float num2, float num3)
            {
                return num1 * num2 * num3;
            }
        public static int AddArray(int[] inputs)
        {
            int result = 0;
            foreach (int input in inputs)
            {
                result += input;
            }
            return result;
        }
        
        }

    class Program

    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Add two integers");
                Console.WriteLine("2. Add three decimals");
                Console.WriteLine("3. Multiply two floats");
                Console.WriteLine("4. Multiply three floats");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter your choice (1-5):");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Add two integers
                        Console.Write("Enter first integer: ");
                        int int1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second integer: ");
                        int int2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Result: {Maths.AddInts(int1, int2)}");
                        Console.WriteLine();
                        break;

                    case 2:
                        // Add three decimals
                        Console.Write("Enter first decimal: ");
                        decimal dec1 = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter second decimal: ");
                        decimal dec2 = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter third decimal: ");
                        decimal dec3 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine($"Result: {Maths.AddDecimals(dec1, dec2, dec3)}");
                        Console.WriteLine();
                        break;

                    case 3:
                        // Multiply two floats
                        Console.Write("Enter first float: ");
                        float float1 = float.Parse(Console.ReadLine());
                        Console.Write("Enter second float: ");
                        float float2 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Result: {Maths.Multiply2Floats(float1, float2)}");
                        Console.WriteLine();
                        break;

                    case 4:
                        // Multiply three floats
                        Console.Write("Enter first float: ");
                        float f1 = float.Parse(Console.ReadLine());
                        Console.Write("Enter second float: ");
                        float f2 = float.Parse(Console.ReadLine());
                        Console.Write("Enter third float: ");
                        float f3 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Result: {Maths.Multiply3Floats(f1, f2, f3)}");
                        Console.WriteLine();
                        break;

                    case 5:
                        // Exit the program
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
  

    
}
