namespace FizzBuzz
{
    using System.Collections.Generic;

    public class FizzBuzzer
    {
        public string[] FizzBuzzFrom1To16()
        {
            var result = new string[16];
            result[0] = "1";
            result[1] = "2";
            result[2] = "Fizz";
            result[3] = "4";
            result[4] = "Buzz";
            result[5] = "Fizz";
            result[6] = "7";
            result[7] = "8";
            result[8] = "Fizz";
            result[9] = "Buzz";
            result[10] = "11";
            result[11] = "Fizz";
            result[12] = "13";
            result[13] = "14";
            result[14] = "FizzBuzz";
            result[15] = "16";
            return result;
        }

        public string[] FizzBuzzInterval(int start, int end)
        {
            var result = new List<string>();
            for (int i = start; i <= end; i++)
            {
                if (IsFizz(i))
                {
                    result.Add("Fizz");
                }
                else if (IsBuzz(i))
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result.ToArray();
        }

        private static bool IsBuzz(int i)
        {
            return i%5 == 0;
        }

        private static bool IsFizz(int i)
        {
            return i%3 == 0;
        }
    }
}