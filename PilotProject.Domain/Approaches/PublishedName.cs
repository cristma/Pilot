using PilotProject.Domain.BoilerPlate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Approaches
{
    internal class PublishedName : ValueObject
    {
        public PublishedName(string name)
        {
            this.Value = name;
        }

        public string Value { get; private set; }
        public static implicit operator string(PublishedName value) { return value != null ? value.Value : string.Empty; }
        public static implicit operator PublishedName(string value) { return new PublishedName(value); }
    }
}