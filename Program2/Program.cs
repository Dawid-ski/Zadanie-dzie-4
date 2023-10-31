var name = "Ewa";
var Age = 35;
var Gender = "Kobieta";

if (name == "Ewa" && Age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
if (Gender == "Kobieta" && Age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
if (Gender == "Kobieta" && Age > 30)
{ 
    Console.WriteLine("kobieta powyżej 30 lat");
}
else if (Gender == "Mężczyzna" && Age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}