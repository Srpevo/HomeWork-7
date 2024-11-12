using HomeWork_7.Classes.Calculation;
using HomeWork_7.Classes.job;
using HomeWork_7.Classes.Numbering;
using HomeWork_7.Classes.Printer;

Number.AddNumbering(1, ConsoleColor.Green);

Job Programmer = new("C#");
Job PetFoodTaster = new("Tastes pet food to make sure it’s yummy for animals.");
Job GolfBallDiver = new("Dives in ponds to retrieve lost golf balls.");

Printer printer = new Printer();
List<Job> jobs = new List<Job>();

printer.AddJob(Programmer);
printer.AddJob(PetFoodTaster);
printer.AddJob(GolfBallDiver);

try
{
    Job Test1 = printer.GetJob();
    Job Test2 = printer.GetJob();
    Job Test3 = printer.GetJob();
    //Job Test4 = printer.GetJob(); //exception when trying to get a job from an empty list

    jobs.Add(Test1);
    jobs.Add(Test2);
    jobs.Add(Test3);

    foreach (Job job in jobs)
    {
        Console.WriteLine($"Id: {job.Id}, Description: {job.Description}");
    }
}
catch (Exception ex)
{
    Console.WriteLine("No more jobs in the queue: " + ex.Message);
}

Number.AddNumbering(2, ConsoleColor.Green);

Calculator<int> calculator = new Calculator<int>();

Console.WriteLine("Sub: " + calculator.Subtraction(1, 2));
Console.WriteLine("Fold: " + calculator.Fold(1, 2));