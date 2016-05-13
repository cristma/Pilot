using PilotProject.Domain.BoilerPlate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Aeronautical
{
    internal class Aerodrome : Entity<AerodromeId>
    {
        public Aerodrome(
            AerodromeId id, 
            HostIdentifier hostId, 
            IcaoCode icaoCode, 
            ArpCoordinate location)
            : base (id)
        {
            this.HostId = hostId;
            this.IcaoCode = icaoCode;
        }

        public HostIdentifier HostId { get; private set; }
        public IcaoCode IcaoCode { get; private set; }
        public ArpCoordinate Location { get; private set; }
    }
}
