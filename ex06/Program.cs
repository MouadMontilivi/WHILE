namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fes el mateix programa amb FI = null i dades procedents de fitxer NUMEROS2.TXT*/
            int numero, contador = 0, suma = 0;
            double mitjana;
            string linia;
            
            StreamReader fitxer = new StreamReader("NUMEROS2.TXT");
            linia = fitxer.ReadLine();

            Console.WriteLine("escriu un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while ( numero != 0)
            {
                contador++;
                suma = suma + numero;

                Console.WriteLine("escriu un altre numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            linia = fitxer.ReadLine();
            mitjana =(double)suma / contador;
            Console.WriteLine($"La suma dels numeros dona una mitja de {mitjana}");

        }
    }
}
