// Example 01

Person obj1 = new Person();

obj1.Name = "Arlyson";
// obj1.Presentation();]

//Example 02

Person obj2 = new();
obj2.Name = "Juliana";
// obj2.Presentation();

//Example 03

Person obj3 = new()
{
    Name = "Luke",
    Age = 10
};
string rtn = obj3.VerifyAge();
Console.WriteLine(rtn);