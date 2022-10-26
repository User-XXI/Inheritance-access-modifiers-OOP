internal class Vehicle
{
    private double _x = 0;
    private double _y = 0;
    private double price = 0;
    private double speed = 0;
    private double year = 0;

    public double x
    {
        get { return _x; }
        set { _x = value; }
    }

    public double y
    {
        get { return _y; }
        set { _y = value; }
    }

    public void Coordinate( double x, double y )
    {
        this.x = x;
        this.y = y;
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public double Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public double Year
    {
        get { return year; }
        set { year = value; }
    }

    public void SpeedMethod( double Speed )
    {
        this.Speed = Speed;
    }

    public virtual void VehicleInfo()
    {
        Console.WriteLine( "{0}:", GetType().Name );
        Console.WriteLine( "\t Coordinate: ({0}; {1})", x, y );
        Console.WriteLine( "\t Price: {0}", Price );
        Console.WriteLine( "\t Speed: {0}", Speed );
        Console.WriteLine( "\t Year: {0}", Year );
        Console.WriteLine( "\n" );
    }

}

class Plane : Vehicle
{
    public double Height { get; set; }
    public double Passengers { get; set; }

    public double z { get; set; }

    public void Coordinate( double x, double y, double z )
    {
        base.Coordinate( x, y );
        this.z = z;
    }
    public override void VehicleInfo()
    {
        Console.WriteLine( "{0}:", GetType().Name );
        Console.WriteLine( "\t Coordinate: ({0}; {1}; {2})", x, y, z );
        Console.WriteLine( "\t Price: {0}", Price );
        Console.WriteLine( "\t Speed: {0}", Speed );
        Console.WriteLine( "\t Year: {0}", Year );
        Console.WriteLine( "\t Height: {0}", Height );
        Console.WriteLine( "\t Passengers: {0}", Passengers );
        Console.WriteLine( "\n" );
    }
}

class Ship : Vehicle
{
    public double Passengers { get; set; }
    public string Port { get; set; }
    public override void VehicleInfo()
    {
        Console.WriteLine( "{0}:", GetType().Name );
        Console.WriteLine( "\t Coordinate: ({0}; {1})", x, y );
        Console.WriteLine( "\t Price: {0}", Price );
        Console.WriteLine( "\t Speed: {0}", Speed );
        Console.WriteLine( "\t Year: {0}", Year );
        Console.WriteLine( "\t Passengers: {0}", Passengers );
        Console.WriteLine( "\t Port: {0}", Port );
        Console.WriteLine( "\n" );
    }
}

class Car : Vehicle
{

}

class Program
{
    static void Main()
    {
        var car = new Car();
        car.Price = 500000;
        car.Year = 2010;
        car.Speed = 180;
        car.Coordinate( 10, 100 );

        var plane = new Plane();
        plane.Price = 100000000;
        plane.Year = 2018;
        plane.Speed = 980;
        plane.Coordinate( 500, 400, 9000 );
        plane.Height = 11000;
        plane.Passengers = 800;

        var ship = new Ship();
        ship.Price = 200000000;
        ship.Year = 1989;
        ship.Speed = 60;
        ship.Coordinate( 100, 900 );
        ship.Passengers = 700;
        ship.Port = "Severomorsk";


        car.VehicleInfo();
        plane.VehicleInfo();
        ship.VehicleInfo();
    }
}