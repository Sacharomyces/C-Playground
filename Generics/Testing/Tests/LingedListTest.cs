using System;
using Generics.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing.Tests
{
    [TestClass]
    public class LingedListTest
    {
        [TestMethod]
        public void LinkedListTestMethod()
        {
            var listOfInts = new LinkedList();

            listOfInts.Add(4);
            listOfInts.Add(2);
            listOfInts.Add(3);
            listOfInts.Add(5);
            listOfInts.Add(6);

            foreach (int number in listOfInts)
            {
                Console.WriteLine(number);
                
            }
            
        }
        
    }
}