string name = "Piotr";
var gender = "Mężczyzna";
int age = 17;

// == równe
// != róznia sie
// && TO I TO czy spełnia
// || TO LUB TO czy spełnia
// ! negacja

if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta, poniżej 30lat");
}
else if (gender != "Kobieta" && age <= 17)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Inny człowiek");
}



