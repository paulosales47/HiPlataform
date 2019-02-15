using HiPlataform.Exercicios.Interfaces;
using HiPlataform.Ioc;
using HiPlataform.Models;
using HiPlataform.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace HiPlataform.Exercicios.Test
{
    public class Exercicio02Test
    {
        private readonly ITestOutputHelper _output;

        public Exercicio02Test(ITestOutputHelper output)
        {
            Injetor.ConfiguraContainer();
            _output = output;
        }

        [Fact]
        [Trait("Teste_Unidade", "Exercicio02")]
        public void Calcular_ValorDesconto_RetornarPrecoCusto()
        {
            IExercicio02 exercicio02 = Injetor.container.GetInstance<IExercicio02>();
            IProdutoModel produto = new ProdutoModel(100, true, 150, VolumeOcupado.PEQUENO, 30);
            IParametrizacaoDesconto parametrizacao = new ParametrizacaoDesconto(15, false, 5, 1);

            double valorDesconto = exercicio02.FormulaMagica(produto, parametrizacao);
            
            Assert.Equal(produto.Custo, valorDesconto);
        }

        [Fact]
        [Trait("Teste_Unidade", "Exercicio02")]
        public void Calcular_ValorDesconto_RetornarValorAquisicao()
        {
            IExercicio02 exercicio02 = Injetor.container.GetInstance<IExercicio02>();
            IProdutoModel produto = new ProdutoModel(100, true, 150, VolumeOcupado.PEQUENO, 15);
            IParametrizacaoDesconto parametrizacao = new ParametrizacaoDesconto(30, false, 5, 1);

            double valorDesconto = exercicio02.FormulaMagica(produto, parametrizacao);

            Assert.Equal(produto.ValorAquisicao, valorDesconto);
        }

        [Fact]
        [Trait("Teste_Unidade", "Exercicio02")]
        public void Calcular_ValorDesconto_Retornar50PorcentoDesconto()
        {
            IExercicio02 exercicio02 = Injetor.container.GetInstance<IExercicio02>();
            IProdutoModel produto = new ProdutoModel(100, true, 150, VolumeOcupado.PEQUENO, 15);
            IParametrizacaoDesconto parametrizacao = new ParametrizacaoDesconto(30, true, 0, 1);

            double valorDesconto = exercicio02.FormulaMagica(produto, parametrizacao);

            Assert.Equal(produto.Custo / 2, valorDesconto);
        }

        [Fact]
        [Trait("Teste_Unidade", "Exercicio02")]
        public void Calcular_ValorDesconto_RetornarValorMinimoVenda()
        {
            IExercicio02 exercicio02 = Injetor.container.GetInstance<IExercicio02>();
            IProdutoModel produto = new ProdutoModel(100, true, 150, VolumeOcupado.PEQUENO, 10);
            IParametrizacaoDesconto parametrizacao = new ParametrizacaoDesconto(1000, true, 0, 40);

            double valorDesconto = exercicio02.FormulaMagica(produto, parametrizacao);

            Assert.Equal(parametrizacao.ValorMinimoVenda, valorDesconto);
        }

    }
}
