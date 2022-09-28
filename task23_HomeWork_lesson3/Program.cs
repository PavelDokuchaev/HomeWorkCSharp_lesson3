/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void showSquareNumber(int number)
{
int count = 1;
int result = new int();

while(count <= number)
{
    result = (int)Math.Pow((number - (number - count)), 3);
    count = count + 1;
    Console.Write(result);
    if(count < number + 1)
        {
           Console.Write(", "); 
        }
}
}

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Для числа {userNumber} кубы от 1 до {userNumber} равны: ");
showSquareNumber(userNumber);
Console.WriteLine();
