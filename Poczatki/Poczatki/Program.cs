string name = "Bartek";
string sex = "male";
var age = 33;
if (sex != "male" && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa lat 30");
}
else if (sex == "male" && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");   
}