namespace mini_kata1;

class Program
{
    static void Main(string[] args)
    {
        string _name = "Kyplos";
        int _healthPoints = 100;
        float _attackPower = 16.75f;
        bool _isParalzed = true;
        double _currencyAmount = 55.75;
        
        Console.WriteLine($"Character Name: {_name}\n" +
                          $"Health Points:{_healthPoints}\n" +
                          $"Attack Power: {_attackPower}\n" +
                          $"Is paralyzed: {_isParalzed}\n" +
                          $"Gold Coins: {_currencyAmount}");
        

    }
} 