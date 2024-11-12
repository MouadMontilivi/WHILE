namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un fitxer anomenat bonus.txt conté una línia per a cada bitllet de loteria venut.
             ● Cada línia indica si el bitllet és "BONUS" o "NO BONUS".
             ● Si la línia és "BONUS", l'import associat és un enter aleatori entre 1€ i 10€.
             ● Crea un programa que processi aquest fitxer.
             ● El programa ha de comptar quants bonus s'han distribuït.
             ● També ha de calcular el total de bitllets i el percentatge de bitllets guanyadors.
             ● El fitxer acaba quan es troba un valor null.
             ● També has de calcular el total dels guanys i el nombre de bitllets amb BONUS.*/

            //declaracio variables
            int acumulador = 0, contBonus = 0, contTotal = 0;
            int valor;
            string linia;
            Random random = new Random();
            StreamReader fitxer = new StreamReader("bonus.txt");

            //demanar primer valor
            linia = fitxer.ReadLine();

            //mentre no final
            while(linia != null)
            {
                if (linia == "BONUS")
                {
                    contBonus++;
                    //valor = aleatori.Next(1, 11);
                    acumulador += random.Next(1, 11);
                }
                contTotal++;
                //demanar seguent
                linia = fitxer.ReadLine();
                Console.WriteLine($"S'han distribuit {contTotal} bitllets \n dels quals {contBonus} han sigut premiats \n + un percentatge de {Math.Round((double)contBonus / contTotal * 100, 2)}");
            }
            
            
            

        }
    }
}
