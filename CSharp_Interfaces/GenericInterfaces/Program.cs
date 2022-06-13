// See https://aka.ms/new-console-template for more information

using GenericInterfaces;

//WithBoxing();
//WithoutBoxing();

var number = new Number() { Value = 10 };

//using overloaded methods of the interface
Console.WriteLine(number.CompareTo(10)); 
Console.WriteLine(number.CompareTo("10"));

//using certian type of the Generic interface
IComparable<int> comparableInt = number;
comparableInt.CompareTo(10);

IComparable<string> comparableString = number;
comparableString.CompareTo("10");


//---------------
static void WithBoxing()
{
    var x = 1;
    var y = 2;

    //Non-generic interface
    IComparable comparable = x;

    // Boxing:
    // IComparable.CompareTo(object obj) - value type int will be packed into reference type
    comparable.CompareTo(y);

    // Runtime error: 'Object must be of type Int32.'
    // Code is legal as CompareTo excpects an object, but it will throw exception as it will try to compare int and string, which is impossible without parsing; 
    comparable.CompareTo("2");

    Console.WriteLine("Boxing");
}

static void WithoutBoxing()
{
    var x = 1;
    var y = 2;

    //Generic interface with type
    IComparable<int> comparable = x;

    // No Boxing:
    // IComparable.CompareTo(object obj) - value type int will be packed into reference type
    comparable.CompareTo(y);

    // Compile error:
    // comparable.CompareTo("2"); // CS1503: Argument 1: cannot convert from string to int.

    Console.WriteLine("Without boxing");
}

//-------------------------------------