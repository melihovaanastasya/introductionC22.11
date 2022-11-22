// 35. Написать программу замены элементов массива на противоположные

int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int [] a=new int [size];
    Random random=new Random();
    for(int i=0;i<size;i++)
    a[i]=random.Next(min,max);
    return a;
}

void Protiv(int [] a)
{
    for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]*(-1),5}");
}

void Print(int [] a)
{
    for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
}

int [] a=RandomIntArray(10,0,100);
Print(a);
System.Console.WriteLine();
Protiv(a);