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
    
       // public void SomaTest()
        {

            //arrange
           // var x = 5;
           // var y = 5;
           // var esperado = 10;
           // var teste = new Teste();

            //act

            //var resultado;

            //assert

            //Assert.AreEqual(esperado, result);


        }

        public class Contas
        {

            public int Soma(int a, int b)
            {
                return a + b;
            }
            public int Subtracao(int a, int b)
            {
                return a - b;
            }
            public int Multiplicacao(int a, int b)
            {
                return a * b;
            }
            public int Divisao(int a, int b)
            {
                return a / b;
            }


        }
    
    
    
    }
    


}



