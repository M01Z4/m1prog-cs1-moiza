namespace alsdan;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("is player moving? (y/n)");
        string isPlayerMoving = Console.ReadLine();

        Console.WriteLine("is player jumping? (y/n)");
        string isPlayerJumping = Console.ReadLine();

        if (isPlayerMoving == "y" && isPlayerJumping == "y")
        {
            Console.WriteLine("walk");
        }

        else if (isPlayerMoving == "n" && isPlayerJumping == "n")
        {
            Console.WriteLine("idle");
        }

        else if (isPlayerMoving == "y" && isPlayerJumping == "n")
        {
            Console.WriteLine("walk");
        }

        else if (isPlayerMoving == "n" && isPlayerJumping == "y")
        {
            Console.WriteLine("jumpup");
        }
    }
}