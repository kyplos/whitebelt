namespace kata1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome, brave adventurer! what is your name?");
        
        string name = Console.ReadLine();
        
        Console.WriteLine($"Greetings,{name} Your journey begins now... ");
        
        Console.WriteLine("on a scale of 1 to 10, how escited are you to start this quest?");
        
        int excitment = Convert.ToInt16(Console.ReadLine());

        if (excitment >= 7)
        {
            Console.WriteLine("fantastic! you seem ready to take on any challenge");
        }
        else
        {
            Console.WriteLine("you dont seem to be excited to do this quest");
        }
    }
}