using System.Collections.Generic;

namespace VistorPattern
{
    public class Document
    {
        private readonly List<DocumentPart> _documentParts;

        public Document()
        {
            _documentParts = new List<DocumentPart>();
        }

        public void AddDocumentPart(DocumentPart documentPart)
        {
            _documentParts.Add(documentPart);
        }
       
        public void Accept(IVisitor visitor)
        {
            _documentParts.ForEach(x => x.Accept(visitor));
        }
    }
}