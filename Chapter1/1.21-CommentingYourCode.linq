<Query Kind="Statements" />

public class HeyYou
{
	public static void Main()
	{
		string firstName; // Variable for storing the first name
		string lastName; // Variable for storing the last name

		Console.WriteLine("Hey you!");

		Console.Write/* No new line */("Enter your first name: ");
		firstName = Console.ReadLine();

		/* Display a greeting to the console
		using composite formatting. */
		
		Console.Write/* No new line */("Enter your last name: ");
		lastName = Console.ReadLine();
		Console.WriteLine("Your full name is {1} {0}", firstName, lastName);
		// This is the end
		// of the program listing
	}
}