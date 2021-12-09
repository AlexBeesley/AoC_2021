using System;

public class Day3
{
    string[] inputs = File.ReadAllLines(@"C:\Users\beesleyd\source\repos\AdventofCode\AdventofCode\inputs\day3input.txt");
    int ByteLength = 12;

    int[] OnBit = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    int[] OffBit = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    int[] gammaByte = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    int[] epsilonByte = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    public void BinaryDiagnosticMain()
	{
        Logic();
        partOne();
        partTwo();
    }

    public void partOne()
    {
        Console.WriteLine($"Gamma Rate: {string.Concat(gammaByte)} Epsilon Rate: {string.Concat(epsilonByte)}");
        int binGamma = Convert.ToInt32(string.Concat(gammaByte), 2);
        int binEpsilon = Convert.ToInt32(string.Concat(epsilonByte), 2);
        int PowerConsumption = binGamma * binEpsilon;
        Console.WriteLine($"Total 1's: {binGamma}\tTotal 0's: {binEpsilon}");
        Console.WriteLine($"The power consumption is: {PowerConsumption}");
    }

    public void partTwo()
    {
        var masterInput = File.ReadAllLines(@"C:\Users\beesleyd\source\repos\AdventofCode\AdventofCode\inputs\day3input.txt").ToList();
        Console.WriteLine($"Answer is: " + CalculateOxygen(masterInput) * CalculateCO2(masterInput));
    }

    private double CalculateOxygen(List<string> input)
    {
        var oxygenInput = input.ToList();
        int[] oxygen = new int[oxygenInput[1].Length];

        for (int i = 0; i < oxygen.Length; i++)
        {
            var columnList = oxygenInput.Select(x => int.Parse(x[i].ToString())).ToList();
            oxygen[i] = columnList.Where(x => x == 1).Count() >= columnList.Where(x => x == 0).Count() ? 1 : 0;
            oxygenInput.RemoveAll(x => x[i].ToString() != oxygen[i].ToString());
        }

        return ConvertToDecimal(oxygenInput[0]);
    }

    private double CalculateCO2(List<string> input)
    {
        var co2Input = input.ToList();
        int[] coTwo = new int[co2Input[1].Length];
        int i = 0;

        while (co2Input.Count() > 1)
        {
            var columnList = co2Input.Select(x => int.Parse(x[i].ToString())).ToList();
            int ones = columnList.Where(x => x == 1).Count();
            int zeros = columnList.Where(x => x == 0).Count();

            if (ones < zeros)
            {
                coTwo[i] = 1;
            }
            else
            {
                coTwo[i] = 0;
            }
            co2Input.RemoveAll(x => x[i].ToString() != coTwo[i].ToString());
            i++;
        }

        return ConvertToDecimal(co2Input[0]);
    }

    private double ConvertToDecimal(string bin)
    {
        var reversedBinary = bin.Reverse().ToArray();
        double amt = 0;

        for (int i = 0; i < reversedBinary.Count(); i++)
        {
            amt += reversedBinary[i].ToString() == "1" ? Math.Pow(2, i) : 0;
        }

        return amt;
    }

    public void Logic()
    {
        foreach (var i in inputs)
        {
            for (int j = 0; j < ByteLength; j++)
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
        for (int i = 0; i < ByteLength; i++)
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
    }
}
