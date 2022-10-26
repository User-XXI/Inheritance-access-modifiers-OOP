public class ClassRoom
{
    public readonly List<Pupil> Pupils = new List<Pupil>();

    public ClassRoom( params Pupil[] pupils )
    {
        Pupils.AddRange( pupils );
    }

    public void GetPupils()
    {
        foreach (var pupil in Pupils)
        {
            pupil.Read();
            pupil.Write();
            pupil.Study();
            pupil.Relax();
            Console.WriteLine( '\n' );
        }
    }

}
public class Pupil
{
    public string PupilName
    {
        get;
        private set;
    }

    public Pupil( string name )
    {
        PupilName = name;
    }

    private string GetPupilNameAndStatus()
    {
        return String.Format( "{0} {1}", GetType().Name, PupilName );
    }

    public virtual void Study()
    {
        Console.WriteLine( "{0} {1}", GetPupilNameAndStatus(), "Studying" );
    }

    public virtual void Read()
    {
        Console.WriteLine( "{0} {1}", GetPupilNameAndStatus(), "Reading" );
    }

    public virtual void Write()
    {
        Console.WriteLine( "{0} {1}", GetPupilNameAndStatus(), "Writting" );
    }
    public virtual void Relax()
    {
        Console.WriteLine( "{0} {1}", GetPupilNameAndStatus(), "Relaxing" );
    }
}

public class ExellentPupil : Pupil
{
    public ExellentPupil( string name ) : base( name )
    { }

    public override void Read()
    {
        Console.WriteLine( "{0} {1} read more than usual pupil", GetType().Name, PupilName );
    }
    public override void Write()
    {
        Console.WriteLine( "{0} {1} write more than usual pupil", GetType().Name, PupilName );
    }
    public override void Study()
    {
        Console.WriteLine( "{0} {1} study more than usual pupil", GetType().Name, PupilName );
    }
    public override void Relax()
    {
        Console.WriteLine( "{0} {1} relax less than usual pupil", GetType().Name, PupilName );
    }
}

public class GoodPupil : Pupil
{
    public GoodPupil( string name ) : base( name )
    { }

    public override void Read()
    {
        Console.WriteLine( "{0} {1} read not more than usual pupil", GetType().Name, PupilName );
    }
    public override void Write()
    {
        Console.WriteLine( "{0} {1} write not more than usual pupil", GetType().Name, PupilName );
    }
    public override void Study()
    {
        Console.WriteLine( "{0} {1} study not more than usual pupil", GetType().Name, PupilName );
    }
    public override void Relax()
    {
        Console.WriteLine( "{0} {1} relax not more than usual pupil", GetType().Name, PupilName );
    }
}

public class BadPupil : Pupil
{
    public BadPupil( string name ) : base( name )
    { }

    public override void Read()
    {
        Console.WriteLine( "{0} {1} read less than usual pupil", GetType().Name, PupilName );
    }
    public override void Write()
    {
        Console.WriteLine( "{0} {1} write less than usual pupil", GetType().Name, PupilName );
    }
    public override void Study()
    {
        Console.WriteLine( "{0} {1} study less than usual pupil", GetType().Name, PupilName );
    }
    public override void Relax()
    {
        Console.WriteLine( "{0} {1} relax more than usual pupil", GetType().Name, PupilName );
    }
}
class Program
{
    static void Main( string[] args )
    {
        Pupil Pupil1 = new Pupil("Alexey");
        Pupil Pupil2 = new BadPupil("Georgy");
        Pupil Pupil3 = new GoodPupil("Mikhail");
        Pupil Pupil4 = new ExellentPupil("Petr");

        var ClassRomm = new ClassRoom(Pupil1,  Pupil4, Pupil2, Pupil3);

        ClassRomm.GetPupils();
    }
}   