// See https://aka.ms/new-console-template for more information


int size = 3;
float[] grades = new float[size];

Console.WriteLine(grades);

/*
for (int i = 0; i < grades.Length; i++)
{
    if (grades[i] > 80)
        Console.WriteLine("A");
    else 
        Console.WriteLine("F");
}*/



/* recursion
int result = Factorial(5);
Console.WriteLine(result);


int Factorial(int n)
{
    if (n <= 0)
        return 1;
    else
    {
        return  n * Factorial(n - 1);
    }

}*/