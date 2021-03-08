using System;
using System.Collections.Generic;

namespace TEST_pactice
{
    namespace Test_ListSystem1
    {
        public class Bottle : IEquatable<Bottle>
        {
            public string Name { get; private set; }

            public Bottle(string name)
            {
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }

            public bool Equals(Bottle other)
            {
                return Name == other.Name;
            }

            public static void Show_OutPut()
            {
                var bottles = new List<Bottle>();

                for (var i = 0; i < 5; i++)
                {
                    bottles.Add(new Bottle($"Bottle{i}"));
                }
            
                Console.WriteLine(bottles.Contains(new Bottle("Bottle2"))); //false because It's doesn't same Object (if do not use IEquatable)
                Console.WriteLine(bottles.Exists(bottle => bottle.Name == "Bottle2")); //true 
            }
        }
    }
    
}