using PilotProject.Domain.BoilerPlate;

namespace PilotProject.Domain.Aeronautical
{
    internal class Runway : Entity<RunwayId>
    {
        public Runway(
            RunwayId id, 
            RunwayIdentifier identifier, 
            Location threshold, 
            Location derLocation)
            : base(id)
        {
            this.Identifier = identifier;
            this.Threshold = threshold;
            this.DerLocation = derLocation;
        }

        public RunwayIdentifier Identifier { get; private set; }
        public Location Threshold { get; private set; }
        public Location DerLocation { get; private set; }
    }
}