// Hello World
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;

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