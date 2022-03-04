using System;
namespace Number2
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool check = true;
            int maxcount = 0;
            string first = "";
            string h = "";
            string m = "";
            string second = "";
            List<string> word = new List<string>(){"a", "ab", "abc", "d", "cd", "bcd", "abcd"};
            for (var i = 0; i < word.Count; i++)
            {
                for (var j = 0; j < word.Count; j++)
                {
                    
                    if (word[i].Length == word[j].Length && i != j)
                    {

                        h = $"{word[i]}{word[j]}";
                        if (word[i].Length> maxcount)
                        {
                            maxcount = word[i].Length;
                            foreach (var item in (h.Distinct()))
                            {
                                m+=item;
                            }
                            if(m.Length != h.Length)
                            {
                               
                                break;
                            }
                            else
                            {
                                first = word[i];
                                second = word[j];
                            }
                        } 
                        m ="";                        
                    }
                } 
                
            }
           
                System.Console.WriteLine(first.Length*second.Length);
            
        }
    }
}
