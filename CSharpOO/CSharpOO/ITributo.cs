using System;


namespace POO
{
    #region "C# Orientação a Objetos - Interface"
    public interface ITributo
    {
        //Interface: O Contrato define algo e deve comprir o foi definido no contrato.
        // Não contém implementação concreta apenas as assinaturas.
        decimal CalcularTributo();
    }
    #endregion
}
