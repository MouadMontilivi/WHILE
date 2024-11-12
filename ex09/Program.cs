namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Fer un programa que donat un número enter positiu et digui quantes xifres té*/
            //declaracio variables
            int contador = 0, num;

            //demanar valor enter
            Console.WriteLine("escriu un valor enter: ");
            num = Convert.ToInt32(Console.ReadLine());

            //bucle
            while (num != 0)
            {
                contador++;
                //actualitzar el valor
                num = num / 10;
            }
            Console.WriteLine($"El numero {num} te {contador} digits");
        }
    }
}

/*declaracio variables
int contador = 0, num, modul = 1, aux;

//demanar valor enter
Console.WriteLine("escriu un valor enter: ");
num = Convert.ToInt32(Console.ReadLine());
aux = num % modul;
//mentre no final ( mentre no arribem al num)
while (aux != num)
{
    contador++;
    //acutalitzar el valor
    modul*=10;
    aux = num%modul;
}
Console.WriteLine($"El numero {num} te {contador} digits");*/

