using PilotProject.Domain.BoilerPlate;
using PilotProject.Utilities.Enumerations;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Approaches
{
    [DataContract(Namespace = "OptimalConfiguration", Name = "Criteria")]
    internal class Criteria : ValueObject
    {
        public Criteria(CriteriaTypes value)
        {
            Contract.Assert(value != CriteriaTypes.UNDEFINED && value != CriteriaTypes.SIZE_OF, "Criteria must be valid value.");
            this.Value = value;
        }

        [DataMember(Name = "Value", EmitDefaultValue = true, IsRequired = true)]
        public CriteriaTypes Value { get; private set; }

        public static implicit operator CriteriaTypes(Criteria value) { return value != null ? value.Value : CriteriaTypes.UNDEFINED; }
        public static implicit operator Criteria(CriteriaTypes value) { return new Criteria(value); }
    }
}
