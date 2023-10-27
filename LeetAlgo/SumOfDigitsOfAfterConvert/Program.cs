

class Program
{ 

    public static void Main(string[] args)
    {
        string st = "iiii";
        int tur = 1;

        var result = SumOfDigits(st, tur);

        Console.WriteLine(result);
    
    
    }

    public static int SumOfDigits(string s, int k)
    {
        
        string converted = string.Join("", s.Select(c => (c - 'a' + 1).ToString())); // Convert the string to an integer by replacing characters with their positions in the alphabet

       
        for (int i = 0; i < k; i++)
        {
            int sum = 0;
            foreach (char c in converted)
            {
                sum += c - '0'; // Convert the character to an integer and add it to the sum
            }
            converted = sum.ToString(); // Update the converted string with the new sum
        }

        return int.Parse(converted);
    }

}