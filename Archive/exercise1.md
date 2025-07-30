Console.WriteLine("Write three whole numerical values to calculate the median value: ");
int inputA;
while(!int.TryParse(Console.ReadLine(), out inputA))
{
     Console.WriteLine("That's... not a number... you can do this. I believe in you, try again: ");
}
int inputB;
while(!int.TryParse(Console.ReadLine(), out inputB))
{
     Console.WriteLine("That's... not a number... you can do this. I believe in you, try again: ");
}
int inputC;
while(!int.TryParse(Console.ReadLine(), out inputC))
{
     Console.WriteLine("That's... not a number... you can do this. I believe in you, try again: ");
}


MedianReturn(inputA, inputB, inputC);
int result = MedianReturn(inputA, inputB, inputC);
Console.WriteLine("\nYou have chosen the numbers " + inputA + ", " + inputB + " and " + inputC + ".");   
Console.WriteLine("\nThe median is: " + result);

// While loop to get it right


int MedianReturn(int a, int b, int c)
{
     a = inputA;
     b = inputB;
     c = inputC;

     int median = (a+b+c)/3;
     return median;  
}