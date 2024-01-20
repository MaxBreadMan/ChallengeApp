using ChallengeApp1;

{
   
  
    Employee employee1 = new Employee("Adam", "Kowalski", "32");
    Employee employee2 = new Employee("Monika", "Zawadzka", "46");
    Employee employee3 = new Employee("Zuzia", "Nowak", "28");


    employee1.AddScore(5);
    employee1.AddScore(2);
    employee1.AddScore(10);
    employee1.AddScore(7);
    employee1.AddScore(5);

    employee2.AddScore(1);
    employee2.AddScore(10);
    employee2.AddScore(3);
    employee2.AddScore(8);
    employee2.AddScore(5);

    employee3.AddScore(10);
    employee3.AddScore(10);
    employee3.AddScore(5);
    employee3.AddScore(3);
    employee3.AddScore(10);

    int result1 = employee1.Result;
    int result2 = employee2.Result;
    int result3 = employee3.Result;
    int MaxResult = Math.Max(result1, Math.Max(result2, result3));

    if (result1 > result2 && result1 > result3)
    {
        Console.WriteLine("Pracownik z najwyższą średnią ocen to: " + employee1.Name + " " + employee1.Surname + " " + employee1.Age + " Jego średnia ocen wynosi: " + result1);
    }
    else if (result2 > result1 && result2 > result3)
    {
        Console.WriteLine("Pracownik z najwyższą średnią ocen to: " + employee2.Name + " " + employee2.Surname + " " + employee2.Age + " Jego średnia ocen wynosi: " + result2);
    }
    else if (result3 > result1 && result3 > result2)
    {
        Console.WriteLine("Pracownik z najwyższą średnią ocen to: " + employee3.Name + " " + employee3.Surname + " " + employee3.Age + " Jego średnia ocen wynosi: " + result3);
    }
    

}