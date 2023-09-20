// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter First Number:");
int a =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second Number:");
int b =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Third Number:");
int c =Convert.ToInt32(Console.ReadLine());

if(a>b){
    if (a<c){
        Console.WriteLine($"{c} -> {a} ->{b}");
    }
    else{
        Console.WriteLine($"{a} -> {c}");
    }
}
else if(b>c){
    Console.WriteLine($"{b} -> {a} -> {c}");
    Console.WriteLine(b);
}
else{
    Console.WriteLine($"{c} -> {a} -> {b}");
    Console.WriteLine(c);
}
