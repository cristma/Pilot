using PilotProject.ApplicationServices.Aeronautical;
using PilotProject.ApplicationServices.Violations;
using PilotProject.Domain.Aeronautical;
using PilotProject.Domain.Approaches;
using PilotProject.Domain.Approaches.Repositories;
using PilotProject.Utilities.Enumerations;
using System;
using System.Diagnostics.Contracts;

namespace PilotProject.ApplicationServices.Approaches.Impl
{
    internal class ApproachApplicationService
    {
        private readonly IAeronauticalService aeroService;
        private readonly IViolationsService violationsService;
        private readonly IApproachRepository repository;

        public ApproachApplicationService(
            IAeronauticalService aeroService, 
            IViolationsService violationsService, 
            IApproachRepository repository)
        {
            Contract.Assert(aeroService != null, "Aeronautical application service must be defined.");
            Contract.Assert(violationsService != null, "Violations service must be defined.");
            Contract.Assert(repository != null, "Approach repository must be defined.");

            this.aeroService = aeroService;
            this.violationsService = violationsService;
            this.repository = repository;
        }

        public void CreateApproach(
            string name, 
            string aerodromeId, 
            string runwayId, 
            CriteriaTypes criteria, 
            LandingType landingType)
        {
            Approach approach = new Approach(Guid.NewGuid(), name, aerodromeId, runwayId, criteria, landingType);
            this.repository.Save(approach);
        }

        public Approach LoadApproach(ApproachId id)
        {
            Approach approach = this.repository.Get(id);
            return approach;
        }
    }
}
