Day1 day1 = new Day1();
Day2 day2 = new Day2();
Day3 day3 = new Day3();

Console.WriteLine("Advent Of Code");
Console.WriteLine(@"
Please Select a day from the following options:
Day 1: Sonar Sweep --------------------------------------------------------------------------------- 1
Day 2: Dive! --------------------------------------------------------------------------------------- 2
Day 3: Binary Diagnostic --------------------------------------------------------------------------- 3
");
Console.Write(">>>  ");
string? Selection = Console.ReadLine();

if (Selection == "1")
{
    Console.Clear();
    day1.SolarSweepMain();
}

if (Selection == "2")
{
    Console.Clear();
    day2.DiveMain();
}

if (Selection == "3")
{
    Console.Clear();
    day3.BinaryDiagnosticMain();
}