using System;
class unonueve
    {
    static void Main(string[] args)
    {
try
        {
            Console.WriteLine("Ingresar un valor postivo de un digito o dos digitos");
            int Numero = int.Parse(Console.ReadLine());
            if (Numero > 0)
                if (Numero < 100)
            {
                if (Numero < 10)
                {
                    Console.WriteLine("El valor numerico es de un digito");
                }
                else {
                    Console.WriteLine("Él valor numerico es de dos digitos");

                }
            }
            else {
                Console.WriteLine("Invalido, El valor numerico debe ser desde el 1 al 99");
            }
            
            }
        catch(FormatException) 
        {
            Console.WriteLine("Ingrese un  valor numerico valido, por favor.");
        }

        catch(Exception ex)
        {

            Console.WriteLine($"Error, presionar enter.: {ex.Message}");

        }
        }

    }

