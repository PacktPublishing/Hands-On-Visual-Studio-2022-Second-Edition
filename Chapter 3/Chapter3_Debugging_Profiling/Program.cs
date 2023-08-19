using Chapter3_Debugging_Profiling;

var random = new Random();
Console.WriteLine($"You got the number {random}");

//Conditional breakpoins demo
for (int i = 0; i < 100; i++)
{
    Console.WriteLine(i);
}

StopHere();

var person = new Person { Age = 10, Name = "John" };
Console.WriteLine(person.Name);
person.Name = "Peter";


CommonMethod("Before invocation of NewMethod()");
NewMethod();
CommonMethod("After invocation of NewMethod()");


var breakpointGroups = new BreakpointGroupsDemo();
breakpointGroups.Run();


//
var performanceDemo = new PerformanceDemo();
performanceDemo.Run();
Console.WriteLine("Press any key to exit...");


void StopHere()
{
    Console.WriteLine("Hi!");
}

void NewMethod()
{
    Console.WriteLine("New Method");
}

void CommonMethod(string message)
{
    Console.WriteLine(message);
}


class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}