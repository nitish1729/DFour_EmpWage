
const int WagePerHrs = 20;
const int WorkingDay = 100;
const int FullTime = 8;
const int PartTime = 4;
const int NoWork = 0, MaxWorkingHrs = 100;

int totalWorkingDay = 0, totalEmpHrs = 0;
while (totalEmpHrs <= MaxWorkingHrs && totalWorkingDay < WorkingDay)
{
	totalWorkingDay++;
	Random random = new Random();
	int AttenCheck = random.Next(6, 9);

	switch (AttenCheck)
	{
		case 8:
			Console.WriteLine("Emp is present ");
			Console.WriteLine("Total Wage : " + (WagePerHrs* WorkingDay * FullTime));
			break;
						
			case 4:
			Console.WriteLine("Emp is HalfDayWork ");
			Console.WriteLine("Total Wage : " + (WagePerHrs* WorkingDay * PartTime));
			break;

		default:

			Console.WriteLine("Emp is Absent  ");
			Console.WriteLine("Total Wage : " + (WagePerHrs* WorkingDay * NoWork));
			break;
	}

}