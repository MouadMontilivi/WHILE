namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Considerem el fitxer BONUS2.TXT per al càlcul del BONUS.
            ● Quan apareix la paraula "BONUS", a continuació hi ha la quantitat guanyada a la següent línia.
           ● Si es troba "NO BONUS", no hi ha cap quantitat associada.
           ● Processa el fitxer per identificar les línies amb "BONUS" i extreure les quantitats de cada BONUS.
            ● Finalment, calcula el total dels guanys i el nombre de bitllets amb BONUS.*/



            //declaracio variables
            int acumulador = 0, contBonus = 0, contTotal = 0;
            int valor;
            string linia;

            StreamReader fitxer = new StreamReader("BONUS2.txt");

            //demanar primer valor
            linia = fitxer.ReadLine();

            //mentre no final
            while (linia != null)
            {
                if (linia == "BONUS")
                {
                    linia = fitxer.ReadLine();
                    acumulador = acumulador + Convert.ToInt32(linia);
                    contBonus++;
                }
                contTotal++;
                //demanar seguent
                linia = fitxer.ReadLine();
                Console.WriteLine($"S'han distribuit {contTotal} bitllets \n dels quals {contBonus} han sigut premiats \n + un percentatge de {Math.Round((double)contBonus / contTotal * 100, 2)}");
            }


        }
    }
}
