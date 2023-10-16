
#region homework task1

//Console.WriteLine("reqemleri daxil edin:");
//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//int sum=num1+ num2;

//    if (sum <= 99 && sum >=10)
//    {
//        Console.WriteLine("Cem 2 reqemli ededdir");
//    }

//    else if (sum>=100 && sum <= 999)
//    {
//        Console.WriteLine("Cem 3 reqemli ededdir");
//    }
//    else
//    {
//        Console.WriteLine("nezere alinmayib");
//    }



#endregion

#region task1 new
Console.WriteLine("Reqemleri daxil edin");
int num1=int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int sum=num1+ num2;
int m= 10;
int count = 1;
while(sum>=m)
{
    if (sum / m != 0)
    {
        sum = sum / m;
        count += 1;
    }
}
Console.Write("daxil etdiyiniz reqemlerin cemi:");
Console.Write(count);
Console.WriteLine(" mertebelidir");

#endregion