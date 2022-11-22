// 38. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int [] a=new int [size];
    Random random=new Random();
    for(int i=0;i<size;i++)
    a[i]=random.Next(min,max);
    return a;
}

void Kolvo10_99(int []a,int k)
{
    k=0;
    for (int i=0;i<a.Length;i++)
    if (a[i]>9 && a[i]<100) k++;
    System.Console.WriteLine($"Количество чисел от 10 до 99 - {k}");
}

void Print(int [] a)
{
    for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
}

int [] a=RandomIntArray(123,0,1000);
Print(a);
System.Console.WriteLine();
int k=0;
Kolvo10_99(a,k);