using System;

namespace Session03Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            var input = Console.ReadLine();
            var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            double?[] numberArray = new double?[inputArray.Length];
            int lowestAge;
            int highestAge;
            double sumAge;
            double averAge;
            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    try
            //    {
            //        numberArray[i] = Convert.ToDouble(inputArray[i]);
            //    }
            //    catch(Exception)
            //    {
            //        numberArray[i] = 0;
            //    }
            //}

            for (int i = 0; i < inputArray.Length; i++)
            {
                bool parsed = double.TryParse(inputArray[i]), out double parsedValue);

            if (parsed == true)
            {
                numberArray[i] = parsedValue;
            }
            else
            {
                numberArray[i] = null;
            }


            foreach (var number in numberArray)
            {
                Console.WriteLine("Värdet är: " + number.ToString());
            }
        

        }
    }
}
