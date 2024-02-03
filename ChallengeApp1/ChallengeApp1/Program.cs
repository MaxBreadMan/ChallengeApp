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
Console.WriteLine("-------GetStatistics-------");
Console.WriteLine("Imie: " + employee.Name);
Console.WriteLine("Nazwisko: " + employee.Surname);
Console.WriteLine("Staz: " + employee.Seniority);
Console.WriteLine("Oceny pracownika: ");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");

var statistics1 = employee.GetStatisticsForEach();
Console.WriteLine("--------GetStatisticsForEach--------");
Console.WriteLine("Imie: " + employee.Name);
Console.WriteLine("Nazwisko: " + employee.Surname);
Console.WriteLine("Staz: " + employee.Seniority);
Console.WriteLine("Oceny pracownika: ");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Average: {statistics1.Average:N2}");

var statistics2 = employee.GetStatisticsWithDoWhile();
Console.WriteLine("--------GetStatisticsWithDoWhile--------");
Console.WriteLine("Imie: " + employee.Name);
Console.WriteLine("Nazwisko: " + employee.Surname);
Console.WriteLine("Staz: " + employee.Seniority);
Console.WriteLine("Oceny pracownika: ");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Average: {statistics2.Average:N2}");

var statistics3 = employee.GetStatisticsWithWhile();
Console.WriteLine("--------GetStatisticsWithWhile--------");
Console.WriteLine("Imie: " + employee.Name);
Console.WriteLine("Nazwisko: " + employee.Surname);
Console.WriteLine("Staz: " + employee.Seniority);
Console.WriteLine("Oceny pracownika: ");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Average: {statistics3.Average:N2}");

var statistics4 = employee.GetStatisticsWithFor();
Console.WriteLine("--------GetStatisticsWithFor--------");
Console.WriteLine("Imie: " + employee.Name);
Console.WriteLine("Nazwisko: " + employee.Surname);
Console.WriteLine("Staz: " + employee.Seniority);
Console.WriteLine("Oceny pracownika: ");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");
Console.WriteLine($"Average: {statistics4.Average:N2}");