A programação funcional facilita muito teste unitário pois não há mudança no valor de uma variável e consequentemente e não a necessidade de depender de um certo estado desta variável para realizar o teste.

E também a programação funcional é melhor para PCs com hardware menos potentes por conta o objeto não precisa ficar alocado na memória sofrendo mutações, na funcional os processos não precisam ser colocados e retirados por um trash collector.

As desvantagem é que como na maioria das vezes há a criação de variáveis novas para evitar a alteração dos valores de outras variáveis, o processo não é bom caso precise ser executado diversas vezes, como em um update.
