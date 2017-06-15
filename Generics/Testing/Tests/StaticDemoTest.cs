using System;
using Generics.StaticMembers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing.Tests
{
    [TestClass]
    public class StaticDemoTest
    {
        [TestMethod]
        public void StaticClassTest()
        {
            StaticClass<int>.Print(45);

        }

        [TestMethod]
        public void StaticMemberTest()
        {
            StaticMember<int>.x = 4;
            StaticMember<int>.x = 8;
            StaticMember<string>.x = 5;
            Console.WriteLine(StaticMember<int>.x);
            Console.WriteLine(StaticMember<string>.x);


        }
    }
}
