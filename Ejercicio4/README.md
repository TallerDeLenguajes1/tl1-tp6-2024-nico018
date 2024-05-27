¿String es una tipo por valor o un tipo por referencia?
En C#, string es un tipo de dato por referencia. Esto significa que cuando se crea una variable de tipo string, lo que realmente se almacena en la memoria no es el valor de la cadena en sí, sino una referencia a la ubicación en memoria donde se encuentra la cadena.

Por lo tanto, cuando asignas una cadena a otra variable o pasas una cadena como argumento a un método, estás pasando una referencia a la cadena, no una copia del valor de la cadena en sí. Esto tiene implicaciones en el comportamiento de asignación y paso de parámetros en C#.

Los tipos de datos por referencia se almacenan en el montón (heap) de la memoria y son administrados por el recolector de basura (garbage collector) de .NET Framework o .NET Core. Esto significa que no necesitas preocuparte por liberar la memoria de las cadenas que ya no están en uso; el recolector de basura se encarga de eso automáticamente.

¿Qué secuencias de escape tiene el tipo string?
En C#, las secuencias de escape disponibles para las cadenas de texto (string) son las siguientes:

\n: Salto de línea.
\r: Retorno de carro.
\t: Tabulación horizontal.
\\: Barra invertida (backslash).
\': Comilla simple.
\": Comilla doble.
\b: Retroceso (backspace).
\f: Avance de página (form feed).
\v: Tabulación vertical.
\0: Carácter nulo.
\uxxxx: Representa un carácter Unicode especificado por su valor hexadecimal de cuatro dígitos.
\Uxxxxxxxx: Representa un carácter Unicode especificado por su valor hexadecimal de ocho dígitos.
Estas secuencias de escape permiten incluir caracteres especiales dentro de las cadenas de texto y son ampliamente utilizadas para formatear la salida y manejar situaciones donde se necesitan caracteres que no son visibles o no se pueden escribir directamente.

¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
En C#, al usar el carácter @ antes de una cadena de texto, se indica que la cadena es una cadena literal, lo que significa que los caracteres de escape dentro de esa cadena no serán interpretados. Esto es útil cuando se trabaja con cadenas que contienen muchas barras invertidas o caracteres de escape, ya que evita la necesidad de duplicarlas o escaparlas