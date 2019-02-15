using HiPlataform.Exercicios.Interfaces;
using HiPlataform.Models;
using System.Collections.Generic;
using System.Linq;

namespace HiPlataform.Exercicios
{
    public class Exercicio03 : IExercicio03
    {
        public List<Rua> OrdenaRuaEleitores(List<Casa> casas)
        {

            var dicionarioCasas = new Dictionary<Rua, int>();
            
            casas.ForEach((casa) =>
            {
                if (dicionarioCasas.ContainsKey(casa.Rua))
                {
                    dicionarioCasas[casa.Rua] += casa.TotalEleitores;
                }
                else
                    dicionarioCasas.Add(casa.Rua, casa.TotalEleitores);

            });
            
            var ruas = dicionarioCasas
                .OrderByDescending(casa => casa.Value)
                .Select(casa => casa.Key)
                .ToList();

            return ruas;
        }
    }
}
