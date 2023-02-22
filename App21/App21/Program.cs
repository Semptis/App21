using App21;

Employee emp = new Employee("Adam", "Kowalski", 22);

List<Employee> employeeList = new List<Employee>() { emp };

emp.AddScores(3);
emp.AddScores(4.21212121);
emp.AddScores(2.33);
emp.AddScores("aaaa");

var stat = emp.GetStatistics();

Console.WriteLine($"Wynik: Max: {stat.Max} Min: {stat.Min} Avg: {stat.Avg}");



