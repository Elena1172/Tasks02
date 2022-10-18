// Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
bool dayWeek(int a){
    bool b = false;
    if(a == 6 || a == 7)b = true;
    return b;
}
Console.Write("Введите число от 1 до 7 включительно: ");
int b = Convert.ToInt32(Console.ReadLine());
if(b > 0 && b < 8){
    bool d = dayWeek(b);
    string s = d?"Да":"Нет";
    Console.Write(s);
}
else Console.Write("Неправильный ввод числа.");