using CompositePattern.Component;
using System;

namespace CompositePattern.Leaf
{
    public class Funcionario : HorasTrabalhadas
    {
        public int Id { get; set; }
        public int Horas { get; set; }

        public override int GetHorasTrabalhadas()
        {
            Console.WriteLine($"O funcionário {Id}-{Nome} registrou {Horas} horas trabalhadas");
            return Horas;
        }
    }
}
