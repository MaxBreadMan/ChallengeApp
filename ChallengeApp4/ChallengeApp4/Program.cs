string name = "Ewa";
int age = 28;
bool isWoman = true;

if (isWoman == true && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa lat 30");
}
else if (isWoman == false && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyna");
}