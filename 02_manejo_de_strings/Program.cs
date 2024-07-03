/*
**************************
TIPOS DE STRING
**************************
*/
char unCaracter = 'a';
string multiplesCaracteres = "hola mundo, hoy es un nuevo dia";

Console.WriteLine(unCaracter);
Console.WriteLine(multiplesCaracteres);

/*
**************************
PROPIEDADES
**************************
*/
string textoEjemplo = "¡Hola, Mundo!";

// Propiedad Length
Console.WriteLine("Longitud: " + textoEjemplo.Length);

// Propiedad Chars (indexador para acceder a los caracteres individuales)
Console.WriteLine("Primer carácter: " + textoEjemplo[0]);
Console.WriteLine("Último carácter: " + textoEjemplo[textoEjemplo.Length - 1]);

/*
**************************
MÉTODOS
**************************
*/
string texto1 = "La obsesión vence al talento  ";
string texto2 = "LUCHA y sigue luchando  ";

// Mostrar longitud de las cadenas
Console.WriteLine();
Console.WriteLine($"Longitud de texto1: {texto1.Length}");
Console.WriteLine($"Longitud de texto2: {texto2.Length}");

// Concatenación de cadenas
Console.WriteLine();
string concatenacion = texto1 + " " + texto2;
string concatenacionConMetodo = string.Concat(texto1, " ",texto2);
Console.WriteLine($"Concatenación de texto1 y texto2: {concatenacion}");
Console.WriteLine($"Concatenación de texto1 y texto2: {concatenacionConMetodo}");

// Comparación de cadenas
Console.WriteLine();
bool sonIguales = texto1.Equals(texto2);
Console.WriteLine($"¿Texto1 y Texto2 son iguales? {sonIguales}");

// Comparación de cadenas ignoreando mayusculas y minusculas
Console.WriteLine();
bool sonIgualesPasivamente = texto1.Equals(texto2, StringComparison.OrdinalIgnoreCase);
Console.WriteLine($"¿Texto1 y Texto2 son iguales? {sonIgualesPasivamente}");

// Validar si un string esta vacio o null
Console.WriteLine();
bool esVacio = string.IsNullOrEmpty(string.Empty);
bool esNull = string.IsNullOrEmpty(null);
Console.WriteLine($"¿Texto vacío o null? {esVacio} - {esNull}");

// Validar si un string esta vacio,null o lleno de espacios
Console.WriteLine();
bool esVacioConEspacios = string.IsNullOrWhiteSpace(multiplesCaracteres);
Console.WriteLine($"¿Texto con espacios vacío? {esVacioConEspacios}");

// Eliminación de espacios en blanco al principio y al final de las cadenas
Console.WriteLine();
string texto1SinEspacios = texto1.Trim();
string texto2SinEspacios = texto2.Trim();
Console.WriteLine($"Texto1 sin espacios en blanco: {texto1SinEspacios}");
Console.WriteLine($"Texto2 sin espacios en blanco: {texto2SinEspacios}");

// Reemplazo de caracteres en las cadenas
Console.WriteLine();
string texto1Reemplazado = texto1.Replace("obsesión", "lucha");
string texto2Reemplazado = texto2.Replace("lucha", "obsesión");
Console.WriteLine($"Texto1 reemplazado: {texto1Reemplazado}");
Console.WriteLine($"Texto2 reemplazado: {texto2Reemplazado}");

// Invertir cadenas
Console.WriteLine();
string texto1Invertido = new string(texto1.Reverse().ToArray());
string texto2Invertido = new string(texto2.Reverse().ToArray());
Console.WriteLine($"Texto1 invertido: {texto1Invertido}");
Console.WriteLine($"Texto2 invertido: {texto2Invertido}");

// Cambiar el caso de las letras (convertir en mayusculas o minusculas)
Console.WriteLine();
string texto1Mayusculas = texto1.ToUpper();
string texto2Minusculas = texto2.ToLower();
Console.WriteLine($"Texto1 en mayúsculas: {texto1Mayusculas}");
Console.WriteLine($"Texto2 en minúsculas: {texto2Minusculas}");

// Buscar una cadena en otra
Console.WriteLine();
int indiceTexto1 = texto1.IndexOf("mejor");
int indiceTexto2 = texto2.IndexOf("mejor");
Console.WriteLine($"Indice de 'mejor' en texto1: {indiceTexto1}");
Console.WriteLine($"Indice de 'mejor' en texto2: {indiceTexto2}");

// Cortar cadenas en partes
Console.WriteLine();
string[] divisionTexto1 = texto1.Split(' '); // Dividir texto1 en palabras
string[] divisionTexto2 = texto2.Split(' '); // Dividir texto2 en palabras
Console.WriteLine($"Division de texto1 en palabras: {string.Join(", ", divisionTexto1)}");
Console.WriteLine($"Division de texto2 en palabras: {string.Join(", ", divisionTexto2)}");

// Substring de las cadenas
Console.WriteLine();
string subcadena1 = texto1.Substring(0, 10); // Primeros 10 caracteres de texto1
string subcadena2 = texto2.Substring(0, 10); // Primeros 10 caracteres de texto2
Console.WriteLine($"Subcadena de texto1: {subcadena1}");
Console.WriteLine($"Subcadena de texto2: {subcadena2}");

// Reemplazo de una palabra en texto1
Console.WriteLine();
string nuevoTexto1 = texto1.Replace("mejor", "único");
Console.WriteLine($"Texto1 modificado: {nuevoTexto1}");