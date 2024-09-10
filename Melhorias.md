Considerando princípios de Clean Code e SOLID, seguem alguns pontos de melhoria:

1. Nomeação de Variáveis e Métodos (Clean Code)
Nome do Método e Classe: O método calculos e a classe calc1 têm nomes muito genéricos. Idealmente, o nome de um método deve indicar claramente o que ele faz. Por exemplo, CalcularValorComDesconto poderia ser um nome mais descritivo.
Variáveis: As variáveis val, tip, anos, res e desc têm nomes pouco expressivos. Elas poderiam ter nomes mais descritivos para facilitar o entendimento do código, como valorOriginal, tipoDaConta, tempoDeContaEmAnos, valorComDesconto e percentualDescontoPorFidelidade.

2. Princípio de Responsabilidade Única (SOLID - SRP)
O método calculos está fazendo várias coisas: calcula o desconto com base no tempo (anos), realiza operações com base no tipo (tip) e retorna o valor final. Isso viola o Princípio de Responsabilidade Única. Cada método deve ter uma responsabilidade específica. Uma solução seria quebrar este método em métodos menores, cada um responsável por uma parte específica da lógica.

3. Princípio Aberto/Fechado (SOLID - OCP)
Atualmente, o método calculos não está aberto para extensão, mas fechado para modificação. Se precisar adicionar um novo tipo de cálculo, será necessário modificar o método diretamente, o que viola o princípio de Aberto/Fechado (OCP). Uma abordagem melhor seria usar uma interface ou classe abstrata para diferentes tipos de cálculo, e então implementar subclasses para cada tipo de cálculo específico. Isso permitiria adicionar novos cálculos sem modificar o código existente.

4. Eliminação de Códigos Mágicos (Clean Code)
Existem vários valores hard-coded (ex.: 0.1m, 0.7m, 0.5m) que representam percentuais de desconto. Esses números mágicos deveriam ser extraídos para constantes com nomes descritivos para facilitar a manutenção e a compreensão.

5. Complexidade Ciclomática (Clean Code)
O método contém uma sequência de estruturas condicionais (if-else) que aumentam a complexidade ciclomática. Isso pode ser simplificado usando estratégias de design orientadas a objetos, como o padrão Strategy, onde cada tipo de cálculo seria encapsulado em sua própria classe, reduzindo as ramificações do código.