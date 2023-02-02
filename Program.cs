// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int getUserData (string massage)
{
    Console.WriteLine(massage);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
int getMulti(int numberA, int numberB)
{
    int multi = 1;
    for (int i = 1; i<=numberB; i++)
    {
        multi = multi * numberA;
    }
    return multi;
}
void showData( string massageStart, int data)
{
    Console.Write(massageStart);
    Console.Write(data);
}
int numberA = getUserData("Введите число А для возведения в степень");
int numberB = getUserData("Введите число В для степени");
int multi = getMulti(numberA,numberB);
showData($"Число A в натуральной степени B  = ",multi);

