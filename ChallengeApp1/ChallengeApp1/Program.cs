using ChallengeApp1;

var employee = new Employee("Adam", "Kamizelich", "10 lat");
employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);
employee.AddGrade(8);
var statistics = employee.GetStatistics();
Console.WriteLine("Imie: " + employee.Name);
Console.WriteLine("Nazwisko: " + employee.Surname);
Console.WriteLine("Staz: " + employee.Seniority);
Console.WriteLine("Oceny pracownika: ");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");

