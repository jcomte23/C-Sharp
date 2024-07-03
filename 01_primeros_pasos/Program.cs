// variables de tipo string para practicar
string texto1 = "C# es el mejor lenguaje del mundo.";
string texto2 = "Prepárate para adentrarte en este gran mundo.";

// Impresión sin salto de línea
Console.Write(texto1);
Console.Write(texto2);
Console.WriteLine();

// Impresión con salto de línea
Console.WriteLine();
Console.WriteLine(texto1);
Console.WriteLine(texto2);

// Impresión simple
Console.WriteLine();
Console.WriteLine(texto1 + texto2);

// Impresión mejorada con interpolación de strings
Console.WriteLine();
Console.WriteLine($"{texto1} {texto2}");

// Impresion con salto de linea
Console.WriteLine();
Console.WriteLine($"{texto1} \n{texto2}");

// Impresion con salto de linea de optima
Console.WriteLine();
Console.WriteLine(
@$"{texto1}
{texto2}"
);

// Impresion con tabulaciones en C#
Console.WriteLine($"UNO DOS TRES");
Console.WriteLine($"UNO\t DOS\t TRES\t");