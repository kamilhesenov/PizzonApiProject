using Data.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Data
{
     public interface IUnitOfWork 
    {
        IBannerRepository Banner { get; }
        Task<int> CommitAsync();
    }
}
