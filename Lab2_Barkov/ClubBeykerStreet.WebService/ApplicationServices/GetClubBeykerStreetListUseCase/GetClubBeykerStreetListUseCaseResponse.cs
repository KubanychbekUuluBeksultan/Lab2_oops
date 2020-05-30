using ClubBeykerStreet.DomainObjects;
using ClubBeykerStreet.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubBeykerStreet.ApplicationServices.GetRClubBeykerStreetListUseCase
{
    public class GetListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<Route> Routes { get; }

        public GetClubBeykerStreetListUseCaseResponse(IEnumerable<Route> routes) => Routes = routes;
    }
}
