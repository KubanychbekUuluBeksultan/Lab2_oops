using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ClubBeykersStreet.DomainObjects.Ports
{
    public interface IReadOnlyClubBeykerStreetRepository
    {
        Task<ClubBeykerStreet> GetClubBeykerStreet(long id);

        Task<IEnumerable<ClubBeykerStreet>> GetAllClubBeykerStreet();

        Task<IEnumerable<ClubBeykerStreet>> QueryClubBeykerStreet(ICriteria<ClubBeykerStreet> criteria);

    }

    public interface IClubBeykerStreetRepository
    {
        Task AddClubBeykerStreet(ClubBeykerStreet clubBeykerStreet);

        Task RemoveClubBeykerStreet(ClubBeykerStreet clubBeykerStreet);

        Task UpdateClubBeykerStreet(ClubBeykerStreet clubBeykerStreet);
    }
}