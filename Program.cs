//testing the use of objects - these have been available from the first version of C# but from C# 2.0
// onwards, the existence of generics offers a better alternative

object height = 1.96; //storing a double in an object
object name = "John"; // storing a string in an object
Console.WriteLine($"{name} is {height} metres tall.");

//int length1 = name.Length //gives a compile error!
int length2 = ((string)name).Length; //tell compiler it is a string
Console.WriteLine($"The name {name} has {length2} characters.");

//storing a string in a dynamic object
//string has a length property
dynamic something = "Vladislav";

//int does not have a length property
//something = 12;
int halibut = 10;

Console.WriteLine($"I have {halibut} halibut");

//an array of any type has a Length property
//something = new[] {3,5,7};
int[] plaice = {1 , 2 , 3};
//Console.WriteLine($"{plaice:N0} is the magic number");

//this compiles but would throw an exception at run-time
//if you later store a data type that does not have a 
//property called Length
Console.WriteLine($"Length is {something.Length}");

