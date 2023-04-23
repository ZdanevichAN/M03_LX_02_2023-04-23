//метод для наполнения массива рандомными значениями
void FillArray(int[] collection) // - принимает массив(колекцию)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
//метод выводящий на экран
void PrintArrays(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}
//создай новый массив в котором будет 10 пустых элементов 
int[] array = new int[10];
FillArray(array);
PrintArrays(array);
