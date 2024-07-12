class Proqram
{
    class DocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }
    class ProDocumentProgram : DocumentProgram
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }
        //tapsiriqda sealed class yazilib lakin ExpertDocument toreme zamani saveDocument nece deyise biler
        public sealed override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
    }
    class ExpertDocument : ProDocumentProgram
    {
        //public override void SaveDocument()// burada problem yaranir
        //{
        //    Console.WriteLine("Document Saved in pdf format");
        //}
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Seciminizi daxil edin (basic, pro, expert):");
        string key = Console.ReadLine();
        DocumentProgram docProgram;

        switch (key.ToLower())
        {
            case "pro":
                docProgram = new ProDocumentProgram();
                break;
            case "expert":
                docProgram = new ExpertDocument();
                break;
            default:
                docProgram = new DocumentProgram();
                break;
        }

        docProgram.OpenDocument();
        docProgram.EditDocument();
        docProgram.SaveDocument();
    }
}

