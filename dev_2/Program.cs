using System;

//Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
//Создать на его основе масив B, отбрасывая те, которые нарушают порядок:

    //возрастания
    //элементы, больше 8
    //знакочередования

// Создаем метод заполнения массива

int[] arrayA = new int[10];     // создаем массив А 
int[] arrayB = new int[10];     // создаем массив В

int minValue = new Random().Next(-40, 10);  // создаем min
int maxValue = new Random().Next(10, 40);   // создаем max


for(int j=0; j<10; ++j)   // Заполнение массива случайными числами
{
    arrayA[j] = new Random().Next(minValue,maxValue);
} 


void PrintArray(int[] col)      // метод вывода массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
            if(col[position]!=0)
        {
            Console.Write(col[position] + " ");
        }
            position++;
    }  
}
Console.WriteLine("Массив: ");
PrintArray(arrayA);       // вызов метода
Console.WriteLine();


int[] createArrayB(int[] arrayB) //Создание массива B на основе массива А с отбрасыванием чисел, нарушающих порядок возрастания
{
    int len = (arrayA.Length)-1;
    int index = 0;
    int index2 = 0;
    int currentElement = -40;
    while (index <= len)
    {
        if(arrayA[index] > currentElement)
            {
                currentElement = arrayA[index];
                arrayB[index2] = currentElement;
                index2++;
            }
            index++;
    }
    return arrayB;
}
Console.WriteLine("Числа нарушающие порядок: ");
arrayB = createArrayB(arrayB);
PrintArray(arrayB);
Console.WriteLine();


/*int[] createArrayC(int[] arrayC);     //Создание массива C на основе массива B (откидываем числа больше 8)


void PrintArray(int[] col)      // метод вывода массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
            if(col[position]!=0)
        {
            Console.Write(col[position] + " ");
        }
            position++;
    }  
}
Console.WriteLine("Массив: ");
PrintArray(arrayA);       // вызов метода
Console.WriteLine();




/*{
    int len = (arrayB.Length)-1;
    int index = 0;
    int index3 = 0;
    int currentElement2 = -40;
    int ElementOfarray = 8;
    while(index <= len)
    {
        if(arrayC[index] == ElementOfarray)
        {
            currentElement2 = arrayB[index];
            arrayC[index3] = currentElement2;
            index3++;
        }
        index++;
    }
    return arrayC;
}

Console.WriteLine("Элементы больше 8: ");
arrayC = createArrayC(arrayC);
PrintArray(arrayC);*/

