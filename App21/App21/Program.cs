using App21;

Employee emp = new Employee("Adam","Kowalski",22);
Employee emp1 = new Employee("Mariusz", "Kowalski", 22);
Employee emp2 = new Employee("Paweł", "Kowalski", 22);

List<Employee> result = new List<Employee>() {emp, emp1, emp2};

emp.AddScores();
emp1.AddScores();
emp2.AddScores();

List<Employee> sortedList = result.OrderBy(x => x.GetScore()).ToList();

Console.WriteLine(sortedList.Last().GetPersonalData() + " " + sortedList.Last().GetScore());
