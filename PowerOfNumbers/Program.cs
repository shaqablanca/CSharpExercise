using System;

namespace JumpGame
{
    class PowerOfNumbers
    {

        public int Power(int power, int number)
        {
            int result = 1;
            if (power > 0)
            {
                for (int i = 0; i < power; i++)
                {
                    result *= number;
                }
            }

            else if (power < 0)
            {
                number = 1 / number;
                result *= number;
            }
            else
            {
                result = 1;
            }
            return result;

        }

        static void Main(String[] args)
        {
            PowerOfNumbers sonuc = new PowerOfNumbers();

            Console.WriteLine(sonuc.Power(2, 15));
        }
    }

}