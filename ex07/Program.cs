using System.Net;
using System.Runtime.ConstrainedExecution;

namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fer un programa que vagi demanant números fins trobar el zero i ens digui el valor més gran i
            el valor més petit.*/

            //Declaracio variables
            int numero, numMajor, numMenor;

            //Demanar primer element
            Console.WriteLine("Escriu un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            numMajor = numero;
            numMenor = numero;

            //mentre no final
            while (numero != 0)
            {
                if (numMajor < numero)
                    numMajor = numero;

                else if (numMenor > numero)
                    numMenor = numero;

                //Demanar seguent valor
                Console.WriteLine("escriu un altre numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

            }

            //Mostrar resultats
            Console.WriteLine($"El numero menor es {numMenor} i el numero major es {numMajor}");

        }
    }
}
