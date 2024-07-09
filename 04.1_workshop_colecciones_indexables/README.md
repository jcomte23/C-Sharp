# Ejercicios de Colecciones Indexables en C#

## Ejercicios de Arrays

### Ejercicio 1: Declarar e Inicializar un Array

- Descripción: Declare e inicialice un array de tipo int con 5 elementos. Asigne valores a cada elemento del array utilizando la notación literal.

### Ejercicio 2: Recorrer un Array con un Bucle for 

- Descripción: Recorra el array declarado en el ejercicio 1 utilizando un bucle for. Imprima cada elemento del array en la consola.

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

