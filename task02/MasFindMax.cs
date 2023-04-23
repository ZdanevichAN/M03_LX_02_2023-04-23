// поиск элемента массива равного find
int[] array = {12,456,24,
                234,678,23,
                45,11,0
                };

int n = array.Length;
int find = 11;
int index = 0;
while(index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break; //завершить работу при первом вхождении
    }

    index++;
}