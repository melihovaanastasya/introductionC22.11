// 36. Определить, присутствует ли в заданном массиве, некоторое число

int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int [] a=new int [size];
    Random random=new Random();
    for(int i=0;i<size;i++)
    a[i]=random.Next(min,max);
    return a;   
}

void Poisk(int []a, int find)
{
    int i=0;
    while(i<a.Length && a[i]!=find) i++;
    if (i==a.Length)
    System.Console.WriteLine($"Element {find} not found");
else
    System.Console.WriteLine($"Element {find} found");
}

void Print(int [] a)
{
    for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
}

int [] a=RandomIntArray(10,0,100);
Print(a);
System.Console.WriteLine();
int find = Convert.ToInt32 (Console.ReadLine());
Poisk(a,find);