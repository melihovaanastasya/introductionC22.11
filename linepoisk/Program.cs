// линейный поиск в массиве

int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int [] a=new int [size];
    Random random=new Random();
    for(int i=0;i<size;i++)
    a[i]=random.Next(min,max);
    return a;   
}

void Print(int [] a)
{
    for (int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
}

int [] m=RandomIntArray();
Print(m);
int i=0;
int find=20;
m[4]=find;
while(i<m.Length && m[i]!=find) i++;
if (i==m.Length)
System.Console.WriteLine($"Element {find} not found");
else
System.Console.WriteLine($"Element {find} found at {i}");