/* Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
          
int invertedNumber (int number)
{
    int result = 0;
 
    while (number > 0) 
    {
        result = result * 10;
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int checkPalindrome = invertedNumber(userNumber);

if(userNumber == checkPalindrome)
{
    Console.WriteLine("Введенное число является палиндромом");
}
else 
    Console.WriteLine("Введенное число не является палиндромом");  

/* int a = 12329;
int b = new int();
int c = new int();
b = a % 100;
c = a / 1000;
Console.WriteLine(b);
Console.WriteLine(c);
*/
