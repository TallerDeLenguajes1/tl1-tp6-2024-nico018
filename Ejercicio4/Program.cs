using System;

class Program
{
    static void Main()
    {
        // Obtener la cadena ingresada por el usuario
        Console.WriteLine("Ingrese una cadena de texto:");
        string cadena = Console.ReadLine();

        // Obtener la longitud de la cadena y mostrar por pantalla
        Console.WriteLine($"Longitud de la cadena: {cadena.Length}");

        // Concatenar con una segunda cadena ingresada por el usuario
        Console.WriteLine("Ingrese otra cadena de texto para concatenar:");
        string segundaCadena = Console.ReadLine();
        string concatenadas = cadena + segundaCadena;
        Console.WriteLine($"Cadenas concatenadas: {concatenadas}");

        // Extraer una subcadena de la cadena ingresada
        Console.WriteLine("Ingrese el índice de inicio para la subcadena:");
        int indiceInicio = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la longitud de la subcadena:");
        int longitud = int.Parse(Console.ReadLine());
        string subcadena = cadena.Substring(indiceInicio, longitud);
        Console.WriteLine($"Subcadena: {subcadena}");

        // Comportamiento del método ToString()
        Console.WriteLine($"Cadena usando ToString(): {cadena.ToString()}");

        // Recorrer la cadena con un ciclo Foreach
        Console.WriteLine("Recorriendo la cadena elemento por elemento:");
        foreach (char caracter in cadena)
        {
            Console.WriteLine(caracter);
        }

        // Buscar ocurrencia de una palabra determinada
        Console.WriteLine("Ingrese una palabra para buscar:");
        string palabraBuscar = Console.ReadLine();
        bool contienePalabra = cadena.Contains(palabraBuscar);
        Console.WriteLine($"La cadena {(contienePalabra ? "sí" : "no")} contiene la palabra '{palabraBuscar}'.");

        // Convertir a mayúsculas y luego a minúsculas
        string mayusculas = cadena.ToUpper();
        string minusculas = cadena.ToLower();
        Console.WriteLine($"Cadena en mayúsculas: {mayusculas}");
        Console.WriteLine($"Cadena en minúsculas: {minusculas}");

        // Separar la cadena por caracteres específicos
        Console.WriteLine("Ingrese los caracteres por los cuales desea separar la cadena:");
        char[] separadores = Console.ReadLine().ToCharArray();
        string[] partes = cadena.Split(separadores);
        Console.WriteLine("Resultado después de separar la cadena:");
        foreach (string parte in partes)
        {
            Console.WriteLine(parte);
        }
    }
}

