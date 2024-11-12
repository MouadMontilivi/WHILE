namespace ex15b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Girona juga 1 copa a casa 1 cop a fora*/

            //Demanar varaiables
            int victories = 0, derrotes = 0, empats = 0, contador = 0, puntsTotals = 0;
            int girona, rival, golsGirona, local;
            string linia;
            
            StreamReader fitxer = new StreamReader("Girona lliga23_24(visitant-local).txt");

            //demanar primer valor
            linia = fitxer.ReadLine();
            girona = Convert.ToInt32(linia);
            linia = fitxer.ReadLine();
            rival = Convert.ToInt32(linia);
            linia = fitxer.ReadLine();
            local = Convert.ToInt32(linia);

            while(linia != null)
            {
                if (contador % 2 == 0)
                {
                    if (local) //juguen com a local
                        girona = Convert.ToInt32(linia);
                    else
                        rival = Convert.ToInt32(linia);
                }
                else //juguen com a visitant
                {
                    if (!local)
                        girona = Convert.ToInt32(linia);
                    else (rival)
                            rival = Convert.ToInt32(linia); 
                    if(girona > rival)
                        victories++;
                    else if(girona < rival)
                        derrotes++;
                    else
                        empats++;
                }
                linia = fitxer.ReadLine();
                
            }

            puntsTotals = (victories * 3) + (empats * 1);

            Console.WriteLine($"Victòries: {victories}");
            Console.WriteLine($"Empats: {empats}");
            Console.WriteLine($"Derrotes: {derrotes}");
            Console.WriteLine($"Punts totals: {puntsTotals}");
        }
    }
}
