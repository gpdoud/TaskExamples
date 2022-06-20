// See https://aka.ms/new-console-template for more information
using Task2;

Console.WriteLine("Ready!");

Task2.Utility util = new Task2.Utility { value = 6 };

Task<long> tfactorial = Task<long>.Run(util.Factorial);
tfactorial.Wait();

Console.WriteLine($"{util.value}! is {tfactorial.Result}");

util.n = 2_000_000_000;

Task<long> tsum = new Task<long>(util.Sum1ToN);

tsum.Start();
Console.WriteLine("Started ...");
tsum.Wait();
Console.WriteLine("Ended ...");

Console.WriteLine($"Sum number 1 to {util.n} is {tsum.Result}");

