var name = "Ewa";
var age = 35;
var gender = "Kobieta";

if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (gender == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (gender == "Kobieta" && age > 30)
{ 
    Console.WriteLine("kobieta powyżej 30 lat");
}
else if (gender == "Mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}