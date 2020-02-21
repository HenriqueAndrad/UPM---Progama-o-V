    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1___Teste_Unitario
{
    // Exercicio 1 - 
    // A escola de Detroid começa com os "testes de dentro para fora do código", e buscando apenas o resultado certo de uma parte do código, para eles o mais importante é o método funcionar, nao importando como.
    // A escola de Londres, diz que cada teste deve ser feito vendo a interação de uma classe com outras para garantir que o progama funcione como geral, para eles o mais importante é o funcionamento do metodo junto a outros métodos do programa.

    // Exercicio 2a  - https://docs.microsoft.com/pt-br/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2019

    public class Calculator
    {
        
        static void Main(string[] args)
        {





        }

       

        public void Add (int n1, int n2, int n3)
        {
            

            n3 = n1 + n2;
        }

        public void Div (int n1, int n2, int n3)
        {
           
            n3 = n1 / n2; 
        }

    }
}
