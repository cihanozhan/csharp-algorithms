class Program
{
    static void Main(string[] args)
    {
        var result = Count("eskiden buralar hep ayvalıktı");
 
        Console.WriteLine(result);
    }
 
    public static int Count(string x)
    {
        int result = 0;
         
        x = x.Trim();
         
        if (x == "")
        {
            return 0;
        }
         
        while (x.Contains("  "))
        {
            x = x.Replace("  ", " ");
        }
         
        foreach (string z in x.Split(' '))
        {
            result++;
        }
 
        return result;
    }
}
