

#region homework task1

Console.WriteLine("reqemleri daxil edin:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int sum = num1 + num2;

if (sum <= 99 && sum >= 10)
{
    Console.WriteLine("Cem 2 reqemli ededdir");
}

else if (sum >= 100 && sum <= 999)
{
    Console.WriteLine("Cem 3 reqemli ededdir");
}
else
{
    Console.WriteLine("nezere alinmayib");
}



#endregion

#region task1 new metod
//Console.WriteLine("Reqemleri daxil edin");
//int num1=int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//int sum=num1+ num2;
//int m= 10;
//int count = 1;
//while(sum>=m)
//{
//    if (sum / m != 0)
//    {
//        sum = sum / m;
//        count += 1;
//    }
//}
//Console.Write("daxil etdiyiniz reqemlerin cemi: ");
//Console.Write(count);
//Console.WriteLine(" mertebelidir");

#endregion

#region task2 cupboard and door

//Console.WriteLine("Skafin olculerini daxil edin");
//Console.Write("eni:");
//int eni = int.Parse(Console.ReadLine());
//Console.Write("hundurluyu:");
//int hundurluk = int.Parse(Console.ReadLine());
//Console.Write("uzunluq:");
//int uzunluq = int.Parse(Console.ReadLine());

//int e = 100;
//int h = 200;

//if ((eni <= e && hundurluk <= h) || (eni <= e && uzunluq <= h) || (uzunluq <= e && hundurluk <= h) || (uzunluq <= e && eni <= h)
//    || (hundurluk <= e && uzunluq <= h) || (hundurluk <= e && eni <= h)
//    )
//{
//    Console.WriteLine("skaf qapidan kecir");
//}

//else
//{
//    Console.WriteLine("skaf qapidan kecmir");

//}


#endregion

#region mytask

//using System;
//while (true)
//{


//Console.WriteLine("Ededi daxi et");

//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Prosesi daxil et"," * ", " - ", " / ", " + " );
//string prosess= Console.ReadLine(); 
//Console.WriteLine("Ededi daxi et");
//int num2 = int.Parse(Console.ReadLine());
//string[] proses = { "*", "-", "/", "+" };
//int result;
//if (prosess == proses[0])
//{
//    result = num1 * num2;
//    Console.Write("Cavab:");
//    Console.WriteLine(result);
//        Console.WriteLine();
//    }
//else if (prosess == proses[1])
//{
//    result = num1 - num2;
//    Console.Write("Cavab:");
//    Console.WriteLine(result);
//        Console.WriteLine();
//    }
//else if (prosess == proses[2])
//{
//    result = num1 / num2;
//    Console.Write("Cavab:");
//    Console.WriteLine(result);
//        Console.WriteLine();
//    }
//else if (prosess == proses[3])
//{
//    result=num1 + num2;
//    Console.Write("Cavab:");
//    Console.WriteLine(result);
//        Console.WriteLine();
//    }
//else
//{
//    Console.WriteLine("Duzgun daxil etmediniz");
//        Console.WriteLine();
//}
//}
#endregion

#region MYTASK2 BUBBLESORT

//int[] numbers = { 13, 24, 5, 18, 9 };

//for (int i = 0; i < numbers.Length - 1; i++)
//{
//    for (int j = 0; j < numbers.Length - 1; j++)
//    {
//        if (numbers[j] > numbers[j + 1])
//        {
//            int temp = numbers[j];
//            numbers[j] = numbers[j + 1];
//            numbers[j + 1] = temp;
//        }

//    }

//}
//for (int i = 0;i < numbers.Length; i++)
//{
//    Console.Write(numbers[i]);
//    Console.Write(",");
//}

#endregion

#region selection sort
//int[] numbers = { 4, 12, 18, 11, 5, 25, 1 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    int key = i;
//    for (int j = i + 1; j < numbers.Length; j++)
//    {
//        if (numbers[key] > numbers[j])
//            key = j;
//    }
//    int temp = numbers[key];
//    numbers[key] = numbers[i];
//    numbers[i] = temp;
//}
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write(numbers[i]);
//    Console.Write(",");
//}


#endregion