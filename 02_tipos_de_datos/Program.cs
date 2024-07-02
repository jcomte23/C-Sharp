Console.WriteLine("#########################");
Console.WriteLine("Tipos numéricos enteros=>");
Console.WriteLine("#########################");
Console.WriteLine();
// byte: Entero de 8 bits, rango: 0 a 255
byte ejemploByte = 255;
Console.WriteLine($"byte: {ejemploByte}");

// sbyte: Entero con signo de 8 bits, rango: -128 a 127
sbyte ejemploSbyte = -128;
Console.WriteLine($"sbyte: {ejemploSbyte}");

// short: Entero con signo de 16 bits, rango: -32,768 a 32,767
short ejemploShort = -32768;
Console.WriteLine($"short: {ejemploShort}");

// ushort: Entero sin signo de 16 bits, rango: 0 a 65,535
ushort ejemploUshort = 65535;
Console.WriteLine($"ushort: {ejemploUshort}");

// int: Entero con signo de 32 bits, rango: -2,147,483,648 a 2,147,483,647
int ejemploInt = 2147483647;
Console.WriteLine($"int: {ejemploInt}");

// uint: Entero sin signo de 32 bits, rango: 0 a 4,294,967,295
uint ejemploUint = 4294967295;
Console.WriteLine($"uint: {ejemploUint}");

// long: Entero con signo de 64 bits, rango: -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807
long ejemploLong = 9223372036854775807;
Console.WriteLine($"long: {ejemploLong}");

// ulong: Entero sin signo de 64 bits, rango: 0 a 18,446,744,073,709,551,615
ulong ejemploUlong = 18446744073709551615;
Console.WriteLine($"ulong: {ejemploUlong}");

Console.WriteLine();
Console.WriteLine("###################################");
Console.WriteLine("Tipos numéricos de punto flotante=>");
Console.WriteLine("###################################");
Console.WriteLine();
// float: Número de punto flotante de 32 bits
float ejemploFloat = 3.14f;
Console.WriteLine($"float: {ejemploFloat}");

// double: Número de punto flotante de 64 bits
double ejemploDouble = 3.141592653589793;
Console.WriteLine($"double: {ejemploDouble}");

// decimal: Número decimal de 128 bits, usado para cálculos financieros
decimal ejemploDecimal = 12345.6789m;
Console.WriteLine($"decimal: {ejemploDecimal}");

Console.WriteLine();
Console.WriteLine("##################################");
Console.WriteLine("Tipos booleanos (true o false) =>");
Console.WriteLine("##################################");
Console.WriteLine();

bool esVerdadero = true;
bool esFalso = false;

Console.WriteLine($"Es Verdadero: {esVerdadero}");
Console.WriteLine($"Es Falso: {esFalso}");

Console.WriteLine();
Console.WriteLine("################################");
Console.WriteLine("Tipos de cadena de caracteres =>");
Console.WriteLine("################################");
Console.WriteLine();

// Tipo carácter
char letra = 'A';
char digito = '1';

Console.WriteLine($"Letra: {letra}");
Console.WriteLine($"Dígito: {digito}");

// Tipo cadena
string saludo = "Hola, mundo!";
string textoMultilinea = @"Este es un 
texto con múltiples
líneas.";

Console.WriteLine($"Saludo: {saludo}");
Console.WriteLine($"Texto Multilínea: {textoMultilinea}");

// Concatenacion de strings

string nombre = "Juan";
string primerApellido = "Pérez";
string segundoApellido = "Martinez";

string nombreCompleto1 = nombre + " " + primerApellido + " " + segundoApellido;
string nombreCompleto2 = $"{nombre} {primerApellido} {segundoApellido}";
string nombreCompleto3 = string.Concat(nombre," ", primerApellido," ", segundoApellido);

Console.WriteLine();
Console.WriteLine($"Nombre Completo option 1: {nombreCompleto1}");
Console.WriteLine($"Nombre Completo option 2: {nombreCompleto2}");
Console.WriteLine($"Nombre Completo option 3: {nombreCompleto3}");

Console.WriteLine();
Console.WriteLine("########################");
Console.WriteLine("Conversion de datos => ");
Console.WriteLine("########################");
Console.WriteLine();

// Casting implícito (automáticamente) - convertir un tipo más pequeño a un tipo más grande
// char -> int -> long -> float -> double
char valorChar = 'A';
int valorInt = valorChar; // char a int
long valorLong = valorInt; // int a long
float valorFloat = valorLong; // long a float
double valorDouble = valorFloat; // float a double

Console.WriteLine();
Console.WriteLine("Casting Implícito:");
Console.WriteLine($"valorChar: {valorChar}");
Console.WriteLine($"valorInt: {valorInt}");
Console.WriteLine($"valorLong: {valorLong}");
Console.WriteLine($"valorFloat: {valorFloat}");
Console.WriteLine($"valorDouble: {valorDouble}");

// Casting explícito (manualmente) - convertir un tipo más grande a un tipo más pequeño
// double -> float -> long -> int -> char
double valorDouble2 = 1.456;
float valorFloat2 = (float)valorDouble2; // double a float
long valorLong2 = (long)valorFloat2; // float a long
int valorInt2 = (int)valorLong2; // long a int
char valorChar2 = (char)valorInt2; // int a char

Console.WriteLine();
Console.WriteLine("Casting Explícito:");
Console.WriteLine($"valorDouble2: {valorDouble2}");
Console.WriteLine($"valorFloat2: {valorFloat2}");
Console.WriteLine($"valorLong2: {valorLong2}");
Console.WriteLine($"valorInt2: {valorInt2}");
Console.WriteLine($"valorChar2: {valorChar2}");

Console.WriteLine();
Console.WriteLine("Casting Explícito:");
int numeroEntero = 10;
double numeroConDecimal = 5.25;
bool Boolean = true;

// Convertir bool a string
Console.WriteLine(Convert.ToString(Boolean));

// Convertir int a string
Console.WriteLine(Convert.ToString(numeroEntero));

// Convertir int a double
Console.WriteLine(Convert.ToDouble(numeroEntero));

// Convertir double a int
Console.WriteLine(Convert.ToInt32(numeroConDecimal));

// Convertir double a long
Console.WriteLine(Convert.ToInt64(numeroConDecimal));