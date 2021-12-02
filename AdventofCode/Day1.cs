using System;
using System.Collections.Generic;
using System.IO;

public class Day1
{
	public int DepthValue { get; set; }
	public int PreviousDepthValue { get; set; }
	public int MeasurementCount { get; set; }
	
	static Random rnd = new Random();
	string[] numbers = File.ReadAllLines(@"C:\Users\beesleyd\source\repos\AdventofCode\AdventofCode\day1input.txt");

	public void SolarSweepMain()
	{
		// part 1
		Console.WriteLine("Starting Sonar Sweep...");
        Console.WriteLine($"{numbers[0]} [N/A - no previous measurement]");
        for (int i = 1; i < numbers.Length; i++)
        {
            DepthValue = Int32.Parse(numbers[i]);
            if (checkIncreased(DepthValue))
            {
                Console.WriteLine(DepthValue + "[Increased]");
                MeasurementCount++;
            }
            else
            {
                Console.WriteLine(DepthValue + "[Decreased]");
            }
            storePerviousDepthValue(DepthValue);
        }
        Console.WriteLine($"in this sweep, there was a total of {MeasurementCount} increases.");
        storePerviousDepthValue(0);

        // part 2
        for (int i = 1; i < numbers.Length - 2; i++)
		{
			int current = (Int32.Parse(numbers[i - 1]) + Int32.Parse(numbers[i]) + Int32.Parse(numbers[i + 1]));
			int next = (Int32.Parse(numbers[i]) + Int32.Parse(numbers[i + 1]) + Int32.Parse(numbers[i + 2]));
			if (current < next)
			{
				Console.WriteLine(current + "[Increased]");
				MeasurementCount++;
			}
			else
			{
				Console.WriteLine(current + "[Decreased]");
			}
		}
		Console.WriteLine($"in this second sweep, there was a total of {MeasurementCount} sum increases.");
	}

	public bool checkIncreased(int currentDepthValue)
    {
		if (currentDepthValue > PreviousDepthValue)
        {
			return true;
        }
		return false;
    }

	public int storePerviousDepthValue(int previousDepthValue)
    {
		return PreviousDepthValue = previousDepthValue;
    }
}
