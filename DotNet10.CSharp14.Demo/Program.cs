using DotNet10.CSharp14.Demo;

Console.WriteLine("Hello, C# 14!");
Console.WriteLine("--------------------------");

# region Null-conditional assignment
var nullConditionalAssignment = new NullConditionalAssignment();
Console.WriteLine("Null-conditional assignment:");
nullConditionalAssignment.DemoBeforeCSharp14();
nullConditionalAssignment.DemoCSharp14();
Console.WriteLine("--------------------------");
#endregion

#region Extension members
Console.WriteLine("Extension method example:");
string name = "Henrique";
bool capitalized = name.IsCapitalized();
Console.WriteLine($"Is capitalized: {capitalized}");

Console.WriteLine("Extension method example - Order:");
var order1 = new Order { Status = "Processed" };
order1.PrintStatusExtensionMethodDemo();
order1.MarkAsProcessedExtensionMethodDemo();
order1.PrintStatusExtensionMethodDemo();

Console.WriteLine("Extension member example - Order:");
var order2 = new Order { Status = "Processed" };
order2.PrintStatusExtensionMemberDemo();
order2.MarkAsProcessedExtensionMemberDemo();
order2.PrintStatusExtensionMemberDemo();
Console.WriteLine($"Uppercase Status: {order2.UppercaseStatus}");

Console.WriteLine("--------------------------");
#endregion
