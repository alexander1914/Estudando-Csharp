using System;

namespace POO
{
    #region "C# Orientação a Objetos" 
    // Assinatura do método feito com uma herença
    // Herença com especialização quando contem algo diferente.
    public class ContaCorrente : Conta
    {
        private decimal taxaMovimento;

        // Herença com Contrutor 
        public ContaCorrente() : base(3000)
        {
            this.TaxaMovimento = 0.1m;
        }

        public decimal TaxaMovimento
        {
            get { return taxaMovimento; }
            set { taxaMovimento = value; }
        }

        //Utilizando os Metodos Virtuais: Adiciona uma passo a mais na operação 
        // queira fazer com um tratamento
        // Realizando uma sobre carga explicidamente
        public override void Sacar(decimal valor)
        {
            base.Sacar(valor + (taxaMovimento * valor));
        }

        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }
    }
    #endregion
}
