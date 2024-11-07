namespace mini_kata3;

class PlayerAttack
{
    public void Run()
    {
       Console.WriteLine("attempting to attack...");
       
       Random random = new Random();
       int playerLuck = random.Next(1, 11);

       if (playerLuck > 7)
       {
           Console.WriteLine("success! your attack hits the enemy.");
       }
       else if (playerLuck == 6)
       {
           Console.WriteLine("success! but your attack barely hits");
       }
       else
       {
           Console.WriteLine("your attack misses!");
       } 
    }
}
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("do you want to attack (yes/no)");
            string answer = Console.ReadLine().ToLower();
        

            if (answer == "yes"|| answer == "y")
            {
                PlayerAttack attack = new();
                attack.Run();
            }
            else if (answer == "no" || answer == "n")
            {
                Console.WriteLine("Have a nice day.");
                break;
            }
            else
            {
                Console.WriteLine("you did not enter a valid answer");
                break;
            }
        }
    }
}