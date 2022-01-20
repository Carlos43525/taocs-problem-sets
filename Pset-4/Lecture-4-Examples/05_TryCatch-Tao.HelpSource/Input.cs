using System;
using System.Globalization;

namespace Tao.Help
{
    /// <summary>
    /// This class is dedicated to parsing user inputs from the terminal. 
    /// The idea is to cut down on student code length and increase focus 
    /// on current concepts. This is achieved by abstracting a few commonly 
    /// used operations, such as retreiving an integer from the terminal, 
    /// and allowing focus to be put elsewhere. 
    /// Finally, it should be noted that these functions are not exhaustive, 
    /// only catching the bare minimum of errors, such as null. 
    /// </summary>
    public static class Input
    {
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        /// <summary>
        /// Prompts user for a line of text and returns the equivalent int
        /// Loops if input is not a valid float and within range of ±1.5 x 10−45 to ±3.4 x 1038
        /// </summary>
        public static float GetFloat(string s)
        {
            float output;
            string? input;

            do
            {
                Console.WriteLine(s);
                input = Console.ReadLine();
            }
            while (!ValidateFloatingPoint(input, out output));

            return output;
        }

        /// <summary>
        /// Prompts user for a line of text and returns the equivalent int
        /// Loops if input is not a valid double and within range of ±5.0 × 10−324 to ±1.7 × 10308
        /// </summary>
        public static double GetDouble(string s)
        {
            double output;

            string? input;

            do
            {
                Console.WriteLine(s);
                input = Console.ReadLine();
            }
            while (!ValidateFloatingPoint(input, out output));

            return output;
        }

        /// <summary>
        /// Prompts user for a line of text and returns the equivalent int
        /// Loops if input is not a valid integer and within range of -2^31 to 2^31 - 1
        /// </summary>
        public static int GetInt(string? s) 
        {
            int output;
            string? input;

            do
            {
                Console.WriteLine(s);
                input = Console.ReadLine();
            }
            while (!Int32.TryParse(input, out output));

            return output;
        }


        /// <summary>
        /// Method that accepts a string input, usually string[] args, 
        /// instead of a user prompt. Returns type int on success, exits 
        /// program on fail. Also accepts a custom error message. 
        /// </summary>
        public static int GetIntFromString(string? s, string err = "Invalid integer")
        {
            int output;

            if (!Int32.TryParse(s, out output))
            {
                Console.WriteLine(err);
                Environment.Exit(-1);
            }
            return output;
        }

        /// <summary>
        /// Prompts user for a line of text and returns the equivalent int
        /// Loops if input is not a valid integer and within range of -2^63 to 2^63 - 1
        /// </summary>
        public static long GetLong(string s)
        {
            long output;
            string? input;

            do
            {
                Console.WriteLine(s);
                input = Console.ReadLine();
            }
            while (!Int64.TryParse(input, out output));

            return output;
        }

        /// <summary>
        /// Single.TryParse and Single.Parse
        /// </summary>

        // Default implimentation
        internal static bool ValidateFloatingPoint(string? input, out float output)
        {
            if (input == null)
            {
                output = 0f;
                return false;
            }

            try
            {
                output = Single.Parse(input, NumberStyles.AllowDecimalPoint);

                // IEEE standards dictate that Parse() and TryParse() must return ±∞ or NaN.
                // This checks for subnormal floating point numbers effectivley
                // enough here to prevent the terminal from returning ∞ or NaN.
                if (Single.IsInfinity(output) || Single.IsNaN(output))
                {
                    return false;
                }
                return true;
            }
            catch (Exception) // IndexOutofRangeExcepetion // DivideByZeroException // OverFlowExcepetion
            {
                output = 0f;
                return false;
            }
        }

        // Method overload for doubles
        internal static bool ValidateFloatingPoint(string? input, out double output)
        {
            if (input == null)
            {
                output = 0;
                return false;
            }

            try
            {
                output = Double.Parse(input, NumberStyles.AllowDecimalPoint);

                // IEEE standards dictate that Parse() and TryParse() must return ±∞ or NaN.
                // double.IsNormal() did not work here for displaying proper output. This
                // workaround suitably prevents terminal from displaying ∞ or NaN. 
                if (double.IsInfinity(output) || double.IsNaN(output))
                {
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                output = 0;
                return false;
            }
        }
    }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
}