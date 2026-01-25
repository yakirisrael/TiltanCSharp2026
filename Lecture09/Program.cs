// See https://aka.ms/new-console-template for more information


float[,] matrix =
{
    { 1.1f, 2.2f },
    { 2.3f, 4.5f }
};

float[][] College = new float[3][];
College[0] = new float[2] { 1.1f, 2.2f };
College[1] = new float[4] {3.3f, 4.4f, 5.5f, 6.5f};
College[2] = new float[3] { 9.9f, 8.8f, 1.1f };

foreach (var myClass in College)
{
    foreach (var seat in myClass)
    {
        Console.Write(seat + "\t");
    }
    Console.WriteLine();
}

//Console.WriteLine(matrix[1, 1]);


Stack<Student> students = new Stack<Student>();
Student s1 = new Student("Offir", 10);
Student s2 = new Student("Tal", 5);
Student s3 = new Student("Kobi", 9);

students.Push(s1);
students.Push(s2);
students.Push(s3);
//students.Push(s4);

Student s = students.Peek();
Console.WriteLine("Name = " + s.Name);

s = students.Pop();
Console.WriteLine(s.Name);
s = students.Pop();
Console.WriteLine(s.Name);
s = students.Pop();
Console.WriteLine(s.Name);

Console.WriteLine("count = " + students.Count());

class Student
{
    // field
    private string name;

    public Student(string name, int grade)
    {
        this.Name = name;
        this.Grade = grade;
    }

    //property
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
                Console.WriteLine("empty name");
            
            name = value;
        }
    }

    public int Grade
    {
        get;
        set;
    }
}
