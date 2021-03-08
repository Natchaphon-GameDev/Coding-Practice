using System;
using System.Collections;
using System.Xml.XPath;

namespace TEST_pactice
{
    public class TestList
    {
        public static void ArrayList_Test()
        {
            var arrayList = new ArrayList();

            //non strongly type
            arrayList.Add("Natchaphon"); // String
            arrayList.Add(5); //int
            arrayList.Add("Sirisangsawang"); //String
            arrayList.Add(new TestList()); //Obj

            var secondItem = (int) arrayList[1];
            Console.WriteLine($"Result: {secondItem + 3}");

        }
    }//class
}//namespace