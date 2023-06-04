using System;

class Program
{
    static void Main(string[] args)
    {
        IVessel sailingVessel = new SailingVessel();
        IVessel submarine = new Submarine();

        Console.WriteLine("Sailing Vessel:");
        sailingVessel.PrepareToMovement();
        sailingVessel.Move();

        Console.WriteLine("\nSubmarine:");
        submarine.PrepareToMovement();
        submarine.Move();
    }
}
public interface IVessel
{
    void PrepareToMovement();
    void Move();

}

public class SailingVessel : IVessel
{
    public void PrepareToMovement()
    {
        Console.WriteLine("*The sailing vessel is preparing to move*");
    }

    public void Move()
    {
        Console.WriteLine("*The sailing vessel is moving*");
    }
}

public class Submarine : IVessel
{
    public void PrepareToMovement()
    {
        Console.WriteLine("*The submarine is preparing to move*");
    }

    public void Move()
    {
        Console.WriteLine("*The submarine is moving*");
    }
}