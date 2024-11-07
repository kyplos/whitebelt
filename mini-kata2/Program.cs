namespace mini_kata2;

class Program
{
    static void Main(string[] args)
    {
        string name = "Lukas";
        int healthPoints = 100;
        float attackPower = 30.5f;
        float experiencePoints = 250f;
        bool isParalyzed;
        string currencyAmmount = "150,333";
        
        double convertedHealthPoints = Convert.ToDouble(healthPoints);
        Console.WriteLine($"Health as double (implicit conversion):{convertedHealthPoints}");
        
        int convertedAttackPower = Convert.ToInt32(attackPower);
        Console.WriteLine($"Attack Power as int (explicit conversion): {convertedAttackPower}");

        int convertedExperiencePoints = Convert.ToInt32(experiencePoints);
        Console.WriteLine($"Experience as int (using convert): {convertedExperiencePoints}");

        double convertedCurrencyAmmount = Convert.ToDouble(currencyAmmount);
        Console.WriteLine($"Golf Coins (Parsed from string): {convertedCurrencyAmmount}");
        
        if (int.TryParse("Lukas", out int result)) 
        { 
            Console.WriteLine($"You parsed a string to a int:{result}"); 
        }
        else
        {
            Console.WriteLine("you cant parse a string to a int");
        }
    }
}
