using ChallengeApp1;

var employee = new Employee("Adam", "Kamizelich", "10 lat");
employee.AddGrade("Adam");
employee.AddGrade("4000");
employee.AddGrade(1.5);
employee.AddGrade(1000000000L);
employee.AddGrade(54.99M);
employee.AddGrade(5f);
employee.AddGrade(2);
employee.AddGrade(6);

var statistics = employee.GetStatistics();
Console.WriteLine("-------> Statystyki <-------");
Console.WriteLine("Imie: " + employee.Name);
Console.WriteLine("Nazwisko: " + employee.Surname);
Console.WriteLine("Staz: " + employee.Seniority);
Console.WriteLine("Oceny pracownika: ");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");
