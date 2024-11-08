namespace kata_2;

class Program
{
    static void Main(string[] args)
    {
        string name = "Kyplos";
        int level = 7;
        float healthPoints = 250;
        double experiencePoints = 2534.24;
        bool isMagical = true;
        char rank = 'B';
        double requiredExperience = 5000;
        double experienceToLevel = requiredExperience - experiencePoints;
        
        Console.WriteLine($"Character Name:{name}");
        Console.WriteLine($"Level:{level}");
        Console.WriteLine($"Health Points:{healthPoints}");
        Console.WriteLine($"Experience Points:{experiencePoints}");
        Console.WriteLine($"Has Magical Abilities:{isMagical}");
        Console.WriteLine($"Rank:{rank}");
        Console.WriteLine($"Experience needed to level:{experienceToLevel}");
    }
}