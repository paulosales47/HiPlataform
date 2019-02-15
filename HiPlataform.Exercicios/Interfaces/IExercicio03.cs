using System.Collections.Generic;
using HiPlataform.Models;

namespace HiPlataform.Exercicios.Interfaces
{
    public interface IExercicio03
    {
        List<Rua> OrdenaRuaEleitores(List<Casa> casas);
    }
}