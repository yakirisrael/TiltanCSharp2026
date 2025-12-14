// See https://aka.ms/new-console-template for more information

bool teacher = false;
Console.WriteLine(teacher ? "Yakir" : "Kirk");

if (teacher)
{
    int x = 100;
    Console.WriteLine(x);
}

int z = -1;

do
{
    Console.WriteLine(z);
    z--;
}
while (z <= 20 && z >= 0) ;

/*
int maxIterations = 1000000;
int i = 0;
int stopCondition = 500;
while (i < maxIterations)
{
    Console.WriteLine(i);
    
    if ( i == stopCondition) break;

    i++;
} */

for (int i = 0; i <= 10; i++)
{
        Console.WriteLine(i * i);
}


