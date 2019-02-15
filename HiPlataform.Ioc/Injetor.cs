using HiPlataform.Exercicios;
using HiPlataform.Exercicios.Interfaces;
using SimpleInjector;

namespace HiPlataform.Ioc
{
    public static class Injetor
    {
        public static Container container;

        public static void ConfiguraContainer()
        {
            container = new Container();
            container.Register<IExercicio02, Exercicio02>(Lifestyle.Transient);
            container.Register<IExercicio03, Exercicio03>(Lifestyle.Transient);
            container.Verify();
        }
    }
}
