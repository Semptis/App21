using App21;
using System.Linq.Expressions;

Employee emp = new Employee("Adam", "Kowalski", 22);

while (true)
{
    Console.WriteLine("Podaj ocene: ");
    var grade = Console.ReadLine();
    if (grade == "q")
    {
        break;
    }
    try
    {
        emp.AddGrade(grade);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

var stat = emp.GetStatistics();

Console.WriteLine($"Wynik: Max: {stat.Max} Min: {stat.Min} Avg: {stat.Avg} AvgL: {stat.AvgLetter}");



