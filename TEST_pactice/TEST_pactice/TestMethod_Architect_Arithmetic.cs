using System;

namespace TEST_pactice
{
    public class TestMethod_Architect_Arithmetic
    {
        private const int costOfMaterial = 180; // const used to declare a constant value
        public static void TestArray_Teotihuacan_Mexico()
        {
            //Problem : Find the area of the floor plan of Teotihuacan_Mexico On paper in the Folder:PaperFor_Architect_Arithmetic
            //and calculate the area of each part.

            var totalArea = RectangleFormular(2500, 1500) + (CircleFormular(375) / 2) + TriangleFormular(750, 500);
            //Problem : Multiply the total area by the cost of flooring material – 180 Mexican pesos

            Console.WriteLine($"The Teotihuacan plan costs {Math.Round(totalArea * costOfMaterial,2)} pesos");
            //Math.Round used to Rounds a value to the nearest integer or to the specified number of fractional digits.
        }
        
        //Problem : For an extra challenge, try these additions
        //Problem : Determine the total cost for the Taj Mahal,India and the Al-Masjid,Saudi Arabia On paper in the Folder:PaperFor_Architect_Arithmetic

        public static void TestArray_TajMahal_India()
        {
            var totalArea = RectangleFormular(90.5, 90.5) - (TriangleFormular(24, 24) * 4);
            
            Console.WriteLine($"The Taj Mahal plan costs {Math.Round(totalArea * costOfMaterial,2)} pesos");
        }
        
        public static void TestArray_GreatMosque_SaudiArabia()
        {
            var totalArea = RectangleFormular(200,284) - TriangleFormular(84,264) + RectangleFormular(180,106);
            
            Console.WriteLine($"The Taj Mahal plan costs {Math.Round(totalArea * costOfMaterial,2)} pesos");
        }
        
        //Problem : Use conditional statements and to allow users to pick which monument for which they’d like to calculate a cost.

        public static void ChoosePlace()
        {         
            Console.WriteLine("***************************************");
            Console.WriteLine("Press 1 to Choose Teotihuacan_Mexico");
            Console.WriteLine("Press 2 to Choose TajMahal_India");
            Console.WriteLine("Press 3 to Choose GreatMosque_SaudiArabia");
            Console.WriteLine("***************************************");
            Console.Write("Please Choose The Monument you want to calculate costs : ");
            var monument = Console.ReadLine();
            double totalArea;
            switch (monument)
            {
                
                case "1":
                    TestArray_Teotihuacan_Mexico();
                    break;
                case "2":
                    TestArray_TajMahal_India();
                    break;
                case "3":
                    TestArray_GreatMosque_SaudiArabia();
                    break;
                default:
                    Console.WriteLine("You didn't follow the introduction");
                    return;
            }

        }
        private static double RectangleFormular(double length, double width)
        {
            return length * width;
        }
        
        private static double CircleFormular(double radius)
        {
            //const double pi = 3.14; another way to declare a constant value
            return Math.PI * Math.Pow(radius,2);
            // Math.PI() to represent PI value | Math.Pow() to Power(ยกกำลัง) the value 
        }
        
        private static double TriangleFormular(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
    }
}