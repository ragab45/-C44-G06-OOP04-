namespace Demo
{
    internal class Program
    {

        #region  V-1
        //public static int SumNumbers(int x, int y, int z)
        //{
        //    return x + y + z;
        //}

        //// Overloaded SumNumbers function accepting two doubles and returning their sum
        //public static double SumNumbers(double x, double y)
        //{
        //    return x + y;
        //}

        //// ADDED THIS FUNCTION to correctly handle the call in Main
        //// Overloaded SumNumbers function accepting two integers and returning their sum
        //public static int SumNumbers(int x, int y)
        //{
        //    return x + y;
        //}

        //static void Main(string[] args)
        //{
        //    #region Method Overloading

        //    // This was the part causing an error in your original code
        //    int A = 10;
        //    int B = 20;
        //    int result = SumNumbers(A, B); // Now this will correctly call the new SumNumbers(int, int)
        //    Console.WriteLine($"Result of SumNumbers(int, int): {result}");

        //    Console.WriteLine("\n-------------------\n");

        //    // Example of calling the double version
        //    double A_double = 10.5;
        //    double B_double = 20.3;
        //    double result_double = SumNumbers(A_double, B_double);
        //    Console.WriteLine($"Result of SumNumbers(double, double): {result_double}");

        //    Console.WriteLine("\n-------------------\n");

        //    // Example of calling the three-integer version
        //    int X_int = 5;
        //    int Y_int = 10;
        //    int Z_int = 15;
        //    int result_int = SumNumbers(X_int, Y_int, Z_int);
        //    Console.WriteLine($"Result of SumNumbers(int, int, int): {result_int}");

        #endregion
        //#endregion
        #region  V-2
        public class Complex
        {
            public int Real { get; set; }
            public int Img { get; set; }

            public override string ToString()
            {
                return $"{Real} + {Img}i";
            }

            public static Complex operator +(Complex Left, Complex Right)
            {
                return new Complex
                {
                    Real = Left.Real + Right.Real,
                    Img = Left.Img + Right.Img,
                };
            }
        }
        #endregion

    }
    
}
