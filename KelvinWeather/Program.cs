using System;
using static System.Formats.Asn1.AsnWriter;

class Program
{
	static void Main()
	{
		const int kelvin = 293; // Creating a variable to store the value of Kelvin and setting it equal to 293. This is a constant variable as it will not change.
		const int celsius = kelvin - 273; // Creating a variable to store the value of Celsius. As Celsius is 273 degrees less than Kelvin, we subtract 273 from the Kelvin value.
		int fahrenheit = (int)Math.Floor(celsius * (9.0 / 5) + 32); // Creating a variable to store the value of Fahrenheit and is calculated using this formula. Math.Floor is used to round down the Fahrenheit value.
		int newton = (int)Math.Floor(celsius * (33.0 / 100)); // Creating a variable to store the value of Newton and is calculated using this formula.

		Console.WriteLine($"The temperature is {kelvin} degrees Kelvin."); // Output the original Kelvin value to the console.
		Console.WriteLine($"The temperature is {celsius} degrees Celsius."); // Output the Celsius value to the console.
		Console.WriteLine($"The temperature is {fahrenheit} degrees Fahrenheit."); // Output the calculated Fahrenheit value to the console.	
		Console.WriteLine($"The temperature is {newton} degrees Newton."); // Output the calculated Newton value to the console.
	}
}