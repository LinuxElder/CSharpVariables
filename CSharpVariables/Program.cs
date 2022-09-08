﻿// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");

// SYNTAX[ DataType variableName = value; ]
/* NAMING RULES
 Variables must start with underscore or letter
 Variables cannot contain spaces
 variables can contain numbers
 Cannot contain symbols (accept underscore) */

// EXAMPLE
string myname = "Simbarashe Marimo";
int myage = 25;
Console.WriteLine("My name is " + myname + " and I am " + myage + " years old.\n");

// Arrays
/* Arrays are similar to variables, but can hold more than one value.
SYNTAX
DataType[ ] ArrayName = { Comma Separated Values } // Array of any size
DataType[] ArrayName = new DataType[3] {Command Separated Values } //Expects 3 values */

// EXAMPLE
string[] BestGames = { "GTA 5", "Fifa 2022" };
string[] BestMovies = new string[3] { "Fantastic Beasts", "22 Jump Street", "How To Train Your Gragon" };
Console.WriteLine(BestGames[0]);
Console.WriteLine(BestMovies[0]);

//STRINGS
/* CONCATENATION
Concatenation is done through the + operator. */

// EXAMPLE
Console.WriteLine("Hello " + "World");

// New Line
// Example 
Console.WriteLine("Hello \n" + "World");

