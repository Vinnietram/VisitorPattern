namespace VistorPattern
{
    public class HtmlVisitor : IVisitor
    {
        public string Output { get; private set; }

        public void Visit(PlainText docPart)
        {
            Output += docPart.Text;
        }

        public void Visit(BoldText docPart)
        {
            Output += "<b>" + docPart.Text + "</b>";
        }
    }
}