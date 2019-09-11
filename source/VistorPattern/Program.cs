using System;

namespace VistorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new Document();
            var plainText = new PlainText {Text = "This is  plain text"};
            var boldText = new BoldText{Text = "This is bold text"};
            document.AddDocumentPart(plainText);
            document.AddDocumentPart(boldText);

            var htmlVisitor = new HtmlVisitor();
            document.Accept(htmlVisitor);

            Console.WriteLine("HTML:" );
            Console.WriteLine(htmlVisitor.Output);
            
        }
    }
}
