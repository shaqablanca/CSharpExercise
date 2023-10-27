
class Program
{ 

    public static void Main(string[] args)
    {
        string num = "576";
        int[] change = { 8,9,5,2,3,9,8,3,9 };

        var result = MaxNum(num, change);

        Console.WriteLine(result);

    }


    public static string MaxNum(string num, int[] change)
    {
        char[] numArray = num.ToCharArray();
        bool changed = false;

        for (int i = 0; i < numArray.Length; i++)
        {
            int digit = numArray[i] - '0'; // Convert the character to an integer

            if (change[digit] >= digit)
            {
                numArray[i] = (char)(change[digit] + '0');
                changed = true;
            }
            else if (changed)
            {
                break; // Stop if we've already made a change, and the new digit is smaller
            }
        }

        return new string(numArray);
    }
}