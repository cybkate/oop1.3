try
{
    Console.WriteLine("Введіть поточну ціну долара в гривнях ");
    decimal u = decimal.Parse(Console.ReadLine());  //метод, який використовується для перетворення рядкового представлення числа в його десятковий еквівалент.
    Console.WriteLine("Введіть поточну ціну євро в гривнях ");
    decimal e = decimal.Parse(Console.ReadLine());
    if (u==0)
    {
        Console.WriteLine("Помилка");
        Environment.Exit(0);
    }
    if (e==0)
    {
        Console.WriteLine("Помилка");
        Environment.Exit(0);
    }
    Converter converter = new Converter(u, e);
    Console.WriteLine("Яку конвертацію ви бажаєте отримати? 1 - долар в гривню, 2 - долар в євро, 3 - гривня в долар, 4 - гривня в євро");
    int i = Convert.ToInt32(Console.ReadLine());
    if (i == 1)
        {
            converter.ConvertUSDtoUAH();
        }
        else if (i == 2)
        {
            converter.ConvertEURtoUAH();
        }
        else if (i == 3)
        {
            converter.ConvertUAHtoUSD();
        }
        else if (i == 4)
            converter.ConvertUAHtoEUR();
        else
            Console.WriteLine("Помилка!");
    }

catch
{
    Console.WriteLine("Неправильний формат");
}


class Converter
{
    decimal USDtoUAH;    //параметри, що відповідають курсу долара та євро по відношенню до гривні
    decimal EURtoUAH;
    public Converter(decimal USD, decimal EUR)    //конструктор, який приймає на вхід 2 аргументи типу decimal, та ініціалізують параметри
    {
        USDtoUAH = USD;    
        EURtoUAH = EUR;
    }
    public void ConvertUSDtoUAH()
    {
        try
        {
            Console.WriteLine("Введіть суму грошей в доларах ");
            decimal USD = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Сума в гривнях: {USD * USDtoUAH}\n");
        }
        catch
        {
            Console.WriteLine("Неправильний формат");
        }
    }
    public void ConvertEURtoUAH()
    {
        try
        {
            Console.WriteLine("Введіть суму грошей в євро ");
            decimal EUR = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Сума в гривнях: {EUR * EURtoUAH}\n");
        }
        catch
        {
            Console.WriteLine("Неправильний формат");
        }
    }
    public void ConvertUAHtoUSD()
    {
        try
        {
            Console.WriteLine("Введіть суму грошей в гривнях ");
            decimal UAH = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Сума в доларах: {UAH / USDtoUAH}\n");
        }
        catch
        {
            Console.WriteLine("Неправильний формат");
        }
    }

    public void ConvertUAHtoEUR()
    {
        try
        {
            Console.WriteLine("Введіть суму грошей в гривнях ");
            decimal UAH = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Сума в євро: {UAH / EURtoUAH}\n");
        }
        catch
        {
            Console.WriteLine("Неправильний формат");
        }
    }  
}