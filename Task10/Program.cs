// Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int Dig2(int a){
    a = a/10%10;
    return a;
}
Console.Write("Введите целое трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 99 && n < 1000){
    int d = Dig2(n);
    Console.Write($"В числе {n} -> {d}");
}
else if (n > -1000 && n < -99){
    int d = Dig2(n);
    d = d*-1;
    Console.Write($"В числе {n} -> {d}");
}
else{
    Console.Write("Некорректный ввод числа.");
}