using System;

namespace POO
{
    #region "C# Orientacao a Obejtos - Herença Conceito"
    //Herença = Classe Pai ou Super Classe, onde você faz a herenca dos metodos, atribudos
    // para usar para outra classe.
    public abstract class Conta // Abstract: Não é possível mais fazer instacia dessa classe, 
        // mais pode fazer herança.
    {
        #region "C# Orientação a Objetos - Encapsulamento"
        //Dados da conta conta corrente
        //private : mesmo não declarado, internamente e declarado
        //public : Permite o acesso das variaveis da classe
        int agencia;

        public int Agencia
        {
            // Qualquer um pode acessar a propriedade e fazer a leitura
            get { return agencia; } 
            // private so posso escrever de dentro, sendo uma restriçao
            set
            {
                if (value > 0)
                    agencia = value;
            }
        }

        int numeroConta;

        public int NumeroConta
        {
            get { return numeroConta; }
            private set { numeroConta = value; }
        }

        decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
            protected set { saldo = value; }// Proctected : Podendo utilizar o metodo set, 
            // classe vai utilizar ou no proprio programa.
        }

        public decimal Limite
        {
            get { return limite; }
            private set { limite = value; }
        }

        decimal limite;

        public Conta()
        {
           this.limite = 1000;
        }

        // Herença com Contrutor 
        public Conta(decimal limite)
        {
            this.limite = limite;
        }

        // Metodo utilizando THIS: referenciando da classe;       
        public void SetAgencia(int agencia)
        {
            // this: que eu estou se referenciando da classe.
            this.agencia = agencia;
        }
        #endregion

        // Metodos e seus Comportamentos
        //Utilizando os Metodos Virtuais(é uma função ou método cujo comportamento pode ser sobrescrito em uma classe herdeira,
        //por uma função com a mesma assinatura)
        public virtual void Sacar(decimal valor)
        {
            Saldo -= valor;
        }
        //Metodo abstract: Não premite implementação dentro da classe Pai,
        // nas classes herdadas aonde faço a implementação.
        public abstract void Depositar(decimal valor);
        
    }
    #endregion
}
   