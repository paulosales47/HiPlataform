using HiPlataform.Models.Interfaces;

namespace HiPlataform.Models
{
    public class ProdutoModel : IProdutoModel
    {
        public ProdutoModel(double valorAquisicao, bool necessitaRefrigeracao, double custo, VolumeOcupado volumeOcupado, int validade)
        {
            _valorAquisicao = valorAquisicao;
            _necessitaRefrigeracao = necessitaRefrigeracao;
            _custo = custo;
            _volumeOcupado = volumeOcupado;
            _validade = validade;
        }

        private double _valorAquisicao;

        private bool _necessitaRefrigeracao;

        private double _custo;

        private VolumeOcupado _volumeOcupado;

        private int _validade;

        public int Validade
        {
            get { return _validade; }
        }

        public double ValorAquisicao
        {
            get { return _valorAquisicao; }
        }
        
        public bool NecessitaRefrigeracao
        {
            get { return _necessitaRefrigeracao; }
        }
        
        public double Custo
        {
            get { return _custo; }
        }
        
        public VolumeOcupado VolumeOcupado
        {
            get { return _volumeOcupado; }
        }
    }
}
