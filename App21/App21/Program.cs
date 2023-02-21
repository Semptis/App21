using App21;

Employee emp = new Employee("Adam", "Kowalski", 22);
Employee emp1 = new Employee("Mariusz", "Kowalski", 22);
Employee emp2 = new Employee("Paweł", "Kowalski", 22);

List<Employee> employeeList = new List<Employee>() { emp, emp1, emp2 };

emp.AddScores(3);
emp1.AddScores(2);
emp2.AddScores(1);

List<Employee> sortedList = employeeList.OrderBy(x => x.GetScore()).ToList();

Console.WriteLine(sortedList.Last().GetPersonalData() + " " + sortedList.Last().GetScore());
