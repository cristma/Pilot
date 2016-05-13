using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain.Aeronautical
{
    internal class ArpCoordinate : Location
    {
        public ArpCoordinate(
            LocationId id,
            Latitude latitude,
            Longitude longitude,
            Declination declination)
            : base(id, latitude, longitude)
        {
            this.AssignedVariance = declination;
        }

        public Declination AssignedVariance { get; private set; }
    }
}