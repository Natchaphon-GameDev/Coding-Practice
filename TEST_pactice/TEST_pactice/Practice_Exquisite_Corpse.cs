using System;

namespace TEST_pactice
{
    public class Practice_Exquisite_Corpse
    {
        private static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        private static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        private static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        private static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        private static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        private static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        private static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        private static void MonsterBody()
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

        /* create a method called BuildACreature() that has three string parameters, each representing the different parts
        of the body (head, body, and feet). */
        public static void BuildACreature(string head, string body, string feet)
        {
            /* In the BuildACreature() method, create three switch statements. Each switch statement should use the value
            of a parameter and the cases should call the creature methods. */
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
        public static void RandomMode()
        {
            //Create an instance and new Random object
            var randomNumber = new Random();

            /* Since there are three things we want to randomly select, we’ll want to call the Next() method three times,
            each time saving it to a new variable. In total, there should be three variables with a random value, one
            of the head, body, and feet. */
            var randomHead = randomNumber.Next(1, 4); //Random 1-3
            var randomBody = randomNumber.Next(1, 4); //if randomNumber.Next(4); Random 0-3
            var randomFeet = randomNumber.Next(1, 4);

            //Call the SwitchCase() method after the int variable definitions.
            SwitchCase(randomHead, randomBody, randomFeet);
        }

        /* To start refactoring our code, we’ll create a new custom method to store our switch statement. Call this method
        SwitchCase() and give it int parameters named head, body, and feet. */
        private static void SwitchCase(int head, int body, int feet)
        {
            //Now, inside of the SwitchCase(), write three switch statements that use the parameter integer values to call the different creature methods.
            switch (head)
            {
                case 1:
                    MonsterHead();
                    break;
                case 2:
                    GhostHead();
                    break;
                case 3:
                    BugHead();
                    break;
            }

            switch (body)
            {
                case 1:
                    MonsterBody();
                    break;
                case 2:
                    GhostBody();
                    break;
                case 3:
                    BugBody();
                    break;
            }

            switch (feet)
            {
                case 1:
                    MonsterFeet();
                    break;
                case 2:
                    GhostFeet();
                    break;
                case 3:
                    BugFeet();
                    break;
            }
        }

        /* Now that we have the switch statement in the method, we want to reuse it in the BuildACreature() method. But we’ve
        got one big problem. The BuildACreature() method takes a string type as parameters, but the SwitchCase() 
        function takes an int type. */
        //create a new method called TranslateToNumber() that takes in creature as a string parameter.
        public static void TranslateToNumber()
        {
            
        }
    }
}