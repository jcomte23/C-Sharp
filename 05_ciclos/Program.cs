Console.WriteLine("#######################");
Console.WriteLine("Ciclo For => ");
Console.WriteLine("#######################");
Console.WriteLine();

// Ciclo For
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Iteración " + i);
}

Console.WriteLine();
Console.WriteLine("#######################");
Console.WriteLine("Ciclo While => ");
Console.WriteLine("#######################");
Console.WriteLine();

// Ciclo While
int contador = 0;
while (contador < 5)
{
    Console.WriteLine("Contador: " + contador);
    contador++;
}

Console.WriteLine();
Console.WriteLine("#######################");
Console.WriteLine("Ciclo Do-While => ");
Console.WriteLine("#######################");
Console.WriteLine();

// Ciclo Do-While
contador = 0;
do
{
    Console.WriteLine("Contador: " + contador);
    contador++;
} while (contador < 5);

Console.WriteLine();
Console.WriteLine("#######################");
Console.WriteLine("Ciclo Foreach => ");
Console.WriteLine("#######################");
Console.WriteLine();

// Ciclo Foreach
string[] nombres = { "Ana", "Juan", "Pedro", "María" };
foreach (string nombre in nombres)
{
    Console.WriteLine("Nombre: " + nombre);
}

Console.WriteLine();
Console.WriteLine("#######################");
Console.WriteLine("Uso de Break => ");
Console.WriteLine("#######################");
Console.WriteLine();

// Uso de Break
for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine("Iteración " + i);
}

Console.WriteLine();
Console.WriteLine("#######################");
Console.WriteLine("Uso de Continue => ");
Console.WriteLine("#######################");
Console.WriteLine();

// Uso de Continue
for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        continue;
    }
    Console.WriteLine("Número impar: " + i);
}

Console.WriteLine();
Console.WriteLine("#######################");
Console.WriteLine("Ciclo Anidado => ");
Console.WriteLine("#######################");
Console.WriteLine();

// Ciclo Anidado
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine($"i: {i}, j: {j}");
    }
}
