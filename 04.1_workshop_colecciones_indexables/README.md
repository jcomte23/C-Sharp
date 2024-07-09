# Ejercicios de Colecciones Indexables en C#

## Ejercicios de Arrays

### Ejercicio 1: Declarar e Inicializar un Array

- Descripción: Declare e inicialice un array de tipo int con 5 elementos. Asigne valores a cada elemento del array utilizando la notación literal.

### Ejercicio 2: Recorrer un Array 

- Descripción: Recorra el array declarado en el ejercicio 1 utilizando utlizando el método `ForEach`. Imprima cada elemento del array en la consola.

### Ejercicio 3: Buscar un Elemento en un Array

- Descripción: Cree una función que busque un elemento específico dentro del array declarado en el ejercicio 1. La función debe devolver `true` si el elemento se encuentra en el array, y `false` en caso contrario.

### Ejercicio 4: Ordenar un Array en orden ascendente

- Descripción: Cree un array de tipo `double` con 10 elementos. Llene el array con valores aleatorios utilizando la clase `Random`. Ordene el array en orden ascendente. Imprima el array original con los valores generado y el array ordenado en la consola.

### Ejercicio 5: Buscar un Elemento en un Array Bidimensional

**Código base**
```c#
int[,] arrayBase = {
  { 15, 23, 7 },
  { 8, 16, 2 },
  { 11, 14, 1 },
  { 5, 9, 6 },
  { 12, 10, 3 }
};
```

- Descripción: Cree una función que busque un elemento específico dentro de un array bidimensional de tipo `int`. La función debe devolver `true` si el elemento se encuentra en el array, y `false` en caso contrario. 
- Requisitos:
  -  Usa el `arrayBase` declarado arriba para ejecutar la función de busqueda.
  - Ejecuta la función con 2 casos de prueba. Pruebe con un elemento que no se encuentra en el array y un elemento que si se encuentra.

## Ejercicios de Listas (`List<T>`)

### Ejercicio 1: Declarar e Inicializar una Lista

- Descripción: Declare 3 listas:
  - Una lista de tipo `string` vacía. 
  - Una lista de tipo `byte` inicializada con 5 elementos.
  - Una lista de tipo int con 10 elementos usando la sintaxis _["Collection Expresion"](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/collection-expressions)_.

## Ejercicio 2: Suma de números negativos de coma deciaml
- Descripción: Dada una lista de números de tipo `double` que incluye tanto positivos como negativos, calcula la suma de todos los números negativos. Muestra el resultado por consola.

## Ejercicio 3: Multiplicación de elementos en una lista
- Descripción: Dada una lista de **string numéricos** definidos por ti (elige el tipo de dato), calcula el producto de todos los números. Muestra el resultado por consola.

## Ejercicio 4: Filtrar divisibles
- Descripción: Dada una lista de números enteros, imprime solo aquellos que son divisibles por un número n definido por ti en una variable externa.

## Ejercicio 5: Invertir una lista
- Descripción: Dada una lista de números enteros, imprime la lista invertida.

## Ejercicio 6: Eliminar strings duplicados
- Descripción: Dada la siguiente lista, elimina los elementos duplicados creando una lista con elementos únicos.

```c#
var stringList = new List<string> {"manzana", "banana", "cereza", "manzana", "durazno", "plátano", "cereza", "manzana", "durazno", "banana"};
```

## Ejercicio 7: Intersección de listas
- Descripción: Dados dos listas (definidas por ti), encuentra los elementos comunes a ambas listas y luego imprimelos por consola.

## Ejercicio 8: Concatenación de cadenas
Dada una lista de cadenas (strings) definida por ti, concaténalas todas en una sola cadena. Muestra el resultado por consola

## Ejercicio 9: Calculadora de Promedio de Calificaciones

- Solicita al usuario que ingrese las calificaciones del estudiante separadas por comas.
- Convierte las calificaciones ingresadas a una lista.
- Suma todas las calificaciones y calcular su promedio.
- Muestra el promedio de calificaciones al usuario.

## Ejercicio 10: Calculadora de Estadísticas de Calificaciones

- Solicita al usuario que ingrese las calificaciones del estudiante separadas por comas.
- Convierte las calificaciones ingresadas a una lista.
- Calcular las siguientes estadísticas:
  - Promedio de Calificaciones
  - Calificación Máxima
  - Calificación Mínima
  - Número de calificaciones aprobadas (calificación mayor o igual a 7)
  - Número de claficaciones reprobadas (calificación menor a 7)
  - Lista de Calificaciones Ordenadas de Mayor a Menor
- Muestra las "estadísticas" calculadas al usuario.