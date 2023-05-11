namespace Problema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fernando Gonzalez Zamora

            // input de datos
            string input = Console.ReadLine();
            //convertir a char 
            char[] inputArray = input.ToCharArray();
            //Auxiliares
            int cantidadZ=0;
            int cantidadO=0;
            for(int i=0; i<inputArray.Length; i++)
            {
                //contando los caracteres
                if (inputArray[i] == 'z' || inputArray[i] == 'Z')
                {
                    cantidadZ++;
                }
                else if (inputArray[i] == 'o' || inputArray[i] == 'O' )
                {
                    cantidadO++;
                }
            }
            //comparando con la formula 2*x=y
            if(cantidadZ*2 == cantidadO)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}