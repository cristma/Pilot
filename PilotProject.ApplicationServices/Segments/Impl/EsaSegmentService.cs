using PilotProject.Domain.Aeronautical;
using PilotProject.Domain.Approaches;
using PilotProject.Domain.Segments;
using PilotProject.Domain.Segments.Repositories;
using PilotProject.Infrastructure.Serialization;
using PilotProject.Utilities.Units;
using System;

namespace PilotProject.ApplicationServices.Segments.Impl
{
    internal class EsaSegmentService
    {
        private readonly string optimalConfigurationFile = @"OptimalEsaConfiguration.xml";
        private readonly string esaRootElement = "EsaConfiguration";
        private readonly string optimalNamespace = "OptimalConfiguration";

        private readonly ISerializationService serializationService;
        private readonly IEsaRepository repository;

        public EsaSegmentService(
            ISerializationService serializationService,
            IEsaRepository repository)
        {
            if (serializationService == null)
            {
                throw new ArgumentNullException("serializationService");
            }

            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }

            this.serializationService = serializationService;
            this.repository = repository;
        }

        public void CreateEsa(ApproachId approach, Radius radius, LocationId centerPoint)
        {
            Esa esa = new Esa(Guid.NewGuid(), approach, radius, centerPoint);
            this.repository.Save(esa);
        }

        /// <summary>
        /// Acquires the optimal ESA as defined by XML configuration.
        /// </summary>
        /// <returns>The optimal configuration as defined by the XML configuration.</returns>
        public Esa GetOptimalEsa()
        {
            Esa optimal = this.serializationService.Deserialize<Esa>(this.optimalConfigurationFile, this.esaRootElement, this.optimalNamespace);

            return optimal;
        }

        /// <summary>
        /// This method will generate the default optimal ESA (for initial configuration file generation only).
        /// </summary>
        public void GenerateDefaultOptimalEsa()
        {
            Radius radius = new NauticalMiles(100.0);
            Esa esa = new Esa(radius);

            this.serializationService.Serialize<Esa>(esa, this.optimalConfigurationFile, this.esaRootElement, this.optimalNamespace);
        }
    }
}