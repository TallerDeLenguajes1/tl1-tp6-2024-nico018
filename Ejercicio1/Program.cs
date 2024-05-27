using System;

namespace InvertirNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero))
            {
                if (numero > 0)
                {
                    int numeroInvertido = InvertirNumero(numero);
                    Console.WriteLine($"El número invertido es: {numeroInvertido}");
                }
                else
                {
                    Console.WriteLine("El número debe ser mayor a 0.");
                }
            }
            else
            {
                Console.WriteLine("El texto ingresado no es un número válido.");
            }
        }

        static int InvertirNumero(int numero)
        {
            int invertido = 0;
            while (numero > 0)
            {
                int digito = numero % 10;
                invertido = invertido * 10 + digito;
                numero /= 10;
            }
            return invertido;
        }
    }
}
