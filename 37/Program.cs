// 37. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int [] a=new int [size];
    Random random=new Random();
    for(int i=0;i<size;i++)
    a[i]=random.Next(min,max);
    return a;
}

void KolvoChet (int []a,int k)
{
    k=0;
    for (int i=0;i<a.Length;i++)
    if (a[i]%2==0) k++;
    System.Console.WriteLine($"Количество четных чисел - {k}");
}

void KolvoNeChet (int []a,int k)
{
    k=0;
    for (int i=0;i<a.Length;i++)
    if (a[i]%2==1) k++;
    System.Console.WriteLine($"Количество нечетных чисел - {k}");
}

void Print(int [] a)
{
    for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
}

int [] a=RandomIntArray(10,100,1000);
Print(a);
System.Console.WriteLine();
int k=0;
KolvoChet(a,k);
KolvoNeChet(a,k);