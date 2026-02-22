# Polymorphism
- Polymorphism is a Greek word that means multiple forms of shapes.
- You can use polymorphism if you want to have multiple forms of one or more methods of a class with the same name.
- In C#, Polymorphism can be achived in two ways:
    - Compile-time Polymorphism / Static Polymorphism
    - Runtime Polymorphism / Dynamic Polymorphism

When one task performed by different ways, then it is called Polymorphism.

**Compile-Time Polymorphism**
- In this, the compiler identifies which method is being called at the compile time.
- In C#, Compile-time Polymorphism can be achived two ways:
    - Method Overloading
    - Constructor Overloading

**Method Overloading**
- In a C# class, we can create methods with the same name in a class if they have:
    - different numbers of parameter
    - types of paramete
- Method overloading is also known as early binding or static binding.
- because which method to call is decided at compile time, early than the runtime.
- Ic C#, we can overload method, constructors and indexed properties.
- It is because these members have parameters only.

- The following example demonstrates the method overloading by defining multiple Print() methods with a different number of parameters of the same type.
```
class ConsolePrinter
{
    public void Print(string str){
        Console.WriteLine(str);
    }
    public void Print(string str1, string str2){
        Console.WriteLine($"{str1}, {str2}");
    }
    public void Print(string str1, string str2, string str3){
        Console.WriteLine($"{srt1}, {str2}, {str3}");
    }
}
```

**Method Overriding**
- In Method Overriding, Derived class defines same method as defined in its base class.
- It is used to achieve runtime polymorphism.
- Enables you to provide implementation of method which is already provided by its base class.
- You need to use virtual keyword with base class method and override keyword with derived class method.

Examle:
- The Animal class has a method called MakeSound, which is marked as virtual.
- This menas that subclasses are allowed to override this method.
- The Dog class overrides the Make Sound method and provides a different implementation.
- When MakeSound method is called on a Dog object, it will print "The dog barks".

```
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks");
    }
}
```

# Abstract Class
- An abstrcat class is a class that cannot be instantiated.
- Instead, it derves as a base class for classes to inherit from.
- They are used to define a common set of properties set of properties that derived classes should have.
- "abstract" keyword is used to create an abstract class.
```
//create an abstract class
abstract class Test {
    //fields and methods
}
...
//try to create an object Language
// throws an error
Test obj = new Test();
```

- An abstract class can have both abstract methods (method without body) and non-abstract methods (method with the body).
- For Example:
```
abstract class Test {
    //abstract method
    public abstract void display1();
    //non-abstract method
    public void display2() {
        Console.WriteLine("Non abstract method");
    }
}
```

**Abstract Method**
- A method that does not have a body is known as an abstract method.
- The abstract keyword is used to indicate that a method is abstract.
- An abstract method is a method that is declared,
- but not defined in a base class, and its implementation is left to the derived classes.
- An abstract method must be declared in an abstract class.
- For Example:
```
public abstract class Shape
{
    public abstract double GetArea();
}
```

# Interfaces
- An interface is similar to abstract class.
- However, unlike abstract classes, all methods of an interface are fully abstract (method without body).
- We use the interface keyword to create an interface.
- For Example:

```
interface Rectangle {
    //method without body
    void calculateArea();
}
```

Here,
- Rectangle is the name of the interface.
- By convention, interface starts with I so that we can identify it just by seeing its name.
- We cannot use access modifiers inside an interface.
- All members of an interface are public by default.
- An interface deosn't allow fields.

**Interface**
- Interfaces specify what a class must do and not how. 
- Interfaces can't have private members.
- By default all the members of Interface are public and abstract.
- Interface cannot contain fields because they represent a particular implementation of data.
- Multiple inheritance is possible with the help of Interfaces but not with classes.

**Advantages of Interface**
- It is used to achive loose coupling.
- It is used to achieve total abstraction.
- To achieve component-based programming.
- To achieve multiple inheritance and abstraction.
- Interfaces add a plug and play like architecture into applications.

# Static Classes & Methods
- Static means something which cannot be instantiated
- You cannot create an object of static class,
- and cannot access static members using an object.
- C# static class cannot contain instance constructors.
- Apply static modifier before the class name and after access modifier to make a class static.
- Syntax:
```
static class classname
{
    //static data members
    //static methods
}
```

Example:
Below, the Calculator class is a static. All the members of it are also static.
```
public static class Calculator
{
    private static int _resultStorage = 0;
    public static string Type = "Arithmetic";
    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }
    public static void Store(int result)
    {
        _r_esultStorage = result;
    }
}
```

**Advantages of Static Class**
- You will get an error if you declare any member as a non-static member.
- When you try to create an instance to the static class, it again generates a compile time error
- because the static members can be accessed directly with thie class name.
- Static keyword is used before the class keyword in a class definition to declare a static class.
- Static class members are accessed by the class name followed by the member name.

# Extension Methods
- Extension methods, as the name suggested, are additional methods.
- These methods create and add new methods to existing class without creating new child class.
- They are the special type of static methods that can be called as instance methods.
- We can add extension methods in both predefined classes and user created custom classes.
```
int i = 10;
bool result = i.IsGreaterThan(100); //returns false
```
In the following example, IsGreaterThan() in an extension method for int type.


We need to consider the following points to define an extension method.
- An extension method should be a static method.
- It must have this keyword associate with class name.
- The class name should be the first parameter in the parameter list.

# Partioal Class and Partial Methods

## Partial Class
- Partial Class is a unique feature of C#.
- You can split the implementation of a class, a struct, a method, or an interface in multiple .cs files
- The compiler will combine all the implementation from multiple .cs files when the program is compiled.
- The partial keyword is used to build a partial class.
- Syntax:
```
public partial Class_name
{
    //code
}
```

**Advantages Of Partial Class**
- Multiple developers can work simultenously in the same class in different files.
- You can split the UI of design code to read and understand the code.
- When you were working with automatically generated code.
- the code can be added to class without having to recreate the source file like in Visual studio.
- You can also maintain your application in an effecient manner by compressing large classes into small ones.

## Partial Methods
- A partial class may contain a partial method.
- One part of the class contains the signature of the method.
- An optional implementation may be defined in the same part or another part.
- If the implementation is not supplied, then method and all calls are removed at compile time.
- Both declaration and implementation of a method must have the partial keyword.
- Syntax:
```
partial void method_name
{
    //Code
}
```

# Property
- Property is a class member that exposes the class' private fields.
- Internally, C# properties are special methods called accessors.
- It has two accessors, a get property accessor or a getter and a set property accessor or a setter.
- A get accessor returns a property value, and a set accessor assigns a new value.
- The value keyword represents the value of a property.
- The general form of a declaring a property is as follows:

```
{
    get{ }
    set{ }
}
```

**Usage of Properties**
- C# Properties can be read-only or write-only.
- We can have logic while setting value in the C# Properties.
- We make fields of a class private, so that fields can't be accessed from outside the class directly.

Types of Properties:
- Read-Write: Accessors: get; set;
- Read-Only: Accessors: get;
- Write-Only: Accessors: set;
- Auto-Implemented: Accessors: get; set;

# Indexer
- An indexer allows an object to be indexed such as an array.
- When you define an indexer for a class, this class behaves similar to virtual array.
- You can then access the instance of this class using the array access operatory([]).
- A one dimensional indexer has the following syntax:
```
element-type this[int index] {
    //The get accessor.
    get {
        //return the value specified by index
    }
    set {
        // set the value specifid by index
    }
}
```

## Indexer vs. Properties
**Indexer**
- Indexers are created with this keyword.
- Indexers are identified by signature.
- Indexers are accessed using indexes.
- Indexer are instance member, so can't be static.
- A get accessor has the same formal parameter list as the indexer.
- A set accessor has the same formal parameter list as the  indexer, in addition to the value parameter.

**Properties**
- Properties don't require this keyword.
- Properties are identified by their names.
- Properties are accessed by their names.
- Properties can be static as well as instance members.
- A get accessor of a property has no parameters.
- A get accessor of a property contains implicit value parameter.

# Enum in C#
- An enum is a user-defined data type that has a fixed set of related values.
- We use enum keyword to create an enum.
```
enum Months
{
    May,
    June,
    July
}
```

# Exception Handling
- An execption is an unexpected event that occurs during program execution.
- They abnormally terminate flow of program instructions, we need to handle those exceptions.
- The actions to be performed in case of occurrence of an exception is not known to program.
- In such a case, we create an exception object and call the exception handler code.
- Responding or handling exception is called Exception Handling.

**Exception Handler Keywords**
**try**     - Used to define a try block. This block holds the code that may throw an exception.
**catch**   - Used to define a catch block. This block catches exception thrown by the try block.
**finally** - Used to define the finally block. This block holds the default code.
**throw**   - Used to throw an exception manually.

**Try-Catch Block**
- The *try..catch** click is used to handle exceptions in C#.
- Syntax:
```
try
{
    //code that may raise an exception
}
catch (Exception e)
{
    //code that handles the exception
}
```
- Here, we place the code that might generate an exception inside the try block.
- The try block then throws the exception to the catch block which handles the raised exception.

**Try-Catch-Finally Block**
- You can use finally block with try and catch block.
- The finally block is always executed whether there is an exception or not.
- Sytax:
```
try
{
    // code that may raise an exception
}
catch (Exception e)
{
    // code that handle the exception
}
finally
{
    // this code is always executed
}
```

The finally block is executed:
- after try and catch block - when exception has occurred
- after try block - when exception doesn't occur


# Anonymous Type
- It is introduced in C# 3.0.
- Anonymous types allow us to create an object that has read only properties.
- Anonymous object is an object that has no explicit type.
- C# compiler generates type name and is accessible only for the current block of code.
- These are best for the "use and throw" types.
- To create anonymous types, we must use new operator with an object initializer.

- In the below example, we are creating anonymous types by using "new" keyword with the object initializer.
```
var anonyInfo = new
{
    Fname = "abc",
    Lname = "xyz"
};
Console.WriteLine("Fname : " + anonyInfo.Lname;)
```

# Delegates
- A deligate is a pointer to a method.
- But it is object-oriented, secured and type-safe than function pointer.
- That means, a deligate holds the address of a method which can be called using that deligate.
- For static method, deligate encapsulates method only.
- But for instance method, it encapsulates method and instance both.
- There are three steps involved while working with deligates:
    - Declare a delegate
    - Set a target method
    - Invoke a delegate

**Types of Delegates**
- **SingleCast delegates** - A single function or method is referred as a Delegate.
- **MultiCast Delegates** - Refers to the delegation of multiple functions or methods.


# Events
- Events in C#, being a subset of delegates are defined by using... delegates.
- An ecents is an excapsulates delegate.
- To raise an event in C# you need a bublisher,
- and to receive and handle an event you need a subscriber or multiple subscribers.
- There are usually implemented as publisher and subscriber classes.
- Syntax:
```
event delegate_name event_name;
```

# Anonymous Method
- As the name suggests, an anonymous method is a method without a nema.
- Anonymous methods can be defined using the delegate keyword.
- They can be assigned to a variable of delegate type.
- Anonymous methods can access variable defined in an outher function.
- Example:
```
public delegate void Print(int variable);

static void Main(string[] args)
{
    Print print = delegate(int val)
    {
        Console.WriteLine("Inside Anonymous method. Value: {0}");
    };

    print(500);
}
```

# Lambda Expression
- C# Lambda Expression is a short block of code that accepts parameters and returns a value.
- It is defined as an anonymous function (function without a name).
- Lambda expressions in C# are used like anonymous functions,
- with the differece that in Lambda expressions you don't need to specify the type of the value that you input thus making it more flexible to use.
- The '=>' is the labmda operator which is used in all lambda expressions.
- The Lambda expression is devided into two parts,
    - the left side is the input and the right is the expression.

**Define a Lambda Expression**
- We can define lambda expression in C# as,
```
(parameterList) => lambda body
```

Here,
- **parameterList** - List of input parameters
- **=>** - A Lambda Operator
- **Lambda body** - Can be an expression or statement

**Types of Lambda Expression**
The Lambda Exprssions can be of two types:
- **Expression Lambda:** Consists of the input and the expression.
- Syntax:
```
input => expression;
```
- **Statement Lambda:** Consists of the input and a set of statements to be executed.


# Expression Tree
- Expression tree is nothing but expression arranged in a tree-like data structure.
- Each node in a expression tree is an expression.
- Expression tree is an in-memory representation of a lambda expression.
- It holds the actual elements of the query, not the result of the query.
- The expression tree makes the structure of the lambda expression transparent and explicit.
- You can interact with the data in expression tree just as you can with any other data structure.
- Syntax:
```
Expression<TDelegate> name = lambdaExpression;
```

Expression trees can be created by using followingg two ways:
- Using Expression Lambda
- Using Expression Tree API

**Expression Tree Structure**
The simple structure of an **Expression<TGelegate>** has four properties as given below:
- **Body:** The body of the expression.
- **Parameters:** The parameters of the lambda expression.
- **NodeType:** The type of node in the tree
- **Type:** The type of the expression
