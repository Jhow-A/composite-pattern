using System;

namespace CompositePattern.Component
{
    public abstract class HorasTrabalhadas
    {
        public string Nome { get; set; }
        public abstract int GetHorasTrabalhadas();

        public virtual void Add(HorasTrabalhadas component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(HorasTrabalhadas component)
        {
            throw new NotImplementedException();
        }
    }
}
