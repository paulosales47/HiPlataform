using HiPlataform.Exercicios.Interfaces;
using HiPlataform.Ioc;
using HiPlataform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace HiPlataform.Exercicios.Test
{
    public class Exercicio03Test
    {
        private readonly ITestOutputHelper _output;

        public Exercicio03Test(ITestOutputHelper output)
        {
            _output = output;
            Injetor.ConfiguraContainer();
        }

        [Fact]
        public void Ordernar_RuasEleitores()
        {
            IExercicio03 exercicio03 = Injetor.container.GetInstance<IExercicio03>();
            var rua1 = new Rua("11000-000", "Rua 1");
            var rua2 = new Rua("11000-001", "Rua 2");
            var rua3 = new Rua("11000-002", "Rua 3");

            var casas = new List<Casa>
            {
                new Casa(rua1, 1, 20)
                ,
                new Casa(rua2, 1, 30)
                ,
                new Casa(rua1, 1, 10)
                ,
                new Casa(rua2, 1, 25)
                ,
                new Casa(rua3, 1, 45)
            };

            var ruas = exercicio03.OrdenaRuaEleitores(casas);

            Assert.Equal(rua2, ruas[0]);
            Assert.Equal(rua3, ruas[1]);
            Assert.Equal(rua1, ruas[2]);
            Assert.Equal(3, ruas.Count);
                        
        }


    }
}
