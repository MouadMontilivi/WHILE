namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fes un programa on llancem un dau de 6 cares (valors de forma aleatoria) fins que el número
            de vegades que surti 1 i 6 sigui el mateix. Conta quantes vegades hem llançat el dau i quantes
            vegades ha aparegut el valor 6.*/

            //declaracio variables
            int dau, contador = 0, contador1 = 0, contador6 = 0;
            Random random = new Random();

            //iniciar variables
            //demanar primer
            dau = random.Next(1, 7);

            //mentre no final
            while(contador1 != contador6 || contador1 == 0 || contador6 == 0)
            {
                if (dau == 1)
                    contador1++;
                else if (dau == 6)
                    contador6++;
                else
                    contador++;
                //actualitzar element
                dau = random.Next(1, 7); 
            }
            contador = contador + contador1 + contador6;
            Console.WriteLine($"Has tirat el dau {contador} vegades \n  el valor 6 ha aparegut {contador6} vegades i el valor");
        }
    }
}
/*el while, mentre el cont1 sigui diferent a cont6 o cont1 doni 0 o cont6 doni 0 */