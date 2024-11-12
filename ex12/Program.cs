namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Donat el fitxer alumnesDAMDAW.txt al moodle, recorre el fitxer per determinar si hi ha més
            alumnes que es diuen Alex o més alumnes Iker…*/

            //variables
            int contadorAlex = 0, contadorIker = 0;
            string linia;

            StreamReader fitxer = new StreamReader("alumnesDAMDAW.txt");

            //valors entrada primer element
            linia = fitxer.ReadLine();

            //mentre no final
            while(linia != null)
            {
                if(linia == "Alex")
                    contadorAlex++;
                else if( linia == "Iker")
                    contadorIker++;
                //seguent element
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            if (contadorAlex == contadorIker)
                Console.WriteLine("Hi ha els mateixos Ikers que Alex's");
            else if (contadorAlex > contadorIker)
                Console.WriteLine("Hi ha més Alex que Iker");
            else
                Console.WriteLine("Hi ha més Iker que Alex");



        }
    }
}
