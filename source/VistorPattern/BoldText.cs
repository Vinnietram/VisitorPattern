namespace VistorPattern
{
    public class BoldText : DocumentPart
    {
        public override void Accept(IVisitor vistor)
        {
            vistor.Visit(this);
        }
    }
}