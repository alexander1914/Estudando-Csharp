using System;
using System.Collections;

namespace ConsoleCSharp {

    class ConsoleCSharp
    {
        #region "Iniciando C# Estudar Variaveis e Operadores de Igualdade e Estrutura de Repitição"
        //static void Main()
        //{
        //    // Variaveis 
        //    int a = 2;
        //    int b = 10;

        //    Operadores de Igualdades

        //    if (a != b)
        //        Console.WriteLine("Valores Diferentes");
        //    else
        //        Console.WriteLine("Iguais");

        //    Operadores Relacionais

        //    //if (a >= b)
        //    //    Console.WriteLine("A maior ou igual a B");
        //    //else if (b >= a)
        //    //    Console.WriteLine("B maior ou igual a A");

        //    Console.ReadLine();

        //    Estrutura de Repetição
        //    int[] colecao = new int[] {1, 3, 10, 50 };
        //    int indice = 12;

        //    Do While

        //    do
        //    {
        //      Console.WriteLine(indice);
        //      indice--;
        //    } while (indice > 10);

        //    While

        //    while(indice > 0)
        //    {
        //      Console.WriteLine(indice);
        //      indice--;
        //    }

        //    For

        //    for(int i = 0; i <= 10; i++)
        //    {
        //      Console.WriteLine(i);
        //    }

        //    Foreach

        //    foreach (var item in colecao)
        //    {
        //      Console.WriteLine(item);
        //    }

        //    int idade = 80;

        //    string resultado = idade > 60 ? "Aposentado" : "Trabalhando"; // Teste Condição Ternaria 
        //    Console.WriteLine(resultado);

        //    switch (idade)
        //    {
        //      case 80:
        //      case 70:
        //      case 60: Console.WriteLine("Aposentado");
        //             break;
        //      case 10: Console.WriteLine("Crianca");
        //             break;
        //      default: Console.WriteLine("Indefinido");
        //             break;
        //    }

        //    Console.ReadLine();

        //    CONDICAO IF 

        //    if (idade > 17)
        //    {
        //      Console.WriteLine("Autorizado");

        //      Console.WriteLine("Segundo Autorizado");
        //    }
        //    else if (idade > 2)

        //      Console.WriteLine("Bebe suco");

        //    else
        //      Console.WriteLine("Bebe Leite");


        //    int a = 15;
        //    int b = 2;

        //    Imcremento
        //    a++
        //    Decremento
        //    a-- ou a -= seu valor
        //    a -= 3; // Imcrementando o valor que eu quiser
        //    Console.WriteLine(a);

        //    decimal resultado = Convert.ToDecimal(a) / Convert.ToDecimal(b); //Cast Decimal para cada variavel. 

        //    int resultado = a / b;
        //    int resto = a % b;

        //    Console.WriteLine(resultado);
        //    Console.WriteLine(resto);

        //    int matricula = 10;
        //    string nome = "Alexander"; 
        //    string sobrenome = "Oliveira";
        //    DateTime dataNascimento = DateTime.Now;
        //    decimal salario = 1000.50m;
        //    bool feriasVencidas = true;
        //    char sexo = 'M';

        //    Imprimindo com Console
        //    Console.WriteLine(matricula);
        //    Console.WriteLine(string.Format("{0} {1}", nome, sobrenome));        
        //    Console.WriteLine(dataNascimento);
        //    Console.WriteLine(salario);
        //    Console.WriteLine(feriasVencidas);
        //    Console.WriteLine(sexo);

        //}

        //


        //public static void ExibirMensagem()
        //{
        //    // Metodos podem ser Staticos , Publicos ou Privados
        //    Console.WriteLine("Meu Primeiro Metodo");
        //}

        //static string RetornarString()
        //{
        //    // Metodo com retorno (INT , BOOL , String deve conter um return)
        //    string texto = "Campeão Mundial 2017 Palmeiras";
        //    return texto;
        //}
        #endregion

        #region"Iniciando C# Estudo de Metodos "
        //static void ImprimirValor(decimal valor, string mensagem)
        //{
        // Metodo com Parametros 
        //Console.WriteLine(mensagem + valor);
        //}

        //static void Somar10(int valor)// Metodo sem referencia
        //{
        //valor += 10;
        //Console.WriteLine(valor);
        //}

        // static void Somar10(ref int valor)// Metodo por referencia
        //{
        // valor += 10;
        // Console.WriteLine(valor);


        // static void Main()
        // {
        // int valorInicial = 20;
        // Na chamada do Metodo dever colocar a REF para usar por referencia
        // Somar10(ref valorInicial);

        // Console.WriteLine(valorInicial);

        // Fazendo a chamada do metodo e tipando os valores 
        // decimal numero = 100.33m;
        // ImprimirValor(numero, "Informei o numero: ");
        // Console.WriteLine(numero);

        // ExibirMensagem();
        // Execuntando Metodo Com Retorno, com uma variavel do mesmo tipo.
        // string retornada = RetornarString();
        // Console.WriteLine(retornada);

        // Console.ReadLine();
        // }
        #endregion

        #region "Iniciando C# Estudo de Classes"
        //static void Main()
        //{
        //Objeto para representação da classe(e Instânciando o Objeto criado para classe)
        //Pessoa p = new Pessoa();// Criando o Objeto

        // Preenchendo os Objetos de acordo os tipos
        //p.Nome = "Alexander";
        //p.Sobrenome = "Oliveira";
        //p.Idade = 26;
        //p.Sexo = Sexo.Masculino;// Usando o ENUM

        //p.Falar(string.Format("Olá, sou o {0} {1}, tenho {2} anos, meu sexo é {3}"
        //    , p.Nome, p.Sobrenome, p.Idade, p.Sexo));

        //p = new Pessoa();// Criando novo Objeto

        //p.Falar(string.Format("Olá, sou o {0} {1}, tenho {2} anos"
        //    , p.Nome, p.Sobrenome , p.Idade));

        //Console.ReadLine();
        //}
        #endregion

        #region "Inciando C# Estudo Estrutura de Fila, Pilhas e Lista"
        // static void Main(){
        // Estrutura de Fila
        //Para Utilizar Fila (Queue)
        //Queue fila = new Queue();
        //Para Enfilerar (Enqueue)
        //fila.Enqueue("Felipe");
        //fila.Enqueue("Antonio");
        //fila.Enqueue("Nathalia");
        //fila.Enqueue("Jesus");

        //fila.TrimToSize();
        //while (fila.Count > 0)
        //{
        //   Para tirar da Fila Dequeue
        //   var nome = fila.Dequeue();// O Importante e Desenfilerar Sempre
        //   Console.WriteLine(nome);
        //}
        //    Console ReadLine(); 

        // Estrutura de Pilha
        //Stack pilha = new Stack();
        //pilha.Push("Prato 1");
        //pilha.Push("Prato 2");
        //pilha.Push("Prato 3");
        //pilha.Push("Prato 4");
        //pilha.Push("Prato 5");

        //while (pilha.Count > 0)
        //{
        //  Para despilhar os pratos
        //   var prato = pilha.Pop();
        //   Console.WriteLine(prato);
        //}

        //   Console.ReadLine();

        // Estrutura de Lista: Diferenca não tem metodo igual no pilha e fila
        //ArrayList lista = new ArrayList();
        //lista.Insert(0, "item 1");
        //lista.Insert(1, "item 2");
        //lista.Insert(2, "item 3");

        //// Lista da Opção de Inserir o item na posicao que eu achar melhor
        //lista.Insert(0, "INTRUSO");

        //for(int i = 0; i < lista.Count; i++)
        //{
        //    // Passando o item da lista atraves do i(Indice do vetor)
        //    var item = lista[i];
        //    //lista.RemoveAt(0); Remover apenas item da lista
        //    Console.WriteLine(item);
        //}
        //    Console.ReadLine();
        //}
        #endregion

        static void Main()
        {

        }
    }
}