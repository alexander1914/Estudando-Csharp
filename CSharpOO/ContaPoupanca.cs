using System;

namespace POO
{
    #region "C# Orientacao a Obejtos - Classes"
    // Assinatura do método feito com uma herença
    // Herença com gerenalização e uma herença apenas da classe Super Pai.
    public class ContaPoupanca : Conta, ITributo// Utilizando uma Iterface(São formadas pela declaração de um ou mais métodos, os quais obrigatoriamente não possuem corpo.)
    {
        public ContaPoupanca() : base(500)// BASE: Construtor da Classe Pai
        {

        }

        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }
        //Implementando metodo para Iterface
        public decimal CalcularTributo()
        {
            return base.Saldo * 0.02m;
        }
        #endregion
    }
}