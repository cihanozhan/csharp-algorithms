class Program
{
    static void Main(string[] args)
    {
        var result1 = RemoveDuplicateCharacters("dijibil");
        var result2 = RemoveDuplicateCharacters("cihanözhan");
 
        Console.WriteLine(result1);
        Console.WriteLine(result2);
 
        Console.ReadLine();
    }
 
    static string RemoveDuplicateCharacters(string input)
    {
        string data = "", result = "";
 
        foreach (var val in input)
        {
            if (data.IndexOf(val) == -1)
            {
                data += val;
                result += val;
            }
        }
        return result;
    }
}
