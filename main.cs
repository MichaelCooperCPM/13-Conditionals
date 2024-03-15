using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("***Conditionals***");
		Temperature();
		TwoValues();
		Difference();
		Grades();
		Console.WriteLine();
		Console.WriteLine("Program End");
	}

	static void Temperature()
	{
		Console.WriteLine();
		Console.WriteLine("Temperature");
		Console.WriteLine();
		Console.WriteLine("Please enter a temperature in degrees celsius:");
		int temp = Convert.ToInt32(Console.ReadLine());
		if (temp < 15)
		{
			Console.WriteLine("Cold");
		}
		else if (temp >= 15 && temp <=25)
		{
			Console.WriteLine("Mild");
		}
		else
		{
			Console.WriteLine("Hot");
		}
	}

	static void TwoValues()
	{
		Console.WriteLine();
		Console.WriteLine("Two Values");
		Console.WriteLine();
		Console.WriteLine("Please enter the first value:");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Please enter the second value:");
		int num2 = Convert.ToInt32(Console.ReadLine());

		if (num1 == num2)
		{
			Console.WriteLine("The two values are equal in value.");
		}
		else if (num1 > num2)
		{
			Console.WriteLine("The first value is greater than the second value.");
		}
		else if (num2 > num1)
		{
			Console.WriteLine("The second value is greater than the first value.");
		}
	}

	static void Difference()
	{
		Console.WriteLine();
		Console.WriteLine("Difference");
		Console.WriteLine();
		Console.WriteLine("Please enter the first value:");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Please enter the second value:");
		int num2 = Convert.ToInt32(Console.ReadLine());

		if (num1 == num2)
		{
			Console.WriteLine("The two values are equal in value.");
		}
		else if (num1 > num2)
		{
			int difference = num1 - num2;
			Console.WriteLine($"The first value is greater than the second value by {difference}.");
		}
		else if (num2 > num1)
		{
			int difference = num2 - num1;
			Console.WriteLine($"The second value is greater than the first value by {difference}.");
		}
	}

	static void Grades()
	{
		Console.WriteLine();
		Console.WriteLine("Grades");
		Console.WriteLine();
		Console.WriteLine("Please enter a letter grade:");
		string letterGrade = Console.ReadLine();

		switch (letterGrade)
		{
			case "A":
				Console.WriteLine("Excellent");
				break;
			case "B":
					Console.WriteLine("Very Good");
					break;
			case "C":
					Console.WriteLine("Good");
					break;
			case "D":
					Console.WriteLine("Poor");
					break;
			case "E":
					Console.WriteLine("Satisfactory");
					break;
			case "F":
					Console.WriteLine("Fail");
					break;
			default:
					Console.WriteLine("Invalid letter grade entered");
					break;
		}
	}
}
