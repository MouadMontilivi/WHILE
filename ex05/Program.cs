namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fer un programa que vagi demanant per teclat números fins trobar el zero i calculi la mitjana dels valors introduïts*/

            //declaracio variables
            int numero;
            int contador = 0;
            int suma = 0;
            double mitjana;



            //iniciar variables
            Console.Write("Escriu un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //mentre no final
            while(numero != 0)
            {
                contador++;
                suma = suma + numero;
                //demanar següent
                Console.Write("Escriu un altre numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

            }
            mitjana = (double)suma/contador;
            Console.WriteLine($"La mitja dels numeros donen {mitjana}");




        }
    }
}
