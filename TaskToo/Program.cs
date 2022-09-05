// принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите натуральное число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0, b=0;
if (A<0) A=A*-1;
if (A>=0 && A<10) Console.Write("Сумма цифр в числе = "+A);
if (A>=100)
{
    while (A>=100)
    {
        b=A%10;
        A=A/10;
        sum=sum+b;
    }
}
if (A>=10 && A<100)
{
    A=A/10+A%10;
    Console.Write("Сумма цифр в числе = "+(A+sum));
} 
