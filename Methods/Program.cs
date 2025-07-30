// 1. Make a method that takes three numbers of type int 
// 2. returns the sum of how much each number differs from the calculated average in the form 
// of a number of the type int. 
     //Say that you have three numbers 4, 6, 5. Then 
     // the average will be 5 (as calculated with 15/5). 

//The first number differs 1 (as calculated the difference between 4 and 5)
// The second also 1 and the last 0. The returned sum is therefore 2.  
// Example data: 
// 9, 43, 89 => 84 
// 20, 20, 20 => 0 

int a, b, c;

a = 20;
b = 33;
c = 50;

Console.WriteLine("The total difference to the average value of all numbers is: " + AverageDiff());

int AverageDiff()
{
     int averageValue = (a + b + c)/3;
     Console.WriteLine("The average value is: " + averageValue);

     int aDiff = averageValue - a;
     int bDiff = averageValue - b;
     int cDiff = averageValue - c;

     int aExtract = aDiff < 0 ? -aDiff : aDiff;
     int bExtract = bDiff < 0 ? -bDiff : bDiff;
     int cExtract = cDiff < 0 ? -cDiff : cDiff;
     int combinedDifference = aExtract + bExtract + cExtract;
     
     return combinedDifference;
}