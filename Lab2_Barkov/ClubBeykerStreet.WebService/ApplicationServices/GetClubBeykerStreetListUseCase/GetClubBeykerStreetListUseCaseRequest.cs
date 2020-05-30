using ClubBeykerStreet.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubBeykerStreet.ApplicationServices.GetClubBeykerStreetListUseCase
{
    public class GetRouteListUseCaseRequest : IUseCaseRequest<GetClubBeykerStreetListUseCaseResponse>
    {
        public long? OrganizationId { get; private set; }
        public long? RouteId { get; private set; }

        private GetClubBeykerStreetListUseCaseRequest()
        { }

        public static GetClubBeykerStreetListUseCaseRequest CreateAllRoutesRequest()
        {
            return new GetClubBeykerStreetListUseCaseRequest();
        }

        public static GetClubBeykerStreetListUseCaseRequest CreateRouteRequest(long routeId)
        {
            return new GetClubBeykerStreetListUseCaseRequest() { RouteId = routeId };
        }
        public static GetRClubBeykerStreetListUseCaseRequest CreateOrganizationRoutesRequest(long organizationId)
        {
            return new GetClubBeykerStreetListUseCaseRequest() { OrganizationId = organizationId };
        }
    }
}
