namespace VistorPattern
{
    public interface IVisitor
    {
        void Visit(PlainText docPart);
        void Visit(BoldText docPart);
    }
}