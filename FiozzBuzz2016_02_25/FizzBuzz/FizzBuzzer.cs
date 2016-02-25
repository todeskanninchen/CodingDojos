namespace FizzBuzz
{
    using System.Collections.Generic;

    public class FizzBuzzer
    {
        public string[] FizzBuzzInterval(int start, int end)
        {
            var result = new List<string>();
            for (int i = start; i <= end; i++)
            {
                if (IsFizz(i) && IsBuzz(i))
                {
                    result.Add("FizzBuzz");
                }
                else if (IsFizz(i))
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