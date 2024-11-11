namespace mini_kata_4;

class Program
{
    static void Main(string[] args)
    {
        int spawnedEnemies = 0;
        int maxEnemies = 3;
        
        Console.WriteLine("spawning enemies using a for loop:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"enemy #{i + 1} spawned!");
        }
        
        Console.WriteLine("spawning enemies using a while loop:");
        while (true)
        {
            if (spawnedEnemies >= maxEnemies)
            {
                break;
            }
            
            Console.WriteLine($"enemy #{spawnedEnemies + 1} spawned!");
            
            spawnedEnemies ++;
            
        }
    }
}