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
            const int buzzNumber = 5;
            return IsMutipleOf(i, buzzNumber);
        }

        private static bool IsFizz(int i)
        {
            const int fizzNumber = 3;
            return IsMutipleOf(i, fizzNumber) || ContainsDigit(i, fizzNumber);
        }

        private static bool ContainsDigit(int i, int fizzNumber)
        {
            return i.ToString().Contains(fizzNumber.ToString());
        }

        private static bool IsMutipleOf(int i, int fizzNumber)
        {
            return i% fizzNumber == 0;
        }
    }
}