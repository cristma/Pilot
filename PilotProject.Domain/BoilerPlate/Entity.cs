using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.BoilerPlate
{
    internal class Entity<T> where T : ValueObject
    {
        protected Entity() { }

        protected Entity(T value)
        {
            this.Id = value;
        }

        public T Id { get; protected set; }
    }
}
