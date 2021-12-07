using System;

public class Day2
{
	public void DiveMain()
	{
		string[] inputs = File.ReadAllLines(@"C:\Users\beesleyd\source\repos\AdventofCode\AdventofCode\inputs\day2input.txt");

		int[] positon = { 0, 0, 0 }; // herizontal, depth and aim
        for (int i = 0; i < inputs.Length; i++)
        {
			if (inputs[i].Contains("forward"))
            {
				string forward = inputs[i].Substring(8);
				int x = Int32.Parse(forward);
				positon[0] = positon[0] + x;
				positon[1] = positon[1] + (positon[2] * x);
            }
			else if (inputs[i].Contains("down"))
			{
				string down = inputs[i].Substring(5);
				int y = Int32.Parse(down);
				positon[2] = positon[2] + y;
			}
			else if (inputs[i].Contains("up"))
			{
				string up = inputs[i].Substring(3);
				int z = Int32.Parse(up);
				positon[2] = positon[2] - z;
			}
			Console.WriteLine($"\n{positon[0]} | {positon[1]} | {positon[2]}");
		}
		Console.WriteLine($"final herizontal postion is: {positon[0]} and final depth: {positon[1]}");
		Console.WriteLine($"answer is: {positon[0] * positon[1]}");
	}
}
