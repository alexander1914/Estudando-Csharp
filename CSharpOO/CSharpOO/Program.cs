using System;

namespace POO
{
    #region" C# Orientação a Objetos - Customizando Execeções"
    class MinhaExececao : Exception
    {
        public Exception MensagemErro(string msg)
        {
            return new Exception(msg);
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            // A Instacia do Objeto: da Classe conta corrente

            // Abstract: Não posso mais fazer instacia dessa classe(criar um Objeto), 
            // continua fazendo as herenças.
            //Conta c = new Conta();
            #region "C# Orientado a Objetos - Try/Cacth, Niveis de Exceção"
            try// Try Catch: Realiza o tratamento com as Execções do erro.
            {
                int a = 10;
                int b = 0;

                if (b == 0)
                    //Execption Generica, Utilizando minha Exececao Customizada
                    // throw feito lançamento da minha Exception atraves de uma logica,
                    // que foi definido.
                    throw new MinhaExececao().MensagemErro("Uma Mensagem qualquer de ex");

                int resultado = a / b;
                Console.WriteLine(resultado);

                int[] vetor = new int[] { 1, 2, 3 };
                Console.WriteLine(vetor[0]);

            }
            // Niveis de Execeção : Através do catch pode realizar varios niveis de exceção
            // posso ter quantos catch for necessario explicidamente.
            catch (System.DivideByZeroException ex)// ex recebe a Execção para lançar no throw
            {
                Console.WriteLine("Erro: Divisão por zero !!!");//O Padrão da Execção é Lança a Execção do Erro
            // ex: Objeto da classe Exception, contém Message que mostrar a mensagem,
            // StackTrace é uma de passos do que foi realizado até gerar o erro. 
            }
            catch (System.IndexOutOfRangeException ex)
            {
                Console.WriteLine("Erro: Fora do indice da coleção*** ");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
            finally// Finallly: Sempre vai executar após entrar em um Try, 
            //indenpendente saida do try, for com uma Exception ou não.
            // a ordem do finally sempre depois do catch(Com as Execeções).
            {
                Console.WriteLine("Fim da Execução.");
            }
            #endregion
            Console.Read();

            //ContaCorrente cc = new ContaCorrente();
            //ContaPoupanca cp = new ContaPoupanca();

            //cc.Depositar(1000);
            //cp.Depositar(1000);

            //cc.Sacar(200);
            //cp.Sacar(200);

            //Console.WriteLine(cc.Saldo);
            //Console.WriteLine(cp.Saldo);

            //Relatorio rel = new Relatorio();
            //rel.Somar(cc);
            //rel.Somar(cp);
            //rel.SomarTributos(cp);

            // Exemplo Polimorfismo com Metodos.
            //rel.SomarValor(10);
            //rel.SomarValor(10, 10);

            //Console.WriteLine(rel.SaldoGeral);
            //Console.WriteLine(rel.TributoGeral);


        }
    }
}

#region "C# Orientação a Objeto - Debugging Brek, Watch "
// Para marcar o brekpoint clica ao lado direito da linha (user F9)
// Para navegar entre os metodos usei F11(Para acessar o metodo)
// Para pular use(F10)

// Brekpoint: é possivel colocar uma codição, para uma validação ou
//para utilizar em loops while ou for.
// na linha do brekpoint(Presione o botão direito, seleciona a opção conditions e  defina uma condição )  


#endregion


