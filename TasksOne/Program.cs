// принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
double rezalt = Math.Pow(A,B); 
Console.Write("А в степени В = "+rezalt);
