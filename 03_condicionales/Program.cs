Console.WriteLine("#######################");
Console.WriteLine("Condicional Simple => ");
Console.WriteLine("#######################");
Console.WriteLine();

int edad = 20;
if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad.");
}
else
{
    Console.WriteLine("Eres menor de edad.");
}

Console.WriteLine();
Console.WriteLine("#######################");
Console.WriteLine("Condicional Compuesta => ");
Console.WriteLine("#######################");
Console.WriteLine();

int nota = 85;
if (nota >= 90)
{
    Console.WriteLine("Sobresaliente.");
}
else if (nota >= 70)
{
    Console.WriteLine("Aprobado.");
}
else
{
    Console.WriteLine("Reprobado.");
}

Console.WriteLine();
Console.WriteLine("#######################");
Console.WriteLine("Condicional Anidada => ");
Console.WriteLine("#######################");
Console.WriteLine();

bool tieneLicencia = true;
if (edad >= 18)
{
    if (tieneLicencia)
    {
        Console.WriteLine("Puedes conducir.");
    }
    else
    {
        Console.WriteLine("No tienes licencia para conducir.");
    }
}
else
{
    Console.WriteLine("Eres menor de edad, no puedes conducir.");
}

