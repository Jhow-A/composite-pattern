using CompositePattern.Component;
using System;
using System.Collections.Generic;

namespace CompositePattern.Composite
{
    public class Organizacao : HorasTrabalhadas
    {
        protected List<HorasTrabalhadas> departamentos = new List<HorasTrabalhadas>();

        public override void Add(HorasTrabalhadas component)
        {
            departamentos.Add(component);
        }

        public override void Remove(HorasTrabalhadas component)
        {
            departamentos.Remove(component);
        }

        public override int GetHorasTrabalhadas()
        {
            var horasTrabalhadasDepartamento = default(int);
            foreach (var departamento in departamentos)
                horasTrabalhadasDepartamento += departamento.GetHorasTrabalhadas();

            Console.WriteLine($"{Nome} registrou um total de [{horasTrabalhadasDepartamento}] horas trabalhadas\n");
            return horasTrabalhadasDepartamento;
        }
    }
}
