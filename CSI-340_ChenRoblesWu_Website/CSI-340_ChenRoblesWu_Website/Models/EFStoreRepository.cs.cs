using CSI_340_ChenRoblesWu_Website.Data;
using System.Linq;

namespace CSI_340_ChenRoblesWu_Website.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private DataContext context;
        public EFStoreRepository(DataContext ctx)
        {
            context = ctx;
        }
        public IQueryable<BookModel> Books => context.Book;
    }

}
