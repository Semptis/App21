var name = "Ewa";
var age = 17;
var isFemale = false;


if (isFemale)
{
    if(age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
}
else if (age < 18)
{
        Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Brak kryteriów");
}
