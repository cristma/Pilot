using PilotProject.Domain.BoilerPlate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Aeronautical
{
    internal class Location : Entity<LocationId>
    {
        public Location(
            LocationId id, 
            Latitude latitude, 
            Longitude longitude)
            : base(id)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public Latitude Latitude { get; private set; }
        public Longitude Longitude { get; private set; }
    }
}
