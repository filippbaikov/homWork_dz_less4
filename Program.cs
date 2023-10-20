Console.Clear();
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

task_25_ConsoleOut();

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("введи число от 3  до 6 цифр чтобы содержало: ");
int x= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("функция (сколько цифр в числе, сумма этих цифр): "+task_27_func(x));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("введи сколько хочешь элементов в массиве");
int length=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" введи диапазон значений от и до, которые ты хочешь в массив засунуть");
System.Console.WriteLine();
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("получилось: ");
task_29_func(length,a,b);



int task_25_func(int a, int b)
{ //функция возведения в степень. задача25
    int powNum=a;
    int i=0;
    while ( i<b-1){
        powNum=powNum*a;
        i++;
    }
    return powNum;
}
void task_25_ConsoleOut()
{ //метод просит 2 числа, вызывает функцию возведения в степень. задача 25
System.Console.WriteLine("введи первое число: ");
int x= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введи степень, в которую хочешь возвести: ");
int y= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("получилось: ");
System.Console.WriteLine(task_25_func(x,y));
System.Console.WriteLine();
}
int task_27_func(int a){ 
     //функция (сколько цифр в числе, сумма этих цифр) задача 27
    int sum=a%10;
while(a!=0){
     a= a/10;
     sum=sum+a%10;
}
return sum;
    
}

void task_29_func (int length , int a, int b ){
    int [] arr = new int [length];
    Random random =new Random();
    for (int i = 0; i < arr.Length; i++)
        arr [i]= random.Next(a,b);
        
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + ", ");
    }

}