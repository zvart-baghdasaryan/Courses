using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text;
//Class
using coreObjectOrientedConcepts;
using coreObjectInheritance;
using bankRelated;
using bankAccount;
using calculate;
using intExt;
using partialClass;
using userClass;
using stringIndexer;
using enamDemo;
using calculation;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.CompilerServices;

// Hello World
Console.WriteLine("Hello, World!");

// Data Types
string name = "King Kochhar";
int age = 23;
float discount = 10005.5F;
double contactNumber = 1234567890;
char gender = 'M';
Boolean isValid = true;

Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Discount: " + discount);
Console.WriteLine("Contact Number: " + contactNumber);
Console.WriteLine("Gender: " + gender);
Console.WriteLine("Is Valid: " + isValid);

// Operators
float baseSalary = 5000;
float hra = 0.30F;
float netSalary = (baseSalary - (baseSalary * hra));
Console.WriteLine("Base Salary: " + baseSalary);
Console.WriteLine("Net Salary: " + netSalary);

int tempreture = 50;
if(tempreture < 20)
    Console.WriteLine("Its Very Cold Outside.");
else
    Console.WriteLine("Its Moderate Outside.");

bool isLoggedIn = true;
bool isEmailVerified = true;
bool cardInfo = true;
if(isLoggedIn && isEmailVerified && cardInfo)
    Console.WriteLine("Allowed to make a purchase");
else
    Console.WriteLine("Stop purchase");

// Conditional Statements
//if-else
bool isAuthenticated = true;
if(isAuthenticated)
    Console.WriteLine("You are logged In.");
else
    Console.WriteLine("You are not logged In.");

string result = isAuthenticated?"You are logged In.":"You are not logged In.";
Console.WriteLine(result);

//if-else-if
if(tempreture < 20)
    Console.WriteLine("Its Very Cold Outside.");
else if(tempreture >= 20 && tempreture <= 50)
    Console.WriteLine("Its Moderate Outside.");
else
    Console.WriteLine("Its too hot Outside.");

//switch
string userType = "admin";
switch(userType)
{
    case "admin":
        Console.WriteLine("You have full access.");
        break;
    case "subadmin":
        Console.WriteLine("You can create or delete courses");
        break;
    case "user":
        Console.WriteLine("You can access the courses.");
        break;
    default:
        Console.WriteLine("Trial User");
        break;
}

//do-while
int i = 100;
do
{
    Console.WriteLine("Hi");
    i++;
}while (i < 5);

//foreach
List<string> names = new List<string> {"a", "b"};
foreach (string n in names)
{
    Console.WriteLine(n);
}


//Loops
string[] namess = new string[5] {"King Kocchhar", "Sarah Bowling", "John Smith", "Roger Lee", "James Lee"};

//for
for(int j = 0; j < namess.Length; j++)
   Console.WriteLine(namess[j]);

//while
int z = 0;
while(z < namess.Length)
{
    Console.WriteLine(namess[z]);
    z++;
}

//Jump Statements
//break
for(int j = 0; j <= 10; j++)
{
    if(j==5) break;
    Console.WriteLine("Hello World" + j);
}

//continue
for(int j = 0; j <= 10; j++)
{
    if(j==5) continue;
    Console.WriteLine("Hello World" + j);
}

//goto
switch(userType)
{
    case "admin":
        Console.WriteLine("You have full access.");
        goto case "user";
    case "subadmin":
        Console.WriteLine("You can create or delete courses");
        break;
    case "user":
        Console.WriteLine("You can access the courses.");
        break;
    default:
        Console.WriteLine("Trial User");
        break;
}

//Arrays
int[] marks = new int[5] {25, 50, 55, 60, 40};
/*
marks[0] = 25;
marks[1] = 50;
marks[2] = 55;
marks[3] = 60;
marks[4] = 40;
*/
foreach (int mark in marks)
    Console.WriteLine(mark);

int[,] multiArray=new int[3, 4]{{1,2,3,4}, {1,2,3,4}, {1,2,3,4}};
/*
multiArray[0,0] = 23;
...
*/
for(int j = 0; j < 3; j++)
{
    for(int jj = 0; jj < 4; jj++)
    {
        Console.WriteLine(multiArray[j,jj] + "\t");
    }
    Console.WriteLine();
}

int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[2];
jaggedArray[1] = new int[3];


//Strings
string str1 = "Hello World";
string str2 = "C# Programming";
Console.WriteLine(str1);
Console.WriteLine(str1.Length);
string str3 = string.Concat(str1, str2);
Console.WriteLine(str3);
Console.WriteLine(str1.Equals(str2));

//Immutable String
/*
string s1 = "C# Programming";
string s2 = "Java Programming";
*/

//Mutable String
/*
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("C# Programming");
stringBuilder.Append("Java Programming");
*/

//Classes and Objects
Student student = new Student();
student.acceptDetails();
student.displayDetails();

Student student1 = new Student(102, "Karthik");
student1.displayDetails();

//Inheritance
Marks obj = new Marks();
obj.accept();
obj.display();


//Abstract Classes
SavingAccount savingAccount = new SavingAccount();
savingAccount.deposit();
savingAccount.withdraw();
savingAccount.balance();
savingAccount.getMessage();

//Interfaces
SavingAcc savingAcc = new SavingAcc();
savingAcc.deposit();
savingAcc.withdraw();
savingAcc.balance();
savingAcc.openAccount();
savingAcc.closeAccount();

//Static Class
Console.WriteLine(Calculate.increment());
Console.WriteLine(Calculate.increment());
Console.WriteLine(Calculate.increment());

Console.WriteLine(Calculate.decrement());

//Extension Method
int number = 100;
bool res = number.IsGreaterThan(1000);
Console.WriteLine(res);

//Partial Class
var emp = new Employee();
Console.WriteLine(emp.EmpId);
Console.WriteLine(emp.EmpName);
emp.EmployeeDetails();

//Property
User user = new User();
user.Name = "King Kochar";
Console.WriteLine(user.Name);
Console.WriteLine(user.CompanyName);

//Indexer
StringIndexerType stringIndexerType = new StringIndexerType();
stringIndexerType[0] = "String One";
stringIndexerType[1] = "String Two";
stringIndexerType[2] = "String Three";
stringIndexerType[3] = "String Four";

for(int f=0; f<10; f++)
    Console.WriteLine(stringIndexerType[f]);


//Enum
EnumDemo enumDemo = new EnumDemo();
enumDemo.displayWeekDays();

//Handling Exceptions
Calculation calculation = new Calculation();
calculation.calculate();


//Anonymous Type
var objAn = new
{
    firstName = "King",
    lastName = "Kochhar",
    salary = 12000,
    address = new {streetName = "Civil Lines", city = "Delhi"},
    projects = new[]
    {
        new {projectName = "ECommerce", projectDuration = "40 Hours"},
        new {projectName = "Admin Portal", projectDuration = "25 Hours"},
        new {projectName = "Accounting", projectDuration = "30 Hours"}
    }
};

Console.WriteLine(objAn.firstName);
Console.WriteLine(objAn.lastName);
Console.WriteLine(objAn.salary);
Console.WriteLine(objAn.address);
Console.WriteLine(objAn.address.streetName);
foreach(var project in objAn.projects)
{
    Console.WriteLine(project.projectName + ":" + project.projectDuration);
};