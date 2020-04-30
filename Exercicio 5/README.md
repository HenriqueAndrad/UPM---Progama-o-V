Apply:

O que precisa fazer para usar:
Escolher qual o option que você quer passar como parâmetro da função, colocar ".Apply" e passar de parâmetro a função que você quer que seja aplicada naquele option.

Como funciona:
A função vai receber um option que encapsula uma função e outro option que encapsula um argumento. Essa função vai acessar a booleana "isSome" para checar se as duas options possuem um valor. Caso ambas tenham, a função retornará um option com o resultado da função encapsulada aplicada no argumento. Caso algum dos options nao tenha valor, retorna uma option "FP.None".

Quando usar:
Você deve usar o Apply quando quiser aplicar uma função encapsulada a um valor encapsulado.
