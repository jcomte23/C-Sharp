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

// Mostrar longitud de las cadenas
Console.WriteLine();
Console.WriteLine($"Longitud de texto1: {texto1.Length}");
Console.WriteLine($"Longitud de texto2: {texto2.Length}");

// Mostrar cadenas en mayúsculas y minúsculas
Console.WriteLine();
Console.WriteLine($"Texto1 en mayúsculas: {texto1.ToUpper()}");
Console.WriteLine($"Texto2 en minúsculas: {texto2.ToLower()}");

// Substring de las cadenas
Console.WriteLine();
string subcadena1 = texto1.Substring(0,10); // Primeros 10 caracteres de texto1
string subcadena2 = texto2.Substring(0,10); // Primeros 10 caracteres de texto2
Console.WriteLine($"Subcadena de texto1: {subcadena1}");
Console.WriteLine($"Subcadena de texto2: {subcadena2}");

// Reemplazo de una palabra en texto1
Console.WriteLine();
string nuevoTexto1 = texto1.Replace("mejor", "único");
Console.WriteLine($"Texto1 modificado: {nuevoTexto1}");

// Comparación de cadenas
Console.WriteLine();
bool sonIguales = texto1.Equals(texto2, StringComparison.OrdinalIgnoreCase);
Console.WriteLine($"¿Texto1 y Texto2 son iguales? {sonIguales}");