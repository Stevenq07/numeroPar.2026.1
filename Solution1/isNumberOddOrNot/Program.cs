Console.WriteLine("Ingrese numero :");
var numberString = Console.ReadLine();
var numberInt = int.Parse(numberString!);
if (numberInt % 2 == 0)
{
    Console.WriteLine($"el numero : {numberInt} es par");
}
else
{
    Console.WriteLine($"el numero: {numberInt} es impar");
}




