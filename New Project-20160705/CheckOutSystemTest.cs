// unit test code
using System;
using System.Collections;

namespace CheckOutSystemTest
{
    // Class CheckOutSystemTests for executing all the designed test methods for checking CheckoutSystem
    public class CheckOutSystemTests
    {
        // Executes all the positive and negative test cases for CheckOut System.
        public static void Main()
        {
            CheckOutSystemTests.TestCheckOutSystemPositiveTest1();
            CheckOutSystemTests.TestCheckOutSystemPositiveTest2();
            
            CheckOutSystemTests.TestCheckOutSystemNegativeTest1();
            CheckOutSystemTests.TestCheckOutSystemNegativeTest2();
            CheckOutSystemTests.TestCheckOutSystemNegativeTest3();
        }
        
        // PositiveTest1 - with 1 Apple and 2 Orange
        public static void TestCheckOutSystemPositiveTest1()
        {
             ArrayList OrderItemList = new ArrayList()
            {
                new Item("Orange",2),
                new Item("Apple",1)
            };
        
            int totalbillamount = CheckOutSystem.TotalBillAmount(OrderItemList);
            if(totalbillamount == ((int)ItemList.itemlist["Orange"] * 2) + ((int)ItemList.itemlist["Apple"]*1))
            {
                Console.WriteLine("Test - CheckOutSystemPositiveTest1 Passed");
            }
        }
        
        // PositiveTest2 - with 2 Apple
        public static void TestCheckOutSystemPositiveTest2()
        {
             ArrayList OrderItemList = new ArrayList()
            {
                new Item("Apple",2)
            };
        
            int totalbillamount = CheckOutSystem.TotalBillAmount(OrderItemList);
            if(totalbillamount == ((int)ItemList.itemlist["Apple"]*2))
            {
                Console.WriteLine("Test - CheckOutSystemPositiveTest2 Passed");
            }
        }
        
        
        // NegativeTest1 - with invalid Item Name
        public static void TestCheckOutSystemNegativeTest1()
        {
             ArrayList OrderItemList = new ArrayList()
            {
                new Item("Apple",1),
                new Item("Pineapple",2)
            };
        
            try
            {
                CheckOutSystem.TotalBillAmount(OrderItemList);
            }catch(System.Exception e)
            {
                if(e.Message.Contains("Invalid Item Name"))
                    Console.WriteLine("Test - CheckOutSystemNegativeTest1 Passed");
            }
        }
        
        // NegativeTest2 - with negative Item Quantity
        public static void TestCheckOutSystemNegativeTest2()
        {
             ArrayList OrderItemList = new ArrayList()
            {
                new Item("Apple",1),
                new Item("Orange",-2)
            };
        
            try
            {
                CheckOutSystem.TotalBillAmount(OrderItemList);
            }catch(System.Exception e)
            {
                if(e.Message.Contains("Quantity can't be zero or negative"))
                    Console.WriteLine("Test - CheckOutSystemNegativeTest2 Passed");
            }
        }
        
        // NegativeTest3 - with 0 Apple and 2 Oranges
        public static void TestCheckOutSystemNegativeTest3()
        {
             ArrayList OrderItemList = new ArrayList()
            {
                new Item("Apple",0),
                new Item("Orange",2)
            };
            
            try
            {
                CheckOutSystem.TotalBillAmount(OrderItemList);
            }catch(System.Exception e)
            {
                if(e.Message.Contains("Quantity can't be zero or negative"))
                    Console.WriteLine("Test - CheckOutSystemNegativeTest3 Passed");
            }
            
        }
    }
    
}