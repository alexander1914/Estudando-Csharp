using System;

namespace POO
{
    #region "C# Orientação a Objetos Polimorfismo"
    // Polimorfismo: São varias formas para meu parametro
    // é um mecanismo por meio do qual selecionamos as funcionalidades utilizadas de forma dinâmica por um programa no decorrer de sua execução.
    public class Relatorio
    {
        public decimal SaldoGeral { get; private set; }
        public decimal TributoGeral { get; private set; }

        //Utilizando uma Interface com metodo
        public void SomarTributos(ITributo conta)
        {
            this.TributoGeral += conta.CalcularTributo();
        }

        public void Somar(Conta conta)
        {
            this.SaldoGeral += conta.Saldo;
        }
        // Polimorfismo : quando tenho metodos com assinaturas diferentes
        // É um mecanismo por meio do qual selecionamos as funcionalidades utilizadas de forma dinâmica por um programa no decorrer de sua execução.
        public void SomarValor(decimal valor1)
        {
            this.SaldoGeral += valor1;
        }

        public void SomarValor(decimal valor1, decimal valor2)
        {
            this.SaldoGeral += valor1 + valor2;
        }
        
    }
    #endregion
}
