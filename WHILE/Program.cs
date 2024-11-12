namespace WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fes un programa per contar quants valors enters introdueix un usuari per Consola. Deixarem
            de contar valors en trobar el valor 0.
            Quin és el primer element que tractarem?
            Quina és la condició de final de recorregut?*/

            //declaracio variables
            int cont = 0, num;

            //Demanar primer valor
            Console.WriteLine("escriu un valor enter: ");
            num = Convert.ToInt32(Console.ReadLine());

            //mentre no final
            while (num != 0)
            {
                cont++;
                Console.WriteLine("escriu un altre valor enter: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Has escrit {cont} valors enters");

        }
    }
}
