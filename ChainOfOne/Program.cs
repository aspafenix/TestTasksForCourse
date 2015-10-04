using System;
using System.IO;
using System.Text;

namespace ChainOfOne
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream input = File.OpenRead(@"INPUT.TXT");
                byte[] inputArray = new byte[input.Length];
                input.Read(inputArray, 0, inputArray.Length);
                string inputSequence = Encoding.Default.GetString(inputArray);
                Console.WriteLine("The sequence of 0 and 1: {0}", inputSequence);
                input.Close();

                int sumOfOnes = SumOfOne(inputArray);

                Console.WriteLine("The longest continuous chain of 1 in the sequence : {0}", sumOfOnes);

                FileStream output = new FileStream(@"OUTPUT.TXT", FileMode.OpenOrCreate);
                byte[] outputArray = Encoding.Default.GetBytes(Convert.ToString(sumOfOnes));
                output.Write(outputArray, 0, outputArray.Length);
                output.Close();
                Console.Write("Press any key to exit ...");
                Console.ReadKey();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File Not Found");
            }
           

        }

        public static int SumOfOne(byte[] arr)
        {
            int maxSumOfOnes = 0;
            int currSumOfOnes = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == 49)
                {
                    maxSumOfOnes = Math.Max(maxSumOfOnes, ++currSumOfOnes);
                }
                else
                {
                    currSumOfOnes = 0;
                }
            }
            return maxSumOfOnes;
        }
    }
}
