// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void RandArray(int[] collection, int lBound, int hBound)         //  метод наполняет массив случайными числами
{
    for (int i = 0; i < collection.Length; i++)
        collection[i] = new Random().Next(lBound, hBound);
}

Console.Clear();                                                 //  очистка консоли
Console.WriteLine("Введите количество элементов в массиве: ");   //  ввод числа
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)                                                    // если отрицательное значение
    Console.WriteLine($"Число должно быть больше 0!");
else
    {
    int[] array = new int[num];                                   //  объявление массива
    RandArray(array,-100,100);                                       //  наполнение массива
    Console.WriteLine(String.Join(" ",array));                    //  вывод массива
    int sumNotEvenPos = 0;                                        //  накопитель подсчета
    for (int i = 0; i < array.Length; i++)                        //  обход массива
        if (i % 2 == 1)                                           //  позиция элемента массива - нечётная
            sumNotEvenPos += array[i];                            //  подсчёт результата
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumNotEvenPos}");
    }