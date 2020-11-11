using static System.Console;
using POCO.Classes;
// 1. Remove top level main method!
WriteLine("Hello World!");

// 2. target types
POCO.Classes.Person personInstance = new();
WriteLine($"Name: {personInstance.Name}, Age: {personInstance.Age}");

//3. Logical and property patterns
WriteLine("Enter y or n:");
var nameInput = ReadKey();
if (nameInput.KeyChar is 'y' or 'n') {
    WriteLine("\n You entered :{0}",nameInput.KeyChar);
}

WriteLine("Enter name but remember that it must have atleast 5 characters!");
var name = ReadLine();
if (name is not {Length: > 5 }) WriteLine($"{name} must be greater than 5 character.[INPUT FAILED!]");
else WriteLine("well done you entered the correct input!");

WriteLine($"You have to go to {ValidateAge(3)}");

string ValidateAge(int age) => age switch {
    > 3 and <= 5 => "reception",
    > 5 and <= 10 => "primary",
    _ => "secondary"
};

//4. Records see PocoClasses

var circleInstance = new Circle(3,5);
WriteLine($"CircleX:{circleInstance.x}, CircleY: {circleInstance.y}");