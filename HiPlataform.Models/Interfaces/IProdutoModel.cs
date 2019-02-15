namespace HiPlataform.Models.Interfaces
{
    public interface IProdutoModel
    {
        double Custo { get; }
        int Validade { get; }
        bool NecessitaRefrigeracao { get; }
        double ValorAquisicao { get; }
        VolumeOcupado VolumeOcupado { get; }
    }
}