using ConceptsPOO;

Console.WriteLine("Concepts POO");
Console.WriteLine("============");

try
{
    Console.WriteLine(new Date(2022, 02, 20));
    Console.WriteLine(new Date(2022, 16, 92));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}


