# 📦 Day 01 – OOP & SOLID with FileProcessor

This mini project is a simple file-processing application built with .NET. The goal is to refresh knowledge of the **C# language**, **Object-Oriented Programming (OOP)** concepts, and **SOLID principles**.

## 🚀 Purpose
- Review OOP concepts like `Interface`, `Inheritance`, `Abstraction`, and `Polymorphism`
- Apply SOLID principles through a real-life example
- Practice writing modular and readable code

## 🧠 Applied SOLID Principles

| Principle | Description |
|----------|-------------|
| SRP (Single Responsibility) | Each class has one specific responsibility (reading, calculating, logging) |
| OCP (Open/Closed) | New logger types can be added without modifying existing code |
| DIP (Dependency Inversion) | Classes depend on abstractions (interfaces) instead of concrete implementations |

## 🗂️ Project Structure

```
FileProcessor/
├── IFileReader.cs        # File reading interface
├── FileReader.cs         # Reads data from a file
├── ICalculator.cs        # Calculation interface
├── Calculator.cs         # Calculates average
├── ILogger.cs            # Logging interface
├── ConsoleLogger.cs      # Logs to the console
├── Program.cs            # Entry point
├── data.txt              # Sample data file
```

## 📄 Example `data.txt` Content

```
3,5,7
2,8
4,4,4,4
7,9,11,8
```

## 🛠️ How It Works

Reads each line of the file, calculates the average of numbers in each line, and logs the result to the console:

```bash
dotnet run
```

### Example Output:

```
Line average: 5.00
Line average: 5.00
Line average: 4.00
Line average: 8.75
```

## 📌 Notes

- The `data.txt` file is set to `Copy if newer` so that it's copied to the output directory during build.
- The application runs from `bin/Debug/net9.0/` and reads the file from that location.

---

Author: [Muhammet Furkan Ayhan](https://github.com/mfurkanayhan)