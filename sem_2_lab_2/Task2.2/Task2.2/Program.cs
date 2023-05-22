using System;

class Program
{
    static void Main(string[] args)
    {
        Vessel sailingVessel = new SailingVessel();
        Vessel submarine = new Submarine();

        Console.WriteLine("Sailing Vessel:");
        sailingVessel.PrepareToMovement();
        sailingVessel.Move();

        Console.WriteLine("\nSubmarine:");
        submarine.PrepareToMovement();
        submarine.Move();
    }
}
public abstract class Vessel
{
    public abstract void PrepareToMovement();
    public abstract void Move();

}

public class SailingVessel : Vessel
{
    public override void PrepareToMovement()
    {
        Console.WriteLine("*The sailing vessel is preparing to move*");
    }

    public override void Move()
    {
        Console.WriteLine("*The sailing vessel is moving*");
    }
}

public class Submarine : Vessel
{
    public override void PrepareToMovement()
    {
        Console.WriteLine("*The submarine is preparing to move*");
    }

    public override void Move()
    {
        Console.WriteLine("*The submarine is moving*");
    }
}
