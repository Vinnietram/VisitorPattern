namespace VistorPattern
{
    public class PlainText : DocumentPart
    {
        public override void Accept(IVisitor vistor)
        {
            vistor.Visit(this);
        }
    }
}