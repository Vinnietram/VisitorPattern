namespace VistorPattern
{
    public abstract class DocumentPart
    {
        public string Text { get; set; }

        public abstract void Accept(IVisitor vistor);
    }
}
