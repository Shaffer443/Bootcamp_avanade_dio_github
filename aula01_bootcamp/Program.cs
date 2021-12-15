using System;

namespace aula01_bootcamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = "Rafael"; 
            var b = "Gouveia";
            Console.WriteLine("Hello World!");
            Console.WriteLine(a,b); //Imprimir apenas a. 
            Console.WriteLine(a+b); //Concatenação
            Console.WriteLine(a+" "+b);//Concatenação 2. Assim ele concatena com espaço, mas também pode-se da espaço direto na string da variável.
        }
    }
}
