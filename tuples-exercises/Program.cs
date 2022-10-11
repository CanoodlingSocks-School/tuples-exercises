// Tuples exercises

var myTuple = ("R2-D2", 2000, 16);
Console.WriteLine($"{myTuple.Item1}, {myTuple.Item2}, {myTuple.Item3}");

Console.WriteLine("---------------------------------------------");

// Destructed tuple
Console.WriteLine("Destructed tuple\n");

(string name, int age) = ("Daniela", 28); 
Console.WriteLine($"{name} {age}");

Console.WriteLine("---------------------------------------------");

//Tuples in a method
Console.WriteLine("Tuples in a method\n");

(int x, int y, _) = GetTuple();
Console.WriteLine($"{x}, {y}");

(int, int, int) GetTuple()
{
    return (1, 2, 3);
}
Console.WriteLine("---------------------------------------------");

//Another example of using tuples in methods
Console.WriteLine("Another example of using tuples in methods\n");

(double, double) GetHomePosition()
{
    return (58.321167, 13.228834);
}

(double, double) myHomePosition = GetHomePosition();
Console.WriteLine($"{myHomePosition.Item1} - {myHomePosition.Item2}");