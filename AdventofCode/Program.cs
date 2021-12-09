Day1 day1 = new Day1();
Day2 day2 = new Day2();
Day3 day3 = new Day3();

Console.WriteLine("Advent Of Code 2021 by Alex Beesley");
Console.WriteLine(@"
Please Select a day from the following options:
Day 1: Sonar Sweep --------------------------------------------------------------------------------- 1
Day 2: Dive! --------------------------------------------------------------------------------------- 2
Day 3: Binary Diagnostic --------------------------------------------------------------------------- 3
");
Console.Write(">>>  ");
string? Selection = Console.ReadLine();
Console.Clear();


if (Selection == "1")
{
    day1.SolarSweepMain();
}

if (Selection == "2")
{
    day2.DiveMain();
}

if (Selection == "3")
{
    day3.BinaryDiagnosticMain();
}