#region homework task1

using System.ComponentModel.Design;

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int sum=num1+ num2;

    if (sum <= 99 && sum >=10)
    {
        Console.WriteLine("Cem 2 reqemli ededdir");
    }

    else if (sum>=100 && sum <= 999)
    {
        Console.WriteLine("Cem 3 reqemli ededdir");
    }
    else
    {
        Console.WriteLine("nezere alinmayib");
    }



#endregion