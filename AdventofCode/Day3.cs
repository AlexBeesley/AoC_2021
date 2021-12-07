using System;

public class Day3
{
	public void BinaryDiagnosticMain()
	{
		string[] inputs = File.ReadAllLines(@"C:\Users\beesleyd\source\repos\AdventofCode\AdventofCode\inputs\day3input.txt");
        int[] OnBit = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] OffBit = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] gammaByte = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] epsilonByte = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        foreach (var i in inputs)
        {
            for (int j = 0; j < 12; j++)
            {
                if (i[j] == '1')
                {
                    OnBit[j]++;
                }
                else
                {
                    OffBit[j]++;
                }
            }
        }
        for (int i = 0; i < 12; i++)
        {
            if (OnBit[i] > OffBit[i])
            {
                gammaByte[i] = 1;
            }
            else
            {
                epsilonByte[i] = 1;
            }
        }
        Console.WriteLine($"Gamma Rate: {string.Concat(gammaByte)} Epsilon Rate: {string.Concat(epsilonByte)}");
        int binGamma = Convert.ToInt32(string.Concat(gammaByte), 2);
        int binEpsilon = Convert.ToInt32(string.Concat(epsilonByte), 2);
        int PowerConsumption = binGamma * binEpsilon;
        Console.WriteLine($"The power consumption is: {PowerConsumption}");
    }
}
