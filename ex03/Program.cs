namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fes un programa per a saber quants valors positius i negatius hem introduït per teclat.*/ 
            
            //Declaracio variables
            int contPositius = 0, contNegatius = 0, numero;

            //demanar primer valor
            Console.WriteLine("Introdueix el primer valor: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //mentre (no final)
            while (numero != 0)
            {
                if(numero < 0)
                    contNegatius++;
                else contPositius++;

                //Demanar següent
                Console.WriteLine("Escriu el segon valor: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            //Mostrar resultats
            Console.WriteLine($"has introduït \t{contPositius} positius \n \t {contNegatius}");




        }
    }
}
