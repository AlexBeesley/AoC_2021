Day1 day1 = new Day1();
Console.WriteLine("Advent Of Code");
Console.WriteLine(@"
Please Select a day from the following options:
Day 1: Sonar Sweep --------------------------------------------------------------------------------- 1
");
Console.Write(">>>  ");
string? Selection = Console.ReadLine();

if (Selection == "1")
{
    Console.Clear();
    day1.SolarSweepMain();
}
