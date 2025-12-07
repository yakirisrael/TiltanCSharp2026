// See https://aka.ms/new-console-template for more information

/*
 
 
 Author: yakir
 Date: 30.11.25
 Summary: this doing amazing logic of average between
 2 floats
 
 */


// this lines read the first score
Console.WriteLine("Enter first score");
string firstScore = Console.ReadLine();

float firstScoreFloat = float.Parse(firstScore);

// this lines read the second score
Console.WriteLine("Enter second score");
string secondScore = Console.ReadLine();
float secondScoreFloat = float.Parse(secondScore);

float avg = (firstScoreFloat + secondScoreFloat) / 2.0f;
Console.WriteLine("The average is: " + avg);

