// сортирует массив от большего к меньшему и находит медианное значение. 
// Массив заполняется случайными целыми числами от 1 до 100, а его размерность вводится с клавиатуры.
Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array=new int [n];
for (int i=0; i<n; i++) // Создаем массив и выводим на экран
{   array[i] = new Random().Next(1,100);
    Console.Write(array[i]+" ");
}
int max = 0, j=1;
 Console.WriteLine();
for (int i=0; i<n; i++)
{  while (j<n)
  {    if (array[i]<array[j])
    {   max = array[i];
        array[i]=array[j];
        array[j]=max;
    }    j++;
  }   j=i+1;
  Console.Write(array[i]+" ");  
}   Console.WriteLine();
if (n%2 == 1) Console.Write("Медиана массива = "+array[n/2]);
else Console.Write("Медиана массива = "+(array[n/2-1]+array[n/2])/2);
