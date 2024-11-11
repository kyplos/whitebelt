namespace kata_4;

class Program
{
    static void Main(string[] args)
    {
        int totalWaves = 2;
        int enemiesPerWave = 5;
        for (int wave = 1; wave <= totalWaves; wave++)
        {
            Console.WriteLine($"Wave {wave} is starting!\n");
            for (int enemy = 1; enemy <= enemiesPerWave; enemy++)
            {
                
                Console.WriteLine($"Enemy {enemy} has spawned.");
                Thread.Sleep(500);
            }
            Thread.Sleep(250);
            Console.WriteLine($"Wave {wave} completed. Preparing for the next wave...");
        }       
    }
}