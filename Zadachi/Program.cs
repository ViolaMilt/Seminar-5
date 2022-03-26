//ДЗ 5 семинар

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

int[]array5 = new int [10];

void Sluchai(int[] array2)
{
    for(int i = 0; i <array2.Length;i++)
   {
    array2[i] = new Random().Next(100,1000);
    Console.WriteLine( " " + array2[i]);
   }
}

void Сhet(int[] array)
{
    int count = 0;

    for(int i = 0; i <array.Length;i++)
   {
       if (array[i] % 2 == 0)
       {
           count = count+1;
       }
    
   }
   Console.WriteLine( "Количество четных чисел в массиве: " + count);
}

Sluchai(array5);
Сhet(array5);*/

/*Задача 36: Задайте одномерный массив, 
заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/

int[]array6 = new int [10];
void Sluchai(int[] array2)
{
    for(int i = 0; i <array2.Length;i++)
   {
    array2[i] = new Random().Next(1,10);
    Console.WriteLine( " " + array2[i]);
   }
}
Sluchai(array6);

void SumneСhet(int[] array)
{
    int sum = 0;

    for(int i = 0; i <array.Length;i++)
   {
       if (i % 2 == 1)
       {
           sum = sum + array[i];
       }
    
   }
   Console.WriteLine( "Cумма цифр,стоящих на нечетных позициях =  " + sum);
}

SumneСhet(array6);

/*Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.*/

 double[]massiv7 = new double[5];
 Sluchai(massiv7); 
 Min(massiv7);
 Console.WriteLine (Min(massiv7));
 Max (massiv7);
 Console.WriteLine (Max(massiv7));
 Razn ( Max (massiv7),Min(massiv7));
 
 

 void Sluchai(double[]array2)
{
    for(int i = 0; i <array2.Length;i++)
   {
    array2[i] = new Random().Next();
    Console.WriteLine( " " + array2[i]);
   }
}

  
 double Max ( double[]arr)

  {  double max = arr[0];
      for ( int i = 1; i< arr.Length; i++)

      {
             if ( arr [i] > max)
             {
               max = arr[i];
              }
              
          }
        return max;
      } 
      
      
  
 
 
 double Min ( double[]arr)

  {  double min =arr[0];
      for ( int i = 1; i< arr.Length; i++)

      {
             if ( arr [i] < min)
             {
               min = arr[i];
              }
              
          }
         return min;
      } 
      
  

void Razn (double chislo1,double chislo2)
{
    Console.WriteLine ( chislo1 - chislo2);
}



