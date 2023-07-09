namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* Scrieti o functie care va determina daca un numar este sau nu numar prim. Apelati-o si afisati-i rezultatul.*/

            Console.WriteLine("Introduceti numarul: ");
            int numarIntrodus = int.Parse(Console.ReadLine());
            int resultaReturnat = VerificareNrPrim (numarIntrodus);
            if (resultaReturnat == 0)
            {
                Console.WriteLine("\n"+"{0} nu este numar prim.", numarIntrodus );
            }
            else
            {
                Console.WriteLine("\n"+"{0} este numar prim.", numarIntrodus);
            }
            
        }

         static int VerificareNrPrim(int numarIntrodus)
        {
            int i;
            for (i = 2; i <= numarIntrodus-1; i++)
            {
                if (numarIntrodus % i == 0 )
                {
                    return 0;
                   
                }
            }


            if (i == numarIntrodus)
            {
                return 1;
            }


            if (numarIntrodus ==1 )
            {
                return 0;
            }


           return 0;
        }
    }
}
