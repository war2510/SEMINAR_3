﻿// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[5];

// bool isFind =false;

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(0,4);   // -191   205
//     System.Console.Write(array[i]+ " ");

//     if(array[i] == num)
//     {
//         isFind=true;
//     }
// }

// if(isFind == true)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }




// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// int[] array = new int[10];

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(-10,11); 
//     System.Console.Write(array[i]+ " ");
// }

// Console.WriteLine();

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = array[i] *-1; 
//     System.Console.Write(array[i]+ " ");
// }


// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5]

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[num];
// int[] array2 = new int[num/2];

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(-10,20); 
//     System.Console.Write(array[i]+ " ");

// }

// System.Console.WriteLine();

// for(int i = 0; i<array2.Length; i++)
// {
//     if(i == array.Length-1-i)
//     {
//         return;
//     }

//     array2[i] = array[i] * array[array.Length-1-i]; 
//     Console.Write(array2[i]+ " ");
// }


// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[3];

// if(num>99 && num<1000)
// {
//     array[0]= num%10;
//     array[1]= num/10 %10;
//     array[2] = num/100;

//     for(int i =0; i<array.Length; i++)
//     {
//         System.Console.Write(array[i]+ " ");
//     }
// }
// else
// {
//     System.Console.WriteLine("Число не подходит");
// }
