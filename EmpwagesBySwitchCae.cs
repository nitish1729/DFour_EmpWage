// Solving using Switch Case Statement

string Welcome = "Welcome to Employee Wage Computation";
 Console.WriteLine(Welcome);


Console.WriteLine("...........................................");

 int WagePerHrs = 20;
 int FullTime = 8;
 int PartTime = 4;
 int NoWork = 0;
Random random = new Random();
int AttenCheck = random.Next(0, 9);

switch (AttenCheck)
{
	case 8:
		Console.WriteLine("Emp is present ");
		Console.WriteLine("Emp Total Wage : " + (WagePerHrs * FullTime));
		break;

	case 4:
		Console.WriteLine("Emp Part Time Wages ");
		Console.WriteLine("Emp Part Time Wages is: " + (WagePerHrs * PartTime));
		break;

	default:

		Console.WriteLine("Emp is Absent  ");
		Console.WriteLine("Total Wage : " + (WagePerHrs * NoWork));
		break;
}