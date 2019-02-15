using HiPlataform.Exercicios.Interfaces;
using HiPlataform.Models.Interfaces;
using System;

namespace HiPlataform.Exercicios
{
    public class Exercicio02 : IExercicio02
    {
        public double FormulaMagica(IProdutoModel produto, IParametrizacaoDesconto parametrizacao)
        {
            if (ValidadeAbaixoDoParametrizado(produto, parametrizacao))
            {
                int diasValidadeAbaixoDoParametrizado = parametrizacao.LimiteDiasDesconto - produto.Validade;

                double descontoAplicado = Convert.ToDouble(parametrizacao.LimiteDiasDesconto - produto.Validade) / Convert.ToDouble(parametrizacao.LimiteDiasDesconto);

                double valorProdutoDesconto = produto.Custo * (1 - descontoAplicado);

                AplicarDescontoAdicionalVolumeOcupado(produto, parametrizacao, ref valorProdutoDesconto);

                if (valorProdutoDesconto < produto.ValorAquisicao && parametrizacao.PermitePrecoAbaixoValorAquisicao)
                {
                    bool descontoAbaixoDoMinimoParametrizado = valorProdutoDesconto < parametrizacao.ValorMinimoVenda;

                    return descontoAbaixoDoMinimoParametrizado ? parametrizacao.ValorMinimoVenda : valorProdutoDesconto; 
                }

                return produto.ValorAquisicao;
            }

            return produto.Custo;
        }

        private void AplicarDescontoAdicionalVolumeOcupado(IProdutoModel produto, IParametrizacaoDesconto parametrizacao, ref double valorDescontoProduto)
        {
            double porcetagemDescontoAdicional = (int)produto.VolumeOcupado * parametrizacao.PercentualDescontoAdicionalVolumeOcupado;
            valorDescontoProduto *= (1 - porcetagemDescontoAdicional);
        }

        private bool ValidadeAbaixoDoParametrizado(IProdutoModel produto, IParametrizacaoDesconto parametrizacaoDesconto)
        {
            return produto.Validade < parametrizacaoDesconto.LimiteDiasDesconto;
        }
    }
}
