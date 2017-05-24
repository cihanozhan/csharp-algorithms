class Program
{
    static void Main(string[] args)
    {
        var str = Reverse("cihan");
        Console.WriteLine(str);
 
        Console.ReadLine();
    }
 
    public static string Reverse(string x)
    {
        string result = "";
        for (int i = x.Length - 1; i >= 0; i--)
        {
            result += x[i];
        }
        return result;
    }
}
