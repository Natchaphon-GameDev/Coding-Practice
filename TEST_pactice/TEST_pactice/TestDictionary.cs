using System;
using System.Collections.Generic;

namespace TEST_pactice
{
    public class TestDictionary
    {
        public static void  Dictionary_Declare()
        {
            var phonePrices = new Dictionary<string, string>();
            phonePrices.Add("Sumsung","300");
            phonePrices.Add("IPhone","400");
            phonePrices.Add("LG","500");
            if (phonePrices.ContainsKey("LG"))
            {
                Console.WriteLine($"The Price of {phonePrices["LG"]}");
            }
            
        }

        public override string ToString()
        {
            Dictionary_Declare();
            return $"The ";
        }
    }
}