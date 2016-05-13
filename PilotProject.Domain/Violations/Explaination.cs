using PilotProject.Domain.BoilerPlate;
using System.Diagnostics.Contracts;

namespace PilotProject.Domain.Violations
{
    internal class Explaination : ValueObject
    {
        public Explaination(string value)
        {
            Contract.Assert(value.Length < 256, "Violation reasoning cannot exceed 255 characters.");
            this.Value = value;
        }

        public string Value { get; private set; }
        public static implicit operator string(Explaination value) { return value != null ? value.Value : string.Empty; }
        public static implicit operator Explaination(string value) { return new Explaination(value); }
    }
}