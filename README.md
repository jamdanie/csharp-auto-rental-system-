# AutoRental — C# Console Application

A simple C# console application that models an auto rental inventory using a
POCO-style `Car` class. This project was created as a school assignment to practice
object-oriented programming fundamentals.

## Project Overview
The application represents a single-user auto rental system specializing in
classic muscle and exotic cars from the 1970s and 1980s. Each car in inventory
is represented by a `Car` object with descriptive properties and rental pricing.

## Features
- POCO (`Plain Old C# Object`) design for the `Car` class
- Default and fully-parameterized constructors
- Auto-implemented properties
- Overridden `ToString()` method for formatted output
- Console-based test driver to verify object behavior

## Key Concepts Practiced
- Classes and objects
- Constructors and constructor overloading
- Properties (`get` / `set`)
- Method overriding (`ToString`)
- Object initialization and output formatting

## How It Works
- `Program.Main` acts as a test driver
- Multiple `Car` objects are created using different constructors
- Inventory data is printed using both direct property access and `ToString()`

## How to Run
1. Open the solution in **Visual Studio**
2. Run the program using **F5**
3. View the formatted inventory output in the console

## Sample Inventory
- 1965 Ford Mustang 2+2
- 1971 Pontiac GTO
- 1979 Ferrari Boxer
- 1980 Porsche 911 Turbo

