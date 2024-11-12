namespace ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*S'introdueix per teclat el valor del radi r d'una circumferència. Tenim un fitxer de dades
              coordenades.txt que conté coordenades en el següent format: cada coordenada x a cada línia
             senar i cada coordenada y a cada línia parell. Quan arribem al valor nul en comptes d'una
              coordenada x real, s'haurà arribat a la marca de final. Un exemple de fitxer amb el format
             especificat anteriorment:
             -2,6 → coordenada x
             3,8 → coordenada y
              El programa ha d'informar per a cada punt si està dins, fora o sobre el perímetre de la
              circumferència de radi r i centre (0.0).*/

            //Declarar varaibles
            double coordenadaX, coordenadaY, radi, distancia;
            string linia;
            int contador = 0, dins = 0;

            StreamReader fitxer = new StreamReader("coordenades.txt");

            //demanar primer valor
            Console.WriteLine("Escriu el radi de la circumferència: ");
            radi = Convert.ToInt32(Console.ReadLine());
            linia = Console.ReadLine();

        
            while(linia != null)
            {

                if( contador % 2 == 0)
                    coordenadaX = Convert.ToDouble(linia.Replace(".", ","));
                else
                {
                    coordenadaY = Convert.ToDouble(linia.Replace(".", ","));
                    distancia = Math.Round(distancia(coordenadaX, coordenadaY), 2);
                    if(radi > distancia)
                        Console.WriteLine($"Les coordeandes ");
                }
                {
                    //demanar seguent
                    coordenadaY = Convert.ToDouble(linia);

                    distancia = Math.Sqrt(coordenadaX * coordenadaX + coordenadaY * coordenadaY);

                    if(distancia < radi)
                    {
                        Console.WriteLine($"El punt ({coordenadaX}, {coordenadaY}) està dins");
                    }
                    else if(distancia == radi)
                    {
                        Console.WriteLine($"El punt ({coordenadaX}, {coordenadaY}) està sobre la circumferència");
                    }
                    else
                    {
                        Console.WriteLine($"El punt ({coordenadaX}, {coordenadaY}) està fora");
                    }
                }
            }


        }
    }
}
