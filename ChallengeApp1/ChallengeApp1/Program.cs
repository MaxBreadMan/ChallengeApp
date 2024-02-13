using ChallengeApp1;
using System.ComponentModel.Design;
using System.Diagnostics;

Employee employee = new Employee("Adam", "Nowak", "0 lat");
Console.WriteLine("Program oceny pracownikow");
Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
Console.WriteLine();

int count = 0; 
while (true)
{
    Console.WriteLine();
    Console.WriteLine("Podaj ocene pracownika lub wpisz 'q' zeby pokazac statystyki ");
    var input = Console.ReadLine();
    if (input == "q")
    {

        break;
    }
    else
    { 
        employee.AddGrade(input);
        count++;
    }
}
var statistics = employee.GetStatistics();
Console.WriteLine("-------Statystyki-------");
Console.WriteLine("Imie: " + employee.Name);
Console.WriteLine("Nazwisko: " + employee.Surname);
Console.WriteLine("Staz: " + employee.Seniority);
Console.WriteLine("Liczba ocen: " + count);
Console.WriteLine("Oceny pracownika: ");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AVG: {statistics.Average:N2}");
Console.WriteLine($"AVG letter: {statistics.AverageLetter}");
