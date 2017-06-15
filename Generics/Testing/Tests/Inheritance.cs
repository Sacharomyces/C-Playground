using System;
using Generics.Inheritance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing.Tests
{
    [TestClass]
    public class Inheritance
    {
        [TestMethod]
        public void InheritanceTest()
        {
            NonGenericDerivered<string> der = new NonGenericDerivered<string>();
            der.AddSomething("woo");
            der.AddSomething("foo");
            der.Print();
        }
    }
}
