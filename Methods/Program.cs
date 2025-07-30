Console.WriteLine("Write three whole numerical values to calculate the median value: ");
int inputA = Console.ReadLine();
int inputB = Console.ReadLine();
int inputC = Console.ReadLine();

MedianReturn(inputA, inputB, inputC);

int MedianReturn(int a, int b, int c)
{
     a = inputA;
     b = inputB;
     c = inputC;

     Console.WriteLine("You have chosen the numbers " + a + ", " + b + "and" + c + ".");   
     int median = (a+b+c)/3;
     return median;  
}