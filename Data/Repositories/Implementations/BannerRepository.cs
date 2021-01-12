using Data.Entities;
using Data.Repositories.Interfaces;

namespace Data.Repositories.Implementations
{
    public class BannerRepository : Repository<Banner>, IBannerRepository
    {

        public BannerRepository(PizzonDbContext context): base(context)
        {

        }

    }
}
