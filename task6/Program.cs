// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Enter number:");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1 %2 == 0){
    Console.WriteLine("Число:" + num1);
    Console.WriteLine("Четное");
}
else{
    Console.WriteLine($"Число: {num1}");
    Console.WriteLine("Нечетное");
}