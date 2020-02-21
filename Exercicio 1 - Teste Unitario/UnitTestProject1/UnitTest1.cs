using System;
using Exercicio_1___Teste_Unitario;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    
    [TestClass]
    public class UnitTest1
    {



        [TestMethod]
        public void TestMethod1()
        {
            int n1 = 10;
            int n2 = 20;
            int n3 = 0;
            int n4 = 30;

            Calculator calculator = new Calculator();
            calculator.Add(n1, n2, n3);

            if (n4 == n3)
            {
                Console.WriteLine("Os resultados batem");
            } else
            {
                Console.WriteLine("Resultados diferentes");
            }
        }

        public void TestMethod2()
        {
            int n1 = 20;
            int n2 = 10;
            int n3 = 0;
            int n4 = 2;

            Calculator calculator = new Calculator();
            calculator.Div(n1, n2, n3);
            if (n4 == n3)
            {
                Console.WriteLine("Os resultados batem");
            }
            else
            {
                Console.WriteLine("Resultados diferentes");
            }
        }
      
    }
    
}
