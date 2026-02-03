namespace G_NET_29_CS03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            double d = 9.99;
            int x = (int)d;
            Console.WriteLine(x);
            // Output: 9
            // Casting from double to int removes the fractional part
            #endregion

            #region Q2
            int n = 5;
            double d2 = n / 2.0;
            Console.WriteLine(d2);
            // Output: 2.5
            // Using a double forces floating-point division
            #endregion

            #region Q3
            int age = int.Parse(Console.ReadLine()!);
            // ReadLine returns string, Parse converts it to int
            #endregion

            #region Q4
            string s4 = "12a";
            // int.Parse(s4);
            // Throws FormatException because the string is not a valid number
            #endregion

            #region Q5
            string s5 = "12a";
            if (int.TryParse(s5, out int x5))
                Console.WriteLine(x5);
            else
                Console.WriteLine("Invalid");
            // TryParse avoids exceptions and returns false on failure
            #endregion

            #region Q6
            object o6 = 10;
            int a = (int)o6;
            Console.WriteLine(a + 1);
            // Output: 11
            // Unboxing from object to int
            #endregion

            #region Q7
            object o7 = 10;
            // long x7 = (long)o7; wrong
            long x7 = (long)(int)o7;
            Console.WriteLine(x7);
            // Must unbox as int first, then widen to long
            #endregion

            #region Q8
            object o8 = 10;
            long x8 = o8 is int i ? i : -1;
            Console.WriteLine(x8);
            // Pattern matching prevents exceptions
            #endregion

            #region Q9
            string? name = null;
            Console.WriteLine(name?.Length);
            // Output: null
            // Null-conditional operator prevents NullReferenceException
            #endregion

            #region Q10
            string? name2 = null;
            int length = name2?.Length ?? 0;
            Console.WriteLine(length);
            // Output: 0
            // Null-coalescing operator provides a default value
            #endregion
        }
    }
}
