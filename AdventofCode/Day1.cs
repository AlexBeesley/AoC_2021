using System;
using System.Collections.Generic;

public class Day1
{
	public int DepthValue { get; set; }
	public int PreviousDepthValue { get; set; }
	public int MeasurementCount { get; set; }
	
	static Random rnd = new Random();


	public void SolarSweepMain()
	{
		Console.WriteLine("Starting Sonar Sweep...");
		Console.WriteLine($"{rnd.Next(199, 230)} [N/A - no previous measurement]");
		for (int i = 1; i < 20; i++)
        {
			Thread.Sleep(200);
			DepthValue = rnd.Next(199, 230);
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
		Console.WriteLine($"in this sweep, there was a total of {MeasurementCount} Increases.");
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
