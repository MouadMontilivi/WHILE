﻿namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Hem aconseguit els resultats del girona en un fitxer csv de la temporada 23/24 i reorganitzat
            una mica els partits per a que el girona jugui sempre una jornada com a local i una jornada com
            a visitant (hem reorganitzat les jornades que jugava dues vegades consecutives de visitant o de
            local). Per tant al fitxer Girona lliga23_24.txt acabat amb -1 on trobarem per cada dos files el
            resultat de cada jornada, sent la que la primera jornada el Girona jugava al Reale Arena (de
            visitant) tindrem que els resultats del Girona es troben a les posicions senars (contant com a 0
            la primera entrada del fitxer) i els resultats dels rivals a les posicions parell. Hem de contar
            quants partits ha guanyats, perduts i empatats el Girona. Si els partits guanyats son 3 punts i
            els empatats és 1 punt, calcula quants punts va conseguir el Girona la temporada 23/24.*/

            //declaracio variables
            int rival = 0, girona = 0, punts = 0, guanyats = 0, perduts = 0, empatats = 0, cont = 0;
            string linia;
            StreamReader fitxer = new StreamReader("Girona lliga23_24(1).txt");

            //demanar primer valor
            linia = fitxer.ReadLine();
            rival=Convert.ToInt32(linia);
            linia=fitxer.ReadLine();
            girona = Convert.ToInt32(linia);
            while (linia != null)
            {
                   if (cont % 2 == rival)
                    rival = Convert.ToInt32(linia);
                   else
                   {
                        empatats++;
                        punts++;
                   }
                   else
                        perduts++;
            }
            cont++;
            //demanar següent
            linia = fitxer.ReadLine();







            
                    
            
            else
                Console.WriteLine("Valors incorrectes");
        }
    }
}
