namespace HiPlataform.Models.Interfaces
{
    public interface IParametrizacaoDesconto
    {
        double PercentualDescontoAdicionalVolumeOcupado { get; }
        int LimiteDiasDesconto { get; }
        bool PermitePrecoAbaixoValorAquisicao { get; }
        double ValorMinimoVenda { get; }
    }
}