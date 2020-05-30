using System.Threading.Tasks;
using System.Collections.Generic;
using ClubBeykerStreet.DomainObjects;
using ClubBeykerStreet.DomainObjects.Ports;
using ClubBeykerStreet.ApplicationServices.Ports;

namespace ClubBeykerStreet.ApplicationServices.GetRouteListUseCase
{
    public class GetClubBeykerStreetListUseCase : IGetRouteListUseCase
    {
        private readonly IReadOnlyRouteRepository _readOnlyClubBeykerStreetRepository;

        public GetClubBeykerStreetListUseCase(IReadOnlyRouteRepository readOnlyRouteRepository)
            => _readOnlyClubBeykerStreetRepository = readOnlyRouteRepository;

        public async Task<bool> Handle(GetRouteListUseCaseRequest request, IOutputPort<GetRouteListUseCaseResponse> outputPort)
        {
            IEnumerable<ClubBeykerStreet> routes = null;
            if (request.RouteId != null)
            {
                var route = await _readOnlyClubBeykerStreetRepository.GetRoute(request.RouteId.Value);
                routes = (route != null) ? new List<ClubBeykerStreet>() { route } : new List<ClubBeykerStreet>();

            }
            else if (request.OrganizationId != null)
            {
                routes = await _readOnlyClubBeykerStreetRepository.QueryRoutes(new TransportOrganizationCriteria(request.OrganizationId.Value));
            }
            else
            {
                routes = await _readOnlyClubBeykerStreetRepository.GetAllRoutes();
            }
            outputPort.Handle(new GetRouteListUseCaseResponse(routes));
            return true;
        }
    }
}
