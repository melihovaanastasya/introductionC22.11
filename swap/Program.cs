

void Swap(ref int a, ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void Calkulator (int a, int b, ref int sum, ref int multi)
{
    sum=a+b;
    multi=a*b;
}

int a=3, b=5;

System.Console.WriteLine($"a={a} b={b}");
Swap (ref a, ref b);
System.Console.WriteLine($"a={a} b={b}");
int sum=0, multi=0;
Calkulator (a,b, out sum, out multi);