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

// Condicional if-else if-else
Console.WriteLine("#######################");
Console.WriteLine("Condicional if-else if-else => ");
Console.WriteLine("#######################");
Console.WriteLine();

int temperatura = 25;
if (temperatura >= 30)
{
    Console.WriteLine("Hace mucho calor.");
}
else if (temperatura >= 20)
{
    Console.WriteLine("El clima es templado.");
}
else if (temperatura >= 10)
{
    Console.WriteLine("Hace frío.");
}
else
{
    Console.WriteLine("Hace mucho frío.");
}

Console.WriteLine();

// Condicional switch
Console.WriteLine("#######################");
Console.WriteLine("Condicional switch => ");
Console.WriteLine("#######################");
Console.WriteLine();

int diaSemana = 3;
Console.WriteLine("Día de la semana:");
switch (diaSemana)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miércoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sábado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("Día no válido");
        break;
}

Console.WriteLine();

// Operador ternario
Console.WriteLine("#######################");
Console.WriteLine("Operador ternario => ");
Console.WriteLine("#######################");
Console.WriteLine();

edad = 20;
string mensaje = (edad >= 18) ? "Eres mayor de edad." : "Eres menor de edad.";
Console.WriteLine(mensaje);
