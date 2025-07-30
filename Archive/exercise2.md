Console.WriteLine("Write two whole numerical values to evaluate which is lowest: ");

//Checks input A and whether. If it's a letter, loops until user enters number.
int inputA;
Console.WriteLine("\nNumber A: ");
while(!int.TryParse(Console.ReadLine(), out inputA))
{
     Console.WriteLine("That's... not a number... you can do this. I believe in you, try again: ");
     Console.WriteLine("\nNumber A: ");
}

//Checks input B and whether. If it's a letter, loops until user enters number.
int inputB;
Console.WriteLine("Number B: ");
while(!int.TryParse(Console.ReadLine(), out inputB))
{
     Console.WriteLine("That's... not a number... you can do this. I believe in you, try again: ");
     Console.WriteLine("Number B: ");
}

Console.WriteLine("\nYou have chosen the numbers " + inputA + " and " + inputB + ".");
string equalCheck;
int Result = lowestNumber(inputA, inputB);
string finalResult = inputA==inputB ? equalCheck : equalCheck;
Console.WriteLine("\n" + finalResult);


// While loop to get it right


int lowestNumber(int a, int b)
{
     // Declares resultCheck before use.
     int resultCheck = a < b && a != b ? a : b;

     string notEqual = "\nThe lowest number is: " + resultCheck;
     string areEqual = "\nThese numbers are equal.";

     //Compares if one is lesser and if they're equal
     equalCheck = resultCheck == a && resultCheck == b ? areEqual : notEqual;

     return resultCheck;
}