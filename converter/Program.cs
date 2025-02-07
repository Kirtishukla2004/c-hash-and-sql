using System;

namespace ConverterApp
{
    class ConverterClass
    {
        public void Convertmethod()
        {
            Console.WriteLine("Enter an integer value:");
            string inputVal = Console.ReadLine();

            try
            {
                int intVal = int.Parse(inputVal);
                Console.WriteLine("Using int.Parse: " + intVal);
            }
            catch (Exception e)
            {
                Console.WriteLine("int.Parse failed: " + e.Message);
            }

            try
            {
                int intValue2 = Convert.ToInt32(inputVal);
                Console.WriteLine("Using Convert.ToInt32: " + intValue2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Convert.ToInt32 failed: " + ex.Message);
            }

            if (int.TryParse(inputVal, out int intValue3))
            {
                Console.WriteLine("Using int.TryParse: " + intValue3);
            }
            else
            {
                Console.WriteLine("int.TryParse failed.");
            }

            Console.WriteLine("Enter a float value:");
            string floatInput = Console.ReadLine();
            DecimalConverter(floatInput);
        }

        public void DecimalConverter(string floatInput)
        {
            try
            {
                float floatValue1 = float.Parse(floatInput);
                Console.WriteLine("Using float.Parse: " + floatValue1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("float.Parse failed: " + ex.Message);
            }

            try
            {
                float floatValue2 = Convert.ToSingle(floatInput);
                Console.WriteLine("Using Convert.ToSingle: " + floatValue2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Convert.ToSingle failed: " + ex.Message);
            }

            if (float.TryParse(floatInput, out float floatValue3))
            {
                Console.WriteLine("Using float.TryParse: " + floatValue3);
            }
            else
            {
                Console.WriteLine("float.TryParse failed.");
            }

            Console.WriteLine("Enter a boolean value:");
            string boolInput = Console.ReadLine();
            BoolConverter(boolInput);
        }

        public void BoolConverter(string boolInput)
        {
            try
            {
                bool boolValue1 = bool.Parse(boolInput);
                Console.WriteLine("Using bool.Parse: " + boolValue1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("bool.Parse failed: " + ex.Message);
            }

            try
            {
                bool boolValue2 = Convert.ToBoolean(boolInput);
                Console.WriteLine("Using Convert.ToBoolean: " + boolValue2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Convert.ToBoolean failed: " + ex.Message);
            }

            if (bool.TryParse(boolInput, out bool boolValue3))
            {
                Console.WriteLine("Using bool.TryParse: " + boolValue3);
            }
            else
            {
                Console.WriteLine("bool.TryParse failed.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConverterClass converter = new ConverterClass();
            converter.Convertmethod();
        }
    }
}
