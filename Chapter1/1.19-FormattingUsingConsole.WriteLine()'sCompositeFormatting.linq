<Query Kind="Statements" />

public class HeyYou
{
	public static void Main()
	{
		string firstName;
		string lastName;

		Console.WriteLine("Hey you!");

		Console.Write("Enter your first name: ");
		firstName = Console.ReadLine();

		Console.Write("Enter your last name: ");
		lastName = Console.ReadLine();
		Console.WriteLine("Your full name is {0} {1}", firstName, lastName);
	}
}