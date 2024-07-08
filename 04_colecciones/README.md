# Colecciones en C#

Las colecciones son estructuras de datos fundamentales para organizar y administrar
grupos de elementos de manera eficiente. En C#, las colecciones ofrecen una amplia
gama de funcionalidades para almacenar, recuperar, manipular y procesar conjuntos
de datos de forma segura y escalable.

## Tipos de Colecciones

1. Colecciones indexables.
2. Colecciones de pares clave/valor.
3. Iteradores.

## Colecciones indexables

### `ArrayList`

Estructura de datos indexable **no genérica** y **debilmente tipada** que utiliza una matriz cuyo tamaño aumenta dinámicamente cuando es necesario.

Definición: [ArrayList Clase - Definición](https://learn.microsoft.com/es-es/dotnet/api/system.collections.arraylist?view=net-8.0#definition)

> [!IMPORTANT]
> No se recomienda usar `ArrayList`. [Here's why](https://learn.microsoft.com/es-es/dotnet/api/system.collections.arraylist?view=net-8.0#remarks)

#### Ejemplo básico

```c#
// Crear un ArrayList vacio
ArrayList arrayList1 = new ArrayList();

// Crear un ArrayList vacio con la sintaxis de "Expresión de collección" (Requiere C# 12+)
ArrayList arrayList2 = [];
```

> [!TIP]
> Más información sobre la sintaxis de "Expresión de collección":
> [Collection Expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/collection-expressions)

#### Propiedades

- `ArrayList.Count`: Obtiene el número de elementos actuales dentro la colección.
  ```c#
  // Acceder al número de elementos
  Console.WriteLine($"Numero de elementos:  {nombres.Count}");
  ```
- `ArrayList.Capacity`: Obtiene el número de elementos que puede contener la colección.
  ```c#
  // Acceder al tamaño de la colección
  Console.WriteLine($"Capacidad:  {nombres.Capacity}");
  ```

#### Todas la Propiedades: [ArrayList Clase - Propiedades](https://learn.microsoft.com/es-es/dotnet/api/system.collections.arraylist?view=net-8.0#properties)

#### Algunos Métodos

| Método                           | Descripción                                                                        | Valor de Retorno                                                    |
| -------------------------------- | ---------------------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Add(Object item)`               | Agrega un elemento al final de la lista.                                           | N/A (void)                                                          |
| `Insert(int index, Object item)` | Inserta un elemento en la posición especificada de la lista.                       | N/A (void)                                                          |
| `RemoveAt(int index)`            | Elimina el elemento en la posición especificada de la lista.                       | N/A (void)                                                          |
| `Contains(Object item)`          | Determina si la lista contiene el elemento especificado.                           | `true` si la lista contiene el elemento, `false` en caso contrario. |
| `IndexOf(Object item)`           | Devuelve el índice de la primera ocurrencia del elemento especificado en la lista. | Índice del elemento si se encuentra; -1 si no se encuentra.         |

**Explicación adicional:**

- Los métodos `Add` e `Insert` modifican la lista original.
- El método `RemoveAt` elimina el elemento de la lista y desplaza los elementos subsiguientes.
- El método `Contains` indica si el elemento especificado está presente en la lista, sin modificarla.
- El método `IndexOf` devuelve la posición del primer elemento coincidente, o -1 si no se encuentra.

**Ejemplos de uso:**

```c#
ArrayList myList = new ArrayList();

// Agregar un elemento al final de la lista
myList.Add("Elemento 1");

// Insertar un elemento en la posición 0
myList.Insert(0, "Elemento 0");

// Eliminar el elemento en la posición 1
myList.RemoveAt(1);

// Verificar si la lista contiene el elemento "Elemento 2"
bool containsElement = myList.Contains("Elemento 2");
Console.WriteLine(containsElement); // Resultado: false

// Obtener el índice del elemento "Elemento 0"
int index = myList.IndexOf("Elemento 0");
Console.WriteLine(index); // Resultado: 0
```

#### Todos los Métodos: [ArrayList Clase - Métodos](https://learn.microsoft.com/es-es/dotnet/api/system.collections.arraylist?view=net-8.0#methods)

### `List`

Representa una lista de objetos fuertemente tipados a la que se puede obtener acceso por índice. Proporciona métodos para buscar, ordenar y manipular listas.

Definición: [List Clase - Definición](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0#definition)

#### Ejemplo basico

```c#
// Crear una lista vacia
List<int> list1 = new List<int>();
```

#### Propiedades

- `List.Count`: Obtiene el número de elementos actuales dentro la lista.
  ```c#
  // Acceder al número de elementos
  Console.WriteLine($"Numero de elementos:  {list1.Count}");
  ```
- `List.Capacity`: Obtiene el número de elementos que puede contener la colección.
  ```c#
  // Acceder al tamaño de la lista
  Console.WriteLine($"Capacidad:  {list1.Capacity}");
  ```

#### Todas la Propiedades: [List Clase - Propiedades](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0#properties)

#### Métodos

[List Clase - Métodos](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0#methods)

### `Array`

Estructura de datos estática que que almacenan elementos del mismo tipo en una memoria contigua.
Su tamaño se define al crear el array y no se puede modificar posteriormente. Pueden ser unidimensionales, multidimensionales o jagged (_array de arrays_).

#### Propiedades

- `Array.Rank`: Obtiene el número total de elementos de todas las dimensiones de Array

  ```c#
  // Definición
  public int Rank { get; }

  // Acceder al número de dimensiones
  Console.WriteLine($"Rank:  {array.Rank}");
  ```

- `Array.Length`: Obtiene el número de elementos totales del array.

  ```c#
  // Definición
  public int Length { get; }

  // Acceder al número de elementos
  Console.WriteLine($"Length:  {array.Length}");
  ```

#### Todas la Propiedades: [Array Clase - Propiedades](https://learn.microsoft.com/es-es/dotnet/api/system.array?view=net-8.0#properties)

#### Métodos

- `Array.GetLength(int dimension)`: Obtiene el número de elementos de una dimension del array.

  ```c#
  // Array multidimensional
  int[,] array = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
  // Acceder al número de elementos de una dimension
  Console.WriteLine($"GetLength(0):  {array.GetLength(0)}");
  ```

[Array Clase - Métodos](https://learn.microsoft.com/es-es/dotnet/api/system.array?view=net-8.0#methods)

### `Array` vs `List`

- Los `Array`s ofrecen un mejor rendimiento para el acceso y la manipulación de elementos contiguos en memoria, especialmente para grandes conjuntos de datos.
