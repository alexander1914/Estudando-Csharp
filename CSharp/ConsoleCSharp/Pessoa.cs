using System;

namespace ConsoleCSharp
{

    #region "Inciando C# STRUCT E ENUM"
    //STRUCT: Para ser utilizado com menos recursos não é uma classe(NÃO PODE SER HERDADO)
    //public struct MinhaData
    //{
    //    DateTime dataAtual;
    //}

    // ENUM: Uma Coleção de Propriedade, Fechada seguinda uma ordem numerica
    //public enum Sexo
    // {
    //     Masculino = 1,
    //     Femino
    // }
    #endregion

    #region "Inciando C# Construtores"
    //public class Pessoa
    //{
    // CLASSE : Contem propriedades e metodos(São comportamentos da Classe)
    //public string nome;
    //public string sobrenome;
    //public int idade;
    //public char sexo;

    // Utilizando o ENUM
    //private Sexo sexo;

    //public Sexo Sexo
    //{
    //    get { return sexo; }
    //    set { sexo = value; }
    //}

    #region "Iniciando C# ENCAPSULAMENTO"
    //public string nome;// Field Nome 

    //public string Nome {
    // Fazendo a customização
    //get { return nome; }
    //set { nome = value; }
    //}

    //private string sobrenome;

    //public string Sobrenome
    //{
    //    get { return sobrenome; }
    //    set { sobrenome = value; }
    //}

    //private int idade;

    //public int Idade
    //{
    //    get { return idade; }
    //    set {
    //        if(value >= 0)// Criando Validação Set valor Real
    //            idade = value;
    //    }
    //}


    //Construtor - comando ctor metodo da classe(TODO CONSTRUTOR TEM MESMO NOME IGUAL DA CLASSE)
    //    public Pessoa()
    //    {
    //        nome = "Eduardo Batista"; // Setando novo nome
    //    }
    #endregion
    
    //    //Metodo seu Comportamento
    //    public void Falar(string mensagem)
    //    {
    //        Console.WriteLine(mensagem);
    //    }
    //}
    #endregion
}
