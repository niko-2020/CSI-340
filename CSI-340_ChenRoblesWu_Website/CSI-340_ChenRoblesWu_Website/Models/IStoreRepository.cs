using System.Linq;

namespace CSI_340_ChenRoblesWu_Website.Models
{
    public interface IStoreRepository
    {
        public IQueryable<BookModel> Books { get; }
    }
}
