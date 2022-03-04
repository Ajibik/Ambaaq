using System;
namespace Number2
{
    class Program   
    {
        public static void Main(string[] args)
        {
            string T = "the day is sunny the the the sunny is is";
            var splitT = T.Split(' ');
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach(var elements in splitT)
            {
                if(elements != "")   
                {
                    string b = elements;
                    if(dictionary.ContainsKey(b))
                    {
                        dictionary[b] = dictionary[b] + 1;
                    }
                    else
                    {
                        dictionary.Add(b, 1);
                    }
                }  
            }
            //var sort = dictionary.OrderBy(x => x.Value);
            foreach (var item in dictionary)
            {
                System.Console.WriteLine($"{item.Key}\t{item.Value}");
            }
        }
    }
}