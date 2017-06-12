using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics.DocumentManager
{
    public class DocumentManager<TDocument>
        where TDocument : IDocument

    {
        public bool IsDocumentAvailable => documentQueue.Count > 0;

        private readonly Queue<TDocument> documentQueue = new Queue<TDocument>();

        public void AddDocument(TDocument doc)
        {
            lock (this)
            {
                documentQueue.Enqueue(doc);
            }
        }

        public TDocument GetDocument()
        {
            TDocument doc = default(TDocument);

            lock (this)
            {
                doc = documentQueue.Dequeue();
            }
            return doc;
        }

        public void DisplayAllDocuments()
        {
            if (IsDocumentAvailable)
            {
                foreach (TDocument doc in documentQueue)
                {
                    Console.WriteLine($"Tytuł: {doc.Title} Content: {doc.Content}");


                }

            }
        }
    }
}
