// not required to manually type libraries for 11

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This is not a working program, only notes

namespace HelloWorld
{

    // A simple program to display the words Hello World

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Read();       
        }
    }
}

// Notes: 

// Chapter 3 - Variables and Operators 

// initialize byte and int var

byte userAge = 20;
int numberOfEmployees = 510;

// initialize double, float, and decimal var w/ integral values

double intNumberOfHours = 5120;
float intHourlyRate = 60;
decimal intIncome = 25399;

// initialize double, float, and decimal var w/ non integers

double numberOfHours = 5120.5;
float hourlyRate = 60.5f;
decimal income = 25399.65m;

// char, only a single character

char grade = 'A';

// bool

bool promote = true;

// initialize multiple variables individually in same statement

byte level = 2, userExperience = 5;
byte year;      //declare the variable
year = 20;      //initialize it 

// type casting

int x = (int)20.9;
float num1 = (float)20.9;
decimal num2 = (decimal)20.9;

// Chapter 4 - Arrays, Strings and Lists

int[] userAge = { 21, 22, 23, 24, 25 };
int[] userAge2;
userAge2 = new[] { 21, 22, 23, 24, 25 };
int[] userAge3 = new int[5];
userAge3 = new int[5]; //{0, 0, 0, 0, 0}
userAge[0] = 31; //{31, 22, 23, 24, 25}
userAge[2] = userAge[2] + 20; //{31, 22, 43, 24, 25}

// Array properties and methods

int[] userAge = { 21, 22, 26, 32, 40 };
userAge.Length;

int[] source = { 12, 1, 5, -2, 16, 14 };
int[] dest = { 1, 2, 3, 4 };
Array.Copy(source, dest, 3); //dest = {12, 1, 5, 4}

int[] numbers = { 12, 1, 5, -2, 16, 14 };
Array.Sort(numbers);

int[] numbers = { 10, 30, 44, 21, 51, 21, 61, 24, 14 };
Array.IndexOf(numbers, 21);
int ans = Array.IndexOf(numbers, 21); //3
ans = Array.IndexOf(numbers, 100); //-1, does not exist 

// String

string message = "Hello World";
string anotherMessage = "";
string myName = "Hello World," + "my name is Jamie";

// String Properties and Methods

//"Hello World".Length;
string newMessage = message.Substring(2, 5); //"llo W"

string firstString = "This is Sharif";
string secondString = "Hello";

firstString.Equals("This is Sharif"); //true
firstString.Equals(secondString); //false

string[] separator = { ", ", "; " };
string names = "Peter, John; Andy,, David";
string[] substrings = names.Split(separator, StringSplitOptions.None);
//{"Peter", "John", "Andy", "", "David"}
string[] substrings = names.Split(separator, StringSplitOptions.RemoveEmptyEntries);
//{"Peter", "John", "Andy", "David"}

// Lists

int[] myArray = new int[10];

// Declare a list of integers
List<int> userAgeList = new List<int> { 11, 21, 31, 41 };

// List Properties and Methods

userAgeList.Add(51);
userAgeList.Add(61);
//{11, 21, 31, 41, 51, 61}.

userAgeList.Count(); //6

userAgeList.Insert(2, 51); //{11, 21, 51, 31, 41, 51, 61}

userAgeList.Remove(51); //{11, 21, 31, 41, 51, 61}

userAgeList.RemoveAt(3); //{11, 21, 31, 51, 61}

userAgeList.Contains(51); //true

userAgeList.Clear(); //no elements left in list

// Value Type vs Reference Type...

// Chapter 5 - Making Program Interactive

int results = 79;
Console.WriteLine("{0}! You scored {1} on your test.", "Good morning", results);


// Format Specifier F and C
Console.WriteLine("The number is {0:F3}.", 123.45678); //123.457
Console.WriteLine("Deposit = {0:C}. Account balance = {1:C}.", 2125, 12345.678); //Deposit = $2,125.00. Account balance = $12,345.68
Console.WriteLine("Microsoft".Substring(1, 3)); //icr
Console.WriteLine("Hello World".Length); //11

// Chapter 6 - Decisions and Choices

