using System;

//Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
//Создать на его основе масив B, отбрасывая те, которые нарушают порядок:

    //возрастания
    //элементы, больше 8
    //знакочередования

// Создаем метод заполнения массива

int[] arrayA = new int[10];
int minValue = new Random().Next(-90, 10);
int maxValue = new Random().Next(10, 90);
int index = 0;

for(int j = 0; j < 10; ++j)
{
    Random rnd;
    rnd=new Random();
    arrayA[j] = new Random().Next(minValue,maxValue);
}

for(index = 0; index < 10; ++index)
{
    Console.Write(arrayA[index]+" ");
}


int[] CreateArrayB(int[] arrayB)  //Создание массива B на основе массива А
{
    int len = (arrayA.Length)-1;
    int index = 0;
    int index2 = 0;
    int currentElement = 0;
    while (index <= len) 
    {
    if(arrayA[index]>currentElement)
    {
        currentElement = arrayA[index];
        arrayB[index2] = currentElement;
        index2++;
    }
     index++;
    }
    return arrayB;
    arrayB = CreateArrayB(arrayB); 
}





//создаём массив А
/*int[] arrayA = new int[10];
int minValue = new Random().Next(-90,10);
int maxValue = new Random().Next(10,90);
int i = 0;

for(int j=0; j<10; ++j)   // Заполнение массива случайными числами
{
    Random rnd;
    rnd=new Random();
    arrayA[j] = new Random().Next(minValue,maxValue);
} 
for(i=0;i<10;++i) // вывод на консоль чисел
  {
    Console.Write(arrayA[i]+" ");
  }

int[] createArrayB(int[] arrayB)//Создание массива B на основе массива А
{
int len = (arrayA.Length)-1;
int index = 0;
int index2 = 0;
int currentElement = 0;
while (index <= len)
 {
  if(arrayA[index]>currentElement)
  {
  currentElement = arrayA[index];
  arrayB[index2] = currentElement;
  index2++;
  }
  index++;
 }
 return arrayB;
}
int[] arrayB =*/
