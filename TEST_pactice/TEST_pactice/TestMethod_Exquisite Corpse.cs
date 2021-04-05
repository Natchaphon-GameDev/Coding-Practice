using System;
namespace TEST_pactice
{
    public class TestMethod_Exquisite_Corpse
    {
        public static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        public static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        public static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        public static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        public static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        public static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        public static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        public static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        public static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
        
        //create a method called BuildACreature() that has three string parameters, each representing the different parts of the body (head, body, and feet).
        public static void BuildACreature(string head, string body, string feet)
        {
            //In the BuildACreature() method, create three switch statements. Each switch statement should use the value of a parameter and the cases should call the creature methods.
            switch (head.ToLower())
            {
                case "monster":
                    MonsterHead();
                    break;
                case "ghost":
                    GhostHead();
                    break;
                case "bug":
                    BugHead();
                    break;
            }

            switch (body.ToLower())
            {
                case "monster":
                    MonsterBody();
                    break;
                case "ghost":
                    GhostBody();
                    break;
                case "bug":
                    BugBody();
                    break;
            }

            switch (feet.ToLower())
            {
                case "monster":
                    MonsterFeet();
                    break;
                case "ghost":
                    GhostFeet();
                    break;
                case "bug":
                    BugFeet();
                    break;
            }
            
        }
        //Start by creating a custom method named RandomMode()
        private void RandomMode()
        {
            //Create an instance and new Random object by adding the following line of code to the program
            
        }
    }
}