var fibonacciNumbers = new List<int> { 8, 10 };
var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
Console.WriteLine(fibonacciNumbers.Count - 1);
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
Console.WriteLine(fibonacciNumbers.Count - 2);

fibonacciNumbers.Add(previous + previous2);

foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}