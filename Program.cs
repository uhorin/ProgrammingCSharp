//Створіть клас ArrayManipulator, який має методи для роботи з масивами цілих чисел:
//Метод GenerateRandomArray(int length, int min, int max), який створює та повертає новий масив заданої довжини з випадковими числами в діапазоні від min до max.
//Метод FindMax(int[] array), який знаходить та повертає найбільший елемент у масиві.
//Метод SortArray(int[] array), який сортує масив у зростаючому порядку.
//Після створення класу запустіть програму, яка створює масив, знаходить найбільший елемент та сортує масив. Виведіть початковий масив, знайдений максимум та відсортований масив на консоль.
using System;

class ArrayManipulator
{
    int[] array;
    public int FindMax(int[] array)
    {
        int max = 0;
        for (int i =0; i<array.Length; i++)
        {
            if (array[i]>max) {
                max=array[i];
            }
        }
        return max;
    }
    
  
}

class Program
{
    static void Main(string[] args)
    {
        ArrayManipulator array = new ArrayManipulator();

    }
}