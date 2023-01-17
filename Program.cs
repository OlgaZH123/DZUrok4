// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
 
Console.Write("Введите число: ");
  int A = int.Parse(Console.ReadLine()!);
  Console.Write("Введите число: ");
  int B = int.Parse(Console.ReadLine()!);
  Console.WriteLine($"Возведение чисел равно {GetNum (A,B)}");
  
  int GetNum (int N, int S){
    int m = 1;
    for(int i=1; i<=S; i++){
    m = (m*N);
  }
    return m;
 }






// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

/*/Console.WriteLine("Введи число:");
int Num = int.Parse (Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {Num} равна {GetSum (Num)}");

int GetSum (int A){
    int Result = 0;
	int num1 = A%10;
	int num2 = (A/10)%10;
    int num3 = (A/10)/10;
	Result = num1 + num2 + num3;
    return Result;
}*/
    

	
	 






// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

/*/int [] myArray = GetArray (8);
Console.WriteLine($"[{String.Join(",", myArray)}]");

int [] GetArray (int size){
    int [] res = new int [size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(8);
    }
    return res;
}*/