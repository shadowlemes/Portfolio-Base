Portf�lio de Aplica��es em C#


Este projeto � um conjunto de aplicativos desenvolvidos em C# com foco em aprimorar habilidades de programa��o e construir um portf�lio. 
O menu principal oferece uma interface simples para acessar diferentes funcionalidades. Durante o processo de desenvolvimento, ser�o adicionados novos recursos e pr�ticas de clean Code.

Os principais conceitos de programa��o utilizados nos scripts:

1. Estrutura B�sica de um Programa C#
Namespaces: A organiza��o do c�digo em namespaces como MainMenu, CronometroOpcao, e JogoAdivinhacao � fundamental para estruturar melhor os diferentes m�dulos da aplica��o.
M�todos: Fun��es como Main(), MenuJogo(), e Inicio() encapsulam a��es espec�ficas do programa, favorecendo a modularidade e a reutiliza��o de c�digo.
Classes: A estrutura de classes como Cronometro e Program permite criar blocos organizados de c�digo, facilitando a manuten��o e expans�o do projeto.

2. Entrada e Sa�da (I/O) de Dados
Leitura de entrada do usu�rio: Utilizando Console.ReadLine() para capturar entradas do usu�rio. Este conceito � essencial em aplica��es interativas como seu jogo de adivinha��o e o cron�metro.
Sa�da de dados: O uso de Console.WriteLine() exibe mensagens e instru��es ao usu�rio, guiando a experi�ncia e a intera��o com o programa.

3. Tratamento de Exce��es
Try-Catch: Em v�rias partes dos seus scripts, voc� utiliza blocos try-catch para capturar exce��es como FormatException, assegurando que o programa continue funcionando mesmo quando o usu�rio insere dados inv�lidos. Isso aumenta a robustez do c�digo.

4. Controle de Fluxo
Loops: Utiliza��o de loops while e for para repeti��o de a��es, como contar o tempo no cron�metro e repetir tentativas no jogo de adivinha��o.
Condicionais: O uso de if, else if, e switch controla a l�gica de decis�es no programa, permitindo executar diferentes blocos de c�digo com base nas escolhas do usu�rio ou no resultado de uma a��o (por exemplo, verificando o n�mero correto no jogo de adivinha��o ou verificando a escolha de menu).

5. Manipula��o de Vari�veis e Constantes
Vari�veis: O uso de vari�veis como vidas no jogo e contagem no cron�metro permite armazenar e modificar dados ao longo da execu��o do programa.
Randomiza��o: Em JogoAdivinhacao, voc� usa o objeto Random para gerar n�meros aleat�rios, permitindo uma experi�ncia de jogo diferente a cada execu��o.

6. M�todos Est�ticos
Todos os m�todos nas classes s�o declarados como static, o que significa que pertencem � classe e n�o a inst�ncias de objetos. Isso facilita o acesso aos m�todos sem a necessidade de criar inst�ncias de cada classe.

7. Uso de Cores no Console
Console.ForegroundColor e Console.ResetColor: Voc� personaliza a interface do console alterando as cores do texto para destacar mensagens importantes (como avisos de erro ou notifica��es de vit�ria/derrota). Isso melhora a experi�ncia visual do usu�rio.

8. Organiza��o em Menus
Menu Principal: A estrutura de menus em MainMenu organiza os diferentes m�dulos da aplica��o, permitindo que o usu�rio escolha qual funcionalidade acessar. O uso de Console.Clear() ap�s selecionar uma op��o tamb�m contribui para uma interface mais limpa.
Redirecionamento: O redirecionamento de op��es no menu para outras funcionalidades (como o cron�metro ou jogo de adivinha��o) demonstra o conceito de navega��o e organiza��o de um programa com m�ltiplas funcionalidades.

9. Controle de Tempo
Thread.Sleep(): Utilizado para pausar a execu��o do programa por um determinado per�odo de tempo. Isso � especialmente vis�vel no cron�metro e nas transi��es de mensagens (por exemplo, pausando a tela para o usu�rio ler uma mensagem antes de prosseguir).

10. Recursividade
Recurs�o na reinicializa��o do cron�metro: No m�todo Cronometro.Inicio(), caso ocorra um erro de formato, voc� chama o pr�prio m�todo para reiniciar o processo, o que � um exemplo simples de recurs�o.

Funcionalidades
Jogo de Adivinha��o
O objetivo � adivinhar um n�mero aleat�rio gerado pelo sistema. O jogador recebe dicas se o n�mero � maior ou menor at� acertar.
Cron�metro

Uma funcionalidade de cron�metro simples, que permite iniciar uma contagem de tempo.
Forca (Em constru��o)

Um jogo da forca, atualmente em fase de desenvolvimento.
ToDo Lista (Em constru��o)

Uma aplica��o para gerenciar tarefas (ToDo List), em fase de desenvolvimento.
Conversor de Temperatura (Em constru��o)

Uma aplica��o para converter temperaturas entre diferentes unidades, tamb�m em desenvolvimento.
Como Executar o Projeto
Clone o reposit�rio:

bash
Copiar c�digo
git clone https://github.com/seu-usuario/seu-repositorio.git
Abra o projeto no Visual Studio ou no seu editor C# preferido.

Execute a aplica��o:

Compile e execute o programa.

Ao iniciar, voc� ver� o menu principal com as op��es dispon�veis.
Menu Principal

O menu principal � exibido assim que o programa � iniciado. Cada n�mero corresponde a uma funcionalidade:
1 - Jogo Adivinha��o: Redireciona para o jogo de adivinha��o de n�meros.
2 - Cron�metro: Redireciona para a funcionalidade de cron�metro.
3 - Forca: Em desenvolvimento.
4 - ToDo Lista: Em desenvolvimento.
5 - Conversor de Temperatura: Em desenvolvimento.
Se uma op��o inv�lida for escolhida, o sistema exibir� uma mensagem de erro e pedir� para o usu�rio tentar novamente.

Exce��es Tratadas
O programa trata erros de entrada, como quando o usu�rio insere um valor que n�o � num�rico, exibindo uma mensagem de erro e reiniciando o menu.
Tecnologias Utilizadas


Melhorias Futuras
Completar as funcionalidades em constru��o (Forca, ToDo Lista, Conversor de Temperatura).
Implementar testes unit�rios para validar as funcionalidades.
Utiliza��o de API
Adicionar interface gr�fica utilizando Windows Forms ou WPF.