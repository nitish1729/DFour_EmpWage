
// Calculate Daily Employee Wage

 int WagePerHrs = 20;
 int FullTime = 8;
 int NoWork = 0;
 Random ran = new Random();

int AttenCheck = ran.Next(0, 9);

if (AttenCheck == FullTime)
{
    Console.WriteLine("Emp is Present");
    Console.WriteLine("EmpWage : " + (WagePerHrs * FullTime));
}
else
{
    Console.WriteLine("Emp is Absent");
    Console.WriteLine("EmpWage : " + (WagePerHrs * NoWork));
    Console.ReadLine();
}