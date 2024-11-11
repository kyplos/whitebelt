namespace kata_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You find a mysterious treasure chest! What will you do?");
        Console.WriteLine("1. Open the chest");
        Console.WriteLine("2. Ignore the chest");
        Console.WriteLine("3. Leave the area");
        
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Random rand = new Random();
            int luck = rand.Next(1, 11);
            Console.WriteLine("you try to open the chest");
                                 
            if (luck > 7) 
            { 
                Console.WriteLine("you successfully opened the chest!");
                Console.WriteLine("you got a diamond");
            }
            else if (luck >= 5) 
            { 
                Console.WriteLine("you were successful opening the chest!");
                Console.WriteLine("you got a sword!");
            }
            else 
            { 
                Console.WriteLine("you failed when opening the chest");
            }   
                
        }
        if (choice == "2")
        {
            Console.WriteLine("you ignored the chest");
            Console.WriteLine("the player continues on his journey");
        }
        if (choice == "3")
        {
            Console.WriteLine("you have left the area");
            Console.WriteLine("you will never know what was in that chest and it will haunt you for the rest of your life!");
        }
        else
        {
            Console.WriteLine("please input a valid input (1,2,3)");
        }
       
        
        
        
    }
}