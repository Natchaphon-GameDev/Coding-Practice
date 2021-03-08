using System;
using System.Collections;
using System.Xml.XPath;

namespace TEST_pactice
{
    public class TestList
    {
        public static void ArrayList_Defind()
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

        public static void ArrayList_AddRange_EntireType_()
        {
            var arrayList1 = new ArrayList();
            var arrayList2 = new ArrayList() {1, "Ball", true, 3.5, null};

            var array = new[] {3, 5, 6, 7};
            
            var myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");
            
            arrayList1.AddRange(arrayList2); //adding arraylist in arraylist 
            arrayList1.AddRange(array); //adding array in arraylist 
            arrayList1.AddRange(myQ); //adding Queue in arraylist 
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);

            }
        }
    }//class
}//namespace