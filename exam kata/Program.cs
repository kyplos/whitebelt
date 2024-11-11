namespace exam_kata;

class Program
{
    static void Main(string[] args)
    {
        int playerHealth = 10;
        int enemyHealth = 100;
        
        Random damage = new Random();
        Random returningHealth = new Random();
        
        bool running = true;
        while (running)
        {
            Console.WriteLine($"Hero's Health:{playerHealth}");
            Console.WriteLine($"Goblin's Health:{enemyHealth}\n");
            
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. heal\n");
            
            string action = Console.ReadLine();

            if (action == "1")
            {
                int playerAttack = damage.Next(5, 16);
                Console.WriteLine("Hero attacks the Goblin!");
                Console.WriteLine($"Goblin takes {playerAttack} damage.\n");
                enemyHealth -= playerAttack;
                
                Thread.Sleep(1000);
                
                int enemyAttack = damage.Next(5, 16);
                Console.WriteLine("Goblin attacks Hero!");
                Console.WriteLine($"Hero takes {enemyAttack} damage.\n");
                playerHealth -= enemyAttack;
                
                Thread.Sleep(1000);
            }
            else if (action == "2")
            {
                int heal = returningHealth.Next(1, 11);
                Console.WriteLine($"the hero healed him self for {heal} health.\n");
                
                Thread.Sleep(1000);
                
                int enemyAttack = damage.Next(5, 16);
                Console.WriteLine("Goblin attacks Hero!");
                Console.WriteLine($"Hero takes {enemyAttack} damage.\n");
                playerHealth -= enemyAttack;
                
                Thread.Sleep(1000);
            }
            
            if (playerHealth <= 0)
            {
                Console.WriteLine("Congratulations! The Goblin killed the Hero!!");
                running = false;
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("Congratulations! The Hero killed the Goblin!!");
                running = false;
            }
            
        }
    }
}