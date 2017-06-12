
using System;
using Generics.LinkedList;
using Generics.LinkedList.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing
{
    [TestClass]
    public class LingedListTestGen
    {
        [TestMethod]
        public void LinkedListGenericTestMethod()
        {
            var listOfInts = new LinkedList<int>();

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