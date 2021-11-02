using System;

//Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
//Создать на его основе масив B, отбрасывая те, которые нарушают порядок:

    //возрастания
    //элементы, больше 8
    //знакочередования


void FillTheArray(int[] numbers)  // Создаем метод (функцию)
{
    int length = numbers.Length;   // находим длинну массива
    int index = 0;
    int minValue = -10;
    int maxValue = 20;

    while(index < length)
    {
        numbers[index] = new Random().Next(minValue, maxValue);  // Кладем новое случ. число из диапазона
        index++;
    }
}

void PrintArray(int[] num)
{
    int count = num.Length;
    int currentIndex = 0;   // текущий индекс позиции
    while(currentIndex < count)
    {
        Console.WriteLine(num[currentIndex]);
        currentIndex++;
    }

}



int[] arrayA = new int[10]; // Создали массив
FillTheArray(arrayA); // Вызов метода заполнения массива
PrintArray(arrayA);  // вызов метода печати массива

















//int[] arrayA = new int[10];  // 1. Создаем новый массив из 10 элементов


/*int[] CreateArray = new int[10];


int minValue = -10;
int maxValue = 20;
//int index = 0;

int arrayA = new Random().Next(minValue, maxValue);



Console.WriteLine(arrayA);*/


