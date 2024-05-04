namespace maze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------- Hello in the MAZE GAME  ---------------");
            Console.WriteLine("Use arrow keys to move the player ");
            maze maze = new maze(40, 20);
            while (true)
            {
                maze.drawmaze();
                maze.move();
            }
        }
    }
}
