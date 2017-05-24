class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Word: ");
            string word1 = Console.ReadLine();
            Console.Write("Second Word: ");
            string word2 = Console.ReadLine();
 
            char[] ch1 = word1.ToLower().ToCharArray();
            char[] ch2 = word2.ToLower().ToCharArray();
 
            Array.Sort(ch1);
            Array.Sort(ch2);
 
            string new1 = new string(ch1);
            string new2 = new string(ch2);
 
            if (new1 == new2)
            {
                Console.WriteLine("\"{0}\" ve \"{1}\" Anagram'dır.", word1, word2);
            }
            else
            {
                Console.WriteLine("\"{0}\" ve \"{1}\" Anagram değildir.", word1, word2);
            }
        }
    }
