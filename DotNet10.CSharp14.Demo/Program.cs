using DotNet10.CSharp14.Demo;

Console.WriteLine("Hello, C# 14!");
Console.WriteLine("--------------------------");

var nullConditionalAssignment = new NullConditionalAssignment();
Console.WriteLine("Null-conditional assignment:");
nullConditionalAssignment.DemoBeforeCSharp14();
nullConditionalAssignment.DemoCSharp14();
Console.WriteLine("--------------------------");

