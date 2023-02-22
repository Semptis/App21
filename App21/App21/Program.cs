using App21;
Employee emp = new Employee("Adam", "Kowalski", 22);

while (true)
{
    Console.WriteLine("Podaj ocene: ");
    var grade = Console.ReadLine();
    if (grade == "q")
    {
        break;
    }
    emp.AddScores(grade);
}

var stat = emp.GetStatistics();

Console.WriteLine($"Wynik: Max: {stat.Max} Min: {stat.Min} Avg: {stat.Avg} AvgL: {stat.AvgLetter}");



