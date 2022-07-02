// Add parttime Employee & Wage

string Welcome = "Welcome to Employee Wage Computation";
   Console.WriteLine(Welcome);

 int WagePerHrs = 20;
 int FullTime = 8;
 int partTime = 4;
 int NoWork = 0;

 Random ran = new Random();

int AttenCheck = ran.Next(2, 6);

if (AttenCheck == FullTime)

{
    Console.WriteLine("Emp is Present");
    Console.WriteLine("EmpWage : " + (WagePerHrs * FullTime));
}
else if (AttenCheck == partTime)
{
    Console.WriteLine("Emp is Present for Halfday");
    Console.WriteLine("Employee Part time wage : " + (WagePerHrs * partTime));
}
else
{
    Console.WriteLine("Emp is Absent");
    Console.WriteLine("EmpWage : " + (WagePerHrs * NoWork));
}