namespace TaskToTipe;

class Program
{
    static void Main(string[] args)
{
	string name = Console.Readline();
	int age = int.Parse(Console.Readline());
	int course = int.Parse(Console.Readline());
	string groupNumber = Console.Readline();
	bool hasHomePet = false;
	
	Console.WriteLine("Ankete:");
	Console.WriteLine("You name: " + name);
	Console.WriteLine("You are " + age + " years old");
	Console.WriteLine("You in " + course + " course and in " + groupNumber + " group");
	Console.WriteLine("You has home pet:" + hasHomePet);
    }
}

