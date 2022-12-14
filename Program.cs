//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*
int NumberPower( int a, int b){
    int result = a;
    for(int i = 1; i < b; i++){
    result *= a;
    
    Console.WriteLine($"Число в натуральной степени {result} ");
    }
    return result;
}
Console.WriteLine("Entrer your number one");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entrer your number tu");
int b = Convert.ToInt32(Console.ReadLine());
NumberPower(a,b);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
//сумму цифр в числе.(Массивы и строки использовать нельзя!!!)
//452 -> 11
//82 -> 10
//9012 -> 12
/*
int Figure (int num){
   
   int result = 0;
   while(num > 0){
      result += num % 10;
      num = num / 10;
   
     Console.WriteLine($"Сумма цифр в числе - {result} ");
   }
   
    return result;
   
}
Console.WriteLine($" Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Figure(num);
*/
//Задача 29: Напишите программу, которая задаёт массив из произвольного
// кол-ва элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
/*
int [] Arrey(){
    Console.WriteLine($" Введите размер масива");
    int size = Convert.ToInt32(Console.ReadLine());
    int [] arr = new int [size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(size);
        Console.Write($"{arr[i]}");
    }
    return arr;
}

void SwowArrey (int [] arr){
    for(int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]}");
    }
}

SwowArrey(Arrey());
*/

/*
int [] Arrey(){
    Console.WriteLine($" Введите размер масива");
    int size = Convert.ToInt32(Console.ReadLine());
    int [] arr = new int [size];
    for(int i = 0; i < arr.Length; i++)
    {
       
        Console.Write($"Введите элемент масива {i} ");
       arr[i]  = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void SwowArrey (int [] arr){
    for(int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]}");
    }
}

SwowArrey(Arrey());
*/