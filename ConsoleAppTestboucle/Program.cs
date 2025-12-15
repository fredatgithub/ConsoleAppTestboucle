using System;
using System.Diagnostics;
using System.IO;

namespace ConsoleAppTestboucle
{
  internal class Program
  {
    static void Main()
    {
      // This is a simple console application that demonstrates a loop
      int end = 400_000;
      Stopwatch chrono = new Stopwatch();
      chrono.Start();
      for (int i = 1; i <= end; i++)
      {
        for (int j = i; j <= end; j++)
        {
          Console.WriteLine($"Number: {i} and number j: {j}");
        }
      }

      chrono.Stop();
      // print the elapsed time in seconds, minutes, and hours
      var elapsedInSeconds = $"Elapsed time: {chrono.Elapsed.TotalSeconds} seconds";
      var elapsedInMinutes = $"Elapsed time: {chrono.Elapsed.TotalMinutes} minutes";
      var elapsedInHours = $"Elapsed time: {chrono.Elapsed.TotalHours} hours";

      Console.WriteLine(elapsedInSeconds);
      Console.WriteLine(elapsedInMinutes);
      Console.WriteLine(elapsedInHours);

      try
      {
        using (var sw = new StreamWriter("boucle400K.txt"))
        {
          sw.WriteLine("To loop from 1 to 400_000 in i and then in j from i to 400k, it takes");
          sw.WriteLine(elapsedInSeconds);
          sw.WriteLine(elapsedInMinutes);
          sw.WriteLine(elapsedInHours);
        }
      }
      catch (Exception exception)
      {
        Console.WriteLine("An error occurred while writing to the file: " + exception.Message);
      }

      // Wait for user input before closing the console window
      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }
  }
}
