// Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей
//цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
int Dig3(int a){
    while(a > 999){
        a = a / 10;
    }
    a = a % 10;
    return a;
}
Console.Write("Введите любое целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99){
    int d = Dig3(n);
    Console.Write($"В числе {n} -> {d}");
}
else if (n < -99){
    int d = Dig3(n);
    d = d * -1;
    Console.Write($"В числе {n} -> {d}");
}
else{
    Console.Write($"В числе {n} -> третьей цифры нет");
}