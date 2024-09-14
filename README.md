Portfólio de Aplicações em C#


Este projeto é um conjunto de aplicativos desenvolvidos em C# com foco em aprimorar habilidades de programação e construir um portfólio. 
O menu principal oferece uma interface simples para acessar diferentes funcionalidades. Durante o processo de desenvolvimento, serão adicionados novos recursos e práticas de clean Code.

Os principais conceitos de programação utilizados nos scripts:

1. Estrutura Básica de um Programa C#
Namespaces: A organização do código em namespaces como MainMenu, CronometroOpcao, e JogoAdivinhacao é fundamental para estruturar melhor os diferentes módulos da aplicação.
Métodos: Funções como Main(), MenuJogo(), e Inicio() encapsulam ações específicas do programa, favorecendo a modularidade e a reutilização de código.
Classes: A estrutura de classes como Cronometro e Program permite criar blocos organizados de código, facilitando a manutenção e expansão do projeto.

2. Entrada e Saída (I/O) de Dados
Leitura de entrada do usuário: Utilizando Console.ReadLine() para capturar entradas do usuário. Este conceito é essencial em aplicações interativas como seu jogo de adivinhação e o cronômetro.
Saída de dados: O uso de Console.WriteLine() exibe mensagens e instruções ao usuário, guiando a experiência e a interação com o programa.

3. Tratamento de Exceções
Try-Catch: Em várias partes dos seus scripts, você utiliza blocos try-catch para capturar exceções como FormatException, assegurando que o programa continue funcionando mesmo quando o usuário insere dados inválidos. Isso aumenta a robustez do código.

4. Controle de Fluxo
Loops: Utilização de loops while e for para repetição de ações, como contar o tempo no cronômetro e repetir tentativas no jogo de adivinhação.
Condicionais: O uso de if, else if, e switch controla a lógica de decisões no programa, permitindo executar diferentes blocos de código com base nas escolhas do usuário ou no resultado de uma ação (por exemplo, verificando o número correto no jogo de adivinhação ou verificando a escolha de menu).

5. Manipulação de Variáveis e Constantes
Variáveis: O uso de variáveis como vidas no jogo e contagem no cronômetro permite armazenar e modificar dados ao longo da execução do programa.
Randomização: Em JogoAdivinhacao, você usa o objeto Random para gerar números aleatórios, permitindo uma experiência de jogo diferente a cada execução.

6. Métodos Estáticos
Todos os métodos nas classes são declarados como static, o que significa que pertencem à classe e não a instâncias de objetos. Isso facilita o acesso aos métodos sem a necessidade de criar instâncias de cada classe.

7. Uso de Cores no Console
Console.ForegroundColor e Console.ResetColor: Você personaliza a interface do console alterando as cores do texto para destacar mensagens importantes (como avisos de erro ou notificações de vitória/derrota). Isso melhora a experiência visual do usuário.

8. Organização em Menus
Menu Principal: A estrutura de menus em MainMenu organiza os diferentes módulos da aplicação, permitindo que o usuário escolha qual funcionalidade acessar. O uso de Console.Clear() após selecionar uma opção também contribui para uma interface mais limpa.
Redirecionamento: O redirecionamento de opções no menu para outras funcionalidades (como o cronômetro ou jogo de adivinhação) demonstra o conceito de navegação e organização de um programa com múltiplas funcionalidades.

9. Controle de Tempo
Thread.Sleep(): Utilizado para pausar a execução do programa por um determinado período de tempo. Isso é especialmente visível no cronômetro e nas transições de mensagens (por exemplo, pausando a tela para o usuário ler uma mensagem antes de prosseguir).

10. Recursividade
Recursão na reinicialização do cronômetro: No método Cronometro.Inicio(), caso ocorra um erro de formato, você chama o próprio método para reiniciar o processo, o que é um exemplo simples de recursão.

Funcionalidades
Jogo de Adivinhação
O objetivo é adivinhar um número aleatório gerado pelo sistema. O jogador recebe dicas se o número é maior ou menor até acertar.
Cronômetro

Uma funcionalidade de cronômetro simples, que permite iniciar uma contagem de tempo.
Forca (Em construção)

Um jogo da forca, atualmente em fase de desenvolvimento.
ToDo Lista (Em construção)

Uma aplicação para gerenciar tarefas (ToDo List), em fase de desenvolvimento.
Conversor de Temperatura (Em construção)

Uma aplicação para converter temperaturas entre diferentes unidades, também em desenvolvimento.
Como Executar o Projeto
Clone o repositório:

Execute a aplicação:

Compile e execute o programa.

Ao iniciar, você verá o menu principal com as opções disponíveis.
Menu Principal

O menu principal é exibido assim que o programa é iniciado. Cada número corresponde a uma funcionalidade:
1 - Jogo Adivinhação: Redireciona para o jogo de adivinhação de números.
2 - Cronômetro: Redireciona para a funcionalidade de cronômetro.
3 - Forca: Em desenvolvimento.
4 - ToDo Lista: Em desenvolvimento.
5 - Conversor de Temperatura: Em desenvolvimento.
Se uma opção inválida for escolhida, o sistema exibirá uma mensagem de erro e pedirá para o usuário tentar novamente.

Exceções Tratadas
O programa trata erros de entrada, como quando o usuário insere um valor que não é numérico, exibindo uma mensagem de erro e reiniciando o menu.
Tecnologias Utilizadas


Melhorias Futuras
Completar as funcionalidades em construção (Forca, ToDo Lista, Conversor de Temperatura).
Implementar testes unitários para validar as funcionalidades.
Utilização de API
Adicionar interface gráfica utilizando Windows Forms ou WPF.
