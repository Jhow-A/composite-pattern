using CompositePattern.Composite;
using CompositePattern.Leaf;
using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Organização (Composite object)
            var organizacao = new Organizacao { Nome = "Locações de Automóveis Ltda" };

            // Funcionario (Leaf)
            var departamentoTI = new Organizacao { Nome = " TI " };
            departamentoTI.Add(new Funcionario { Id = 1, Nome = "Lucas", Horas = 40 });
            departamentoTI.Add(new Funcionario { Id = 2, Nome = "Gabriela", Horas = 37 });
            departamentoTI.Add(new Funcionario { Id = 3, Nome = "Rafael", Horas = 35 });
            
            var departamentoContabilidade = new Organizacao { Nome = "Contabilidade" };
            departamentoContabilidade.Add(new Funcionario { Id = 4, Nome = "Letícia", Horas = 39 });
            departamentoContabilidade.Add(new Funcionario { Id = 5, Nome = "Giovana", Horas = 40 });
            
            organizacao.Add(departamentoTI);
            organizacao.Add(departamentoContabilidade);

            // HorasTrabalhadas (Component)
            organizacao.GetHorasTrabalhadas();
        }
    }
}
