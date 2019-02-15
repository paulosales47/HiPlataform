using HiPlataform.Models.Interfaces;

namespace HiPlataform.Models
{
    public class ParametrizacaoDesconto : IParametrizacaoDesconto
    {
        public ParametrizacaoDesconto(int limiteDiasDesconto, bool permitePrecoAbaixoValorAquisicao, double percentualDescontoAdicionalVolumeOcupado, double valorMinimoVenda)
        {
            _limiteDiasDesconto = limiteDiasDesconto;
            _permitePrecoAbaixoValorAquisicao = permitePrecoAbaixoValorAquisicao;
            _percentualDescontoAdicionalVolumeOcupado = percentualDescontoAdicionalVolumeOcupado;
            _valorMinimoVenda = valorMinimoVenda;
        }
        
        private int _limiteDiasDesconto;
        
        private bool _permitePrecoAbaixoValorAquisicao;

        private double _percentualDescontoAdicionalVolumeOcupado;

        private double _valorMinimoVenda;

        public double ValorMinimoVenda
        {
            get { return _valorMinimoVenda; }
        }

        public double PercentualDescontoAdicionalVolumeOcupado
        {
            get { return _percentualDescontoAdicionalVolumeOcupado / 100; }
        }
        
        public bool PermitePrecoAbaixoValorAquisicao
        {
            get { return _permitePrecoAbaixoValorAquisicao; }
        }

        public int LimiteDiasDesconto
        {
            get { return _limiteDiasDesconto; }
        }
    }
}
