/* Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

/* int a = 12329;
int b = new int();
int c = new int();
b = a % 100;
c = a / 1000;
Console.WriteLine(b);
Console.WriteLine(c);
*/
//Int32.Parse
 
            int number, result = 0;
        
            Console.Write("enter number: ");
            number = Convert.ToInt32(Console.ReadLine());
 
            while (number > 0) {
                result *= 10;
                result += number % 10;
                number /= 10;
            }
 
            Console.WriteLine(result);
       


