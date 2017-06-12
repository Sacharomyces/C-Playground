using System;
using System.Text;
using System.Collections.Generic;
using Generics.DocumentManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing.Tests
{
    
    [TestClass]
    public class DocumentManagerTest
    {

        [TestMethod]
        public void TestMethod()
        {
            var dm = new DocumentManager<Document>();
            dm.AddDocument(new Document("tytuł1","content1"));
            dm.AddDocument(new Document("tytuł2","content2"));

            dm.DisplayAllDocuments();
        }
    }
}
