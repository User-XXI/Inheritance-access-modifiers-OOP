class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine( "Document opened" );
    }

    public virtual void EditDocument()
    {
        Console.WriteLine( "Edit Document available in version Pro" );
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine( "Save Document available in version PRO" );
    }
}

class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine( "Document edited" );
    }

    public override void SaveDocument()
    {
        Console.WriteLine( "The document is saved, To select the format, activate the EXP version" );
    }
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine( "The document is saved in the selected format" );
    }
}

class Program
{
    private const string PRO_LICENSE = "PRO";
    private const string EXP_LICENSE = "EXP";

    static void Main( string[] args )
    {
        Console.WriteLine( "Enter license key:" );
        var license = Console.ReadLine();

        DocumentWorker worker;
        switch (license)
        {
            case PRO_LICENSE: worker = new ProDocumentWorker(); break;
            case EXP_LICENSE: worker = new ExpertDocumentWorker(); break;
            default: worker = new DocumentWorker(); break;
        }

        Console.WriteLine( "Enter Command (Open / Edit / Save): " );
        switch (Console.ReadLine())
        {
            case "Open": worker.OpenDocument(); break;
            case "Edit": worker.EditDocument(); break;
            case "Save": worker.SaveDocument(); break;
        }
    }
}