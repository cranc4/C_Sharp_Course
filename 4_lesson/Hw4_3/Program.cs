// // 3: Напишите программу, которая задаёт массив
// //  из 8 элементов и выводит их на экран.

 void Massiv(int n)
         {
             int[] array = new int[n];
            
 
             Console.WriteLine("Вывод с помощью for:");
             for (int i = 0; i < array.Length; i++)
             {
                 array[i] = new Random().Next(100);
                 Console.Write($"{array[i]}, ");
             }
             Console.WriteLine();
             Console.WriteLine("Вывод с помощью foreach:");
             foreach (var elem in array)
             {
                 Console.Write($"{elem}, ");
             }
         }
         Console.WriteLine("Введите количество элементов массива:");
         Massiv(int.Parse(Console.ReadLine()));
