string name = "Piotr";
bool isMale = true;
var age = 17;

if(!isMale && age < 30)
{ 
    Console.WriteLine("Kobieta, poniżej 30 lat");
}
else if(age == 30 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if(isMale && age <= 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Inny człowiek");
}